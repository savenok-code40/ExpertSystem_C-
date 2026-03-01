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

            // 2. ЗАЩИТА ОТ ДУБЛЕЙ
            if (txtTargetFact.Text != initialFactString)
            {
                bool isDuplicate = dataBaseThis.listRecommendations // Проверяем, есть ли в базе рекомендация для ТАКОГО ЖЕ факта
                    .Any(r => r.TargetFact.Equals(this.SelectedFact)); // Используем .Any и .Equals

                if (isDuplicate)
                {
                    MessageBox.Show("Для факта уже существует рекомендация в базе!",
                                    "Дубликат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Не даем сохранить, выходим из метода
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
            // Предполагая, что имена ваших ComboBox'ов: cmbObject, cmbUnit, cmbAttribute
            cmbObject.DataSource = objects;
            cmbUnit.DataSource = units;
            cmbAttribute.DataSource = attributes;
            cmbValue.DataSource = values;

            // Включение режима автозаполнения
            cmbObject.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbObject.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUnit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnit.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbAttribute.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbAttribute.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbValue.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbValue.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        //Метод загружает данные существующей рекомендации
        public void LoadRecommendData(FactRecommend rec)
        {
            // Заполняем текстовые поля из объекта рекомендации
            textBoxName.Text = "Рекомендация"; // Или другое поле, если оно есть
            numPriority.Value = rec.Priority;
            richTextRecommendation.Text = rec.AdviceText;

            // Устанавливаем значения в ComboBox для целевого факта
            if (rec.TargetFact != null)
            {
                this.SelectedFact = rec.TargetFact; // запоминаем объект
                txtTargetFact.Text = rec.TargetFact.ToString(); 
                txtTargetFact.BackColor = Color.LightGreen;
                initialFactString = txtTargetFact.Text; // запоминаем что было в поле при открытии

                cmbObject.Text = rec.TargetFact.Group;
                cmbUnit.Text = rec.TargetFact.Unit;
                cmbAttribute.Text = rec.TargetFact.Atribute;
                cmbValue.Text = rec.TargetFact.Value;
            }
        }

        public FactRecommend CreateRecommendation()
        {
            // Возвращаем объект нашего нового класса
            return new FactRecommend(SelectedFact!, AdviceText, Priority);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // 1. Валидация выбора в комбобоксах
            if (cmbObject.SelectedItem == null || cmbUnit.SelectedItem == null ||
                cmbAttribute.SelectedItem == null || string.IsNullOrWhiteSpace(cmbValue.Text))
            {
                MessageBox.Show("Заполните все поля для поиска факта.");
                return;
            }

            // 2. Поиск реального факта через FirstOrDefault
            Fact foundFact = dataBaseThis.dictionaryFacts.Values.FirstOrDefault(f =>
                f.Group == cmbObject.Text &&
                f.Unit == cmbUnit.Text &&
                f.Atribute == cmbAttribute.Text &&
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
    }
}
