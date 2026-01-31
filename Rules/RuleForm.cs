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

namespace ExpertBase_v1.Правила
{
    public partial class RuleForm : Form
    {
        // Публичные свойства для доступа к данным извне (по аналогии с FactForm)
        public string RuleDescription => textBoxDescription.Text;
        public string RuleCondition => richBoxCondition.Text;
        public string RuleConsequence => richBoxConsequence.Text;
        public double RuleTruth => (double)numTruth.Value;
        public string RuleValue => cmbValue.Text;

        public RuleForm()
        {
            InitializeComponent();
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

        // Метод для загрузки данных существующего правила (для режима редактирования)
        public void LoadRuleData(Rule rule)
        {
            numTruth.Value = (decimal)rule.Truth;
            textBoxDescription.Text = rule.Description;
            richBoxCondition.Text = rule.Condition;
            richBoxConsequence.Text = rule.Consequence;
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

        // "&&" в посылке
        private void btnAnd_Click(object sender, EventArgs e)
        {
            AddOperatorToCondition("&&"); // стандартный C# символ И
        }

        // "||" в посылке
        private void btnOr_Click(object sender, EventArgs e)
        {
            AddOperatorToCondition("||"); // стандартный C# символ ИЛИ
        }

        // "!" в посылке
        private void btnNot_Click(object sender, EventArgs e)
        {
            richBoxCondition.AppendText("!"); // Оператор НЕ обычно ставится сразу перед фактом
        }

        // ">" вставить в посылку
        private void btnMore_Click(object sender, EventArgs e)
        {
            AddOperatorToCondition(">"); // вставить в посылку лог. оператор больше
        }

        // "<" вставить в посылку
        private void btnLess_Click(object sender, EventArgs e)
        {
            AddOperatorToCondition("<"); // вставить в посылку лог. оператор меньше
        }

        // "==" вставить в посылку
        private void btnEqual_Click(object sender, EventArgs e)
        {
            AddOperatorToCondition("=="); // вставить в посылку лог. оператор равно
        }

        // Метод добавляет факт в посылку или заключение
        private void AddFactToBox(RichTextBox targetBox)
        {
            // Простая валидация ввода
            if (cmbObject.SelectedItem == null || cmbUnit.SelectedItem == null ||
            cmbAttribute.SelectedItem == null || string.IsNullOrWhiteSpace(cmbValue.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля факта (Объект, Узел, Атрибут, Значение).");
                return;
            }

            // Формируем строку факта в формате: Объект.Узел.Атрибут.Значение
            string factString = $"{cmbObject.SelectedItem}.{cmbUnit.SelectedItem}.{cmbAttribute.SelectedItem}.{cmbValue.Text.Trim()}";

            // Добавляем к текущему тексту в RichBox
            if (!string.IsNullOrWhiteSpace(targetBox.Text))
            {                
                targetBox.AppendText(" "); // Добавляем пробел перед новым фактом
            }
            targetBox.AppendText(factString);
        }

        // Обработчик кнопки Добавить в посылку
        private void btnAddCondition_Click(object sender, EventArgs e)
        {            
            AddFactToBox(richBoxCondition); // Метод AddFactToBox добавляет факт в поле Посылки
        }

        // Обработчик кнопки Добавить в заключение
        private void btnAddConsequence_Click(object sender, EventArgs e)
        {            
            AddFactToBox(richBoxConsequence); // Метод AddFactToBox добавляет факт в поле Заключения
        }

        // Обработчик кнопки Сохранить
        private void btnOkRule_Click(object sender, EventArgs e)
        {
            // Здесь можно добавить базовую валидацию на пустоту полей перед закрытием
            this.DialogResult = DialogResult.OK; // Устанавливаем результат OK
            this.Close(); // Закрываем форму
        }

        // Обработчик кнопки Закрыть
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
