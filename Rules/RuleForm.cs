using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ExpertBase.Правила
{
    public partial class RuleForm : Form
    {
        private DataBase dataBaseRF; // хранит ссылку на базу данных (RF - rule form)

        // Списки, которыми управляет логика
        public List<Fact> listCurrentPremises { get; set; } = new List<Fact>();
        public List<Fact> listCurrentConclusions { get; set; } = new List<Fact>();

        // Публичные свойства для простых полей
        public string RuleDescription => textBoxDescription.Text;
        public double RuleTruth => (double)numTruth.Value;

        public RuleForm()
        {
            InitializeComponent();
        }

        public void InitializeData(DataBase db)
        {
            dataBaseRF = db; //получаем ссылку на базу        
        }

        // Метод добавления в посылку (теперь это метод формы)
        public void AddPremise(Fact fact)
        {
            if (fact != null && !listCurrentPremises.Contains(fact)) // если объект не пустой и его нет в списке
            {
                listCurrentPremises.Add(fact);
            }
        }

        // Метод добавления в заключение (аналогично)
        public void AddConclusion(Fact fact)
        {
            if (fact != null && !listCurrentConclusions.Contains(fact))
            {
                listCurrentConclusions.Add(fact);
            }
        }

        // Методы генерации текста для UI
        public string GetPremiseString() => string.Join(" && ", listCurrentPremises.Select(f => f.ToString()));
        public string GetConclusionString() => string.Join(" && ", listCurrentConclusions.Select(f => f.ToString()));

        // Метод создания финального объекта Rule (теперь внутри формы)
        public Rule CreateRule(int id, string description, double truth)
        {
            // Мы создаем новое правило, передавая КОПИИ списков из формы
            return new Rule(id, description,
                            new List<Fact>(this.listCurrentPremises),
                            new List<Fact>(this.listCurrentConclusions),
                            truth);
        }

        // Метод для передачи списка существующих фактов в форму, чтобы для автозаполнения ComboBox'ов
        public void LoadSuggestionsForRules(List<string> objects, List<string> units, List<string> attributes, List<string> values)
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

        //Метод загружает данные существующего правила в форму 
        public void LoadRuleData(Rule rule)
        {
            // 1. Загружаем простые данные в элементы управления (UI)
            numTruth.Value = (decimal)rule.Truth;
            textBoxDescription.Text = rule.Description;

            // 2. Копируем списки             
            listCurrentPremises = new List<Fact>(rule.listPremise);
            listCurrentConclusions = new List<Fact>(rule.listConclusion);

            // 3. Обновляем визуальную часть (RichTextBox)
            // Используем уже готовые строки из самого правила
            richBoxCondition.Text = rule.strPremise;
            richBoxConclusion.Text = rule.strConclusion;
        }

        // Метод добавляет факт в посылку или заключение
        private void AddFactToBox(bool isPremise)
        {
            // 1. Простая валидация ввода
            if (cmbObject.SelectedItem == null || cmbUnit.SelectedItem == null || cmbAttribute.SelectedItem == null || string.IsNullOrWhiteSpace(cmbValue.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля факта (Объект, Узел, Атрибут, Значение).");
                return;
            }

            // 2. Ищем реальный факт
            Fact foundFact = dataBaseRF.dictionaryFacts.Values.FirstOrDefault(f =>
                f.Group == cmbObject.Text &&
                f.Unit == cmbUnit.Text &&
                f.Atribute == cmbAttribute.Text &&
                f.Value == cmbValue.Text.Trim());

            // 3. Добавляем в нужный список
            if (foundFact != null)
            {
                // Нашли! Теперь в правило попадет объект с правильным ID, типом и Modbus
                if (isPremise)
                {
                    AddPremise(foundFact);
                    richBoxCondition.Text = GetPremiseString();
                }
                else
                {
                    AddConclusion(foundFact);
                    richBoxConclusion.Text = GetConclusionString();
                }
            }
            else
            {
                MessageBox.Show("Этот факт не найден в справочнике!");
            }
        }

        // Метод добавления логического оператора в посылку
        private void AddOperatorToCondition(string str)
        {
            // Проверяем, что поле Посылки не пустое, чтобы не начинать выражение с оператора
            if (!string.IsNullOrWhiteSpace(richBoxCondition.Text))
            {
                // Добавляем пробелы вокруг оператора для читаемости
                richBoxCondition.AppendText(" " + str + " ");
            }
        }

        // Ккнопка - Добавить факт в посылку
        private void btnAddCondition_Click(object sender, EventArgs e)
        {
            AddFactToBox(true); // Метод AddFactToBox добавляет факт в поле Посылки
        }

        // Ккнопка - Добавить факт в заключение
        private void btnAddConsequence_Click(object sender, EventArgs e)
        {
            AddFactToBox(false); // Метод AddFactToBox добавляет факт в поле Заключения
        }

        // Ккнопка - Сохранить правило
        private void btnOkRule_Click(object sender, EventArgs e)
        {
            // Здесь можно добавить базовую валидацию на пустоту полей перед закрытием
            this.DialogResult = DialogResult.OK; // Устанавливаем результат OK
            this.Close(); // Закрываем форму
        }

        // Кнопка - Закрыть форму
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Кнопка - Очиситить посылку
        private void btnClearPremise_Click(object sender, EventArgs e)
        {
            // 1. Очищаем сам список
            this.listCurrentPremises.Clear();

            // 2. Очищаем визуальное текстовое поле
            richBoxCondition.Clear();
        }

        // Кнопка - Очиситить заключение
        private void btnClearConclusion_Click(object sender, EventArgs e)
        {
            this.listCurrentConclusions.Clear();
            richBoxConclusion.Clear();

        }

        // Кнопка "&&" в посылке
        private void btnAnd_Click(object sender, EventArgs e)
        {
            AddOperatorToCondition("&&"); // стандартный C# символ И
        }

        // Кнопка "||" в посылке
        private void btnOr_Click(object sender, EventArgs e)
        {
            AddOperatorToCondition("||"); // стандартный C# символ ИЛИ
        }

        // Кнопка "!" в посылке
        private void btnNot_Click(object sender, EventArgs e)
        {
            richBoxCondition.AppendText("!"); // Оператор НЕ обычно ставится сразу перед фактом
        }

        // Кнопка ">" вставить в посылку
        private void btnMore_Click(object sender, EventArgs e)
        {
            AddOperatorToCondition(">"); // вставить в посылку лог. оператор больше
        }

        // Кнопка  "<" вставить в посылку
        private void btnLess_Click(object sender, EventArgs e)
        {
            AddOperatorToCondition("<"); // вставить в посылку лог. оператор меньше
        }

        //Кнопка - "==" вставить в посылку
        private void btnEqual_Click(object sender, EventArgs e)
        {
            AddOperatorToCondition("=="); // вставить в посылку лог. оператор равно
        }

       
    }
}
