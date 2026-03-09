using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertBase
{
    public partial class RecommendForm : Form
    {
        private DataBase dataBaseThis; // хранит ссылку на базу данных

        private string initialFactString = string.Empty; // Нужно при проверке на дубликат. Запоминает при редактировании какой факт был.

        private bool _isLoading = false; // флаг, предахронитель, чтобы события фильтрации при открытии формы редактирования сразу не сработали 
        public Fact? SelectedFact { get; private set; }

        // Свойства для новых полей UI
        public string AdviceText => richTextRecommendation.Text; // Ваше большое поле
        public int Priority => (int)numPriority.Value;          // Поле "Приоритет"
        public string RecName => textBoxName.Text;               // Поле "Название"

        public void InitializeData(DataBase db)
        {
            dataBaseThis = db; //получаем ссылку на базу        
        }

        public RecommendForm()
        {
            InitializeComponent();
        }

        // Ккнопка - Сохранить рекомендацию
        private void btnSaveRecommend_Click(object sender, EventArgs e)
        {
            // 1. Проверяем, что факт выбран
            if (this.SelectedFact == null)
            {
                MessageBox.Show("Сначала выберите и подтвердите факт из базы!");
                return;
            }

            // 2. Защита от создания нескольких рекомендаций для одного факта
            // Проверяем, изменился ли факт вообще
            if (txtTargetFact.Text != initialFactString)
            {
                bool isDuplicate = dataBaseThis.listRecommendations
                    .Any(r => r.TargetFact.Equals(this.SelectedFact));

                if (isDuplicate)
                {
                    MessageBox.Show("Для этого факта уже существует рекомендация!", "Дубликат");
                    return;
                }
            }

            // 3. Проверяем, что заполнены название и текст рекомендации
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(richTextRecommendation.Text))
            {
                MessageBox.Show("Заполните название и текст рекомендации.");
                return;
            }

            // Если всё Ок - закрываем форму
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Кнопка - Закрыть форму
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Метод для передачи списка существующих фактов в форму для автозаполнения ComboBox'ов
        public void AutoCompleteFact(List<string> objects, List<string> units, List<string> attributes, List<string> values)
        {
            _isLoading = true;
            cmbObject.DataSource = objects;

            foreach (var cb in new[] { cmbObject, cmbUnit, cmbAtribute, cmbValue })
            {
                cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            }

            _isLoading = false;

            // Если в базе есть данные, принудительно вызываем фильтр для первого элемента
            if (cmbObject.Items.Count > 0)
            {
                cmbObject_SelectedIndexChanged(cmbObject, EventArgs.Empty);
            }
        }

        //Метод загружает данные существующей рекомендации для редактирования
        public void LoadRecommendData(FactRecommend recommendation)
        {
            if (recommendation.TargetFact == null) return;

            // 1. Загружаем простые текстовые поля и приоритет
            _isLoading = true; // Блокируем фильтры на время первичной записи
            richTextRecommendation.Text = recommendation.AdviceText;
            textBoxName.Text = recommendation.Name;
            numPriority.Value = (decimal)recommendation.Priority;

            // 2. КАСКАДНАЯ ЗАГРУЗКА ФАКТА (устанавливаем по цепочке)

            // Шаг 2.1: ОБЪЕКТ
            cmbObject.Text = recommendation.TargetFact.Group;
            _isLoading = false;
            cmbObject_SelectedIndexChanged(cmbObject, EventArgs.Empty); // Наполнили cmbUnit

            // Шаг 2.2: УЗЕЛ
            _isLoading = true;
            cmbUnit.Text = recommendation.TargetFact.Unit;
            _isLoading = false;
            cmbUnit_SelectedIndexChanged(cmbUnit, EventArgs.Empty); // Наполнили cmbAtribute

            // Шаг 2.3: АТРИБУТ
            _isLoading = true;
            cmbAtribute.Text = recommendation.TargetFact.Atribute;
            _isLoading = false;
            cmbAtribute_SelectedIndexChanged(cmbAtribute, EventArgs.Empty); // Наполнили cmbValue

            // Шаг 2.4: ЗНАЧЕНИЕ
            _isLoading = true;
            cmbValue.Text = recommendation.TargetFact.Value;
            _isLoading = false;

            // 3. ФИНАЛИЗАЦИЯ (для защиты от дублей и визуализации)
            this.SelectedFact = recommendation.TargetFact;
            this.initialFactString = recommendation.TargetFact.ToString();

            txtTargetFact.Text = initialFactString;
            txtTargetFact.BackColor = Color.LightGreen;
        }

        // Метод создает объект - рекомендация
        public FactRecommend CreateRecommendation()
        {
            // Возвращаем объект нашего нового класса
            return new FactRecommend(SelectedFact!, RecName, AdviceText, Priority);
        }
        
        // Кнопка - подтвердить факт
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // 1. Валидация выбора в комбобоксах
            if (cmbObject.SelectedItem == null || cmbUnit.SelectedItem == null ||
                cmbAtribute.SelectedItem == null || string.IsNullOrWhiteSpace(cmbValue.Text))
            {
                MessageBox.Show("Заполните все поля для поиска факта.");
                return;
            }

            // 2. Поиск реального факта через FirstOrDefault
            Fact foundFact = dataBaseThis.dictionaryFacts.Values.FirstOrDefault(f =>
                f.Group == cmbObject.Text &&
                f.Unit == cmbUnit.Text &&
                f.Atribute == cmbAtribute.Text &&
                f.Value == cmbValue.Text.Trim());

            // 3. Результат поиска
            if (foundFact != null)
            {
                this.SelectedFact = foundFact;
                // Выводим результат в textBoxTargetFact (тот самый ReadOnly текстбокс)
                txtTargetFact.Text = foundFact.ToString();
                txtTargetFact.BackColor = Color.LightGreen; // Визуальное подтверждение успеха
            }
            else
            {
                MessageBox.Show("Такой факт не найден в базе данных!");
                txtTargetFact.Text = "ФАКТ НЕ НАЙДЕН";
                txtTargetFact.BackColor = Color.MistyRose;
                this.SelectedFact = null;
            }

        }

        // Обработчик события изменния значения - Выбрали Объект -> Фильтруем Узлы
        private void cmbObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading || dataBaseThis == null) return;

            string selectedGroup = cmbObject.Text;
            var filteredUnits = dataBaseThis.dictionaryFacts.Values
                .Where(f => f.Group == selectedGroup)
                .Select(f => f.Unit).Distinct().OrderBy(s => s).ToList();

            cmbUnit.DataSource = filteredUnits;
        }

        // Обработчик события изменния значения - Выбрали Узел -> Фильтруем Атрибуты
        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading || dataBaseThis == null) return;

            string selectedGroup = cmbObject.Text;
            string selectedUnit = cmbUnit.Text;

            var filteredAttributes = dataBaseThis.dictionaryFacts.Values
                .Where(f => f.Group == selectedGroup && f.Unit == selectedUnit)
                .Select(f => f.Atribute).Distinct().OrderBy(s => s).ToList();

            cmbAtribute.DataSource = filteredAttributes;
        }

        // Обработчик события изменния значения - Выбрали Атрибут -> Фильтруем Значения
        private void cmbAtribute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading || dataBaseThis == null) return;

            string selectedGroup = cmbObject.Text;
            string selectedUnit = cmbUnit.Text;
            string selectedAttr = cmbAtribute.Text;

            var filteredValues = dataBaseThis.dictionaryFacts.Values
                .Where(f => f.Group == selectedGroup && f.Unit == selectedUnit && f.Atribute == selectedAttr)
                .Select(f => f.Value).Distinct().OrderBy(s => s).ToList();

            cmbValue.DataSource = filteredValues;
        }
    }
}
