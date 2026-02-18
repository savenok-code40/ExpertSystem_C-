
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
    public partial class FactForm : Form
    {
        public FactForm()
        {
            InitializeComponent();
            InitializeEnumComboBoxes(); // Метод для заполнения ComboBox
        }

        // Метод для загрузки данных существующего факта в элементы управления формы
        public void LoadFactData(Fact existingFact)
        {
            cmbObject.Text = existingFact.Group;
            cmbUnit.Text = existingFact.Unit;
            cmbAtribute.Text = existingFact.Atribute;
            txtValue.Text = existingFact.Value;
            numTruth.Value = (decimal)existingFact.Truth;
            cmbType.SelectedItem = existingFact.Type;           
        }

        // Публичные свойства для доступа к данным извне
        public string FactObject => cmbObject.Text;
        public string FactAttribute => cmbAtribute.Text;
        public string FactValue => txtValue.Text;
        public string FactUnit => cmbUnit.Text;
        public double Truth => (double)numTruth.Value;

        // ?? проверяет левую часть: если результат == null, то берем значение Internal
        public Fact.enTypeFact FactType => (Fact.enTypeFact?)cmbType.SelectedItem ?? Fact.enTypeFact.Internal; 
        
        public Fact.enFunModbus FunModbus => (Fact.enFunModbus?)cmbModbusFun.SelectedItem ?? Fact.enFunModbus.ReadAO_03Fun;
        public int AddrReg => (int)numModbusReg.Value;

        // метод для передачи списка существующих фактов в форму, для автозаполнения ComboBox
        public void AutoFillComboBoxes(List<Fact> existingFacts)
        {
            // Используем HashSet для получения уникальных значений
            var objects = new HashSet<string>(existingFacts.Select(f => f.Group));
            var units = new HashSet<string>(existingFacts.Select(f => f.Unit));
            var attributes = new HashSet<string>(existingFacts.Select(f => f.Atribute));

            cmbObject.Items.AddRange(objects.ToArray());
            cmbUnit.Items.AddRange(units.ToArray());
            cmbAtribute.Items.AddRange(attributes.ToArray());

            // Настройка режима автозаполнения (SuggestAppend - предлагает и дописывает)
            cmbObject.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbObject.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUnit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnit.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbAtribute.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbAtribute.AutoCompleteSource = AutoCompleteSource.ListItems;            
        }

        // Привязываем к ComboBox  значения из перечислений
        private void InitializeEnumComboBoxes()
        {
            // 1. Очищаем существующие элементы (если есть)
            cmbType.Items.Clear();

            // 2. Добавляем все значения из перечисления enTypeFact в ComboBox
            foreach (var typeValue in Enum.GetValues(typeof(Fact.enTypeFact)))
            {
                cmbType.Items.Add(typeValue);
            }

            // 3. Устанавливаем значение по умолчанию (например, Static)
            if (cmbType.Items.Count > 0)
            {
                cmbType.SelectedItem = Fact.enTypeFact.Static; // Выберите тип по умолчанию
            }

            // Логика заполнения ComboBox для Modbus-функций с использованием Enum
            cmbModbusFun.Items.Clear();
            foreach (var funValue in Enum.GetValues(typeof(Fact.enFunModbus)))
            {
                cmbModbusFun.Items.Add(funValue);
            }

            if (cmbModbusFun.Items.Count > 0)
            {
                // Устанавливаем по умолчанию ReadAO_03Fun
                cmbModbusFun.SelectedItem = Fact.enFunModbus.ReadAO_03Fun;
            }
        }

        // Кнопка сохранения созданного факта
        private void btnOk_Click(object sender, EventArgs e)
        {
            // Здесь можно добавить логику валидации (например, проверка на пустые поля)
            // Если все в порядке, устанавливаем результат диалога ОК
            this.DialogResult = DialogResult.OK; //
            this.Close();
        }

        // Кнопка отменить сохранение факта
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Устанавливаем результат диалога Отмена
            this.DialogResult = DialogResult.Cancel; //
            this.Close();
        }
    }
}
