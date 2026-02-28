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
            // Здесь можно добавить базовую валидацию на пустоту полей перед закрытием
            this.DialogResult = DialogResult.OK; // Устанавливаем результат OK
            //this.Close(); // Закрываем форму

            // 1. Валидация (копируем из вашего AddFactToBox)
            if (cmbObject.SelectedItem == null || cmbUnit.SelectedItem == null ||
                cmbAttribute.SelectedItem == null || string.IsNullOrWhiteSpace(cmbValue.Text))
            {
                MessageBox.Show("Заполните все поля факта для поиска.");
                return;
            }

            // 2. Поиск реального факта через FirstOrDefault
            Fact foundFact = dataBaseThis.dictionaryFacts.Values.FirstOrDefault(f =>
                f.Group == cmbObject.Text &&
                f.Unit == cmbUnit.Text &&
                f.Atribute == cmbAttribute.Text &&
                f.Value == cmbValue.Text.Trim());

            // 3. Результат
            if (foundFact != null)
            {
                SelectedFact = foundFact;
                MessageBox.Show($"Рекомендация сохранена!");
            }
            else
            {
                MessageBox.Show("Факт не найден в базе данных!");
                SelectedFact = null;
            }
        }

        // Кнопка - Закрыть форму
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
                cmbObject.Text = rec.TargetFact.Group;
                cmbUnit.Text = rec.TargetFact.Unit;
                cmbAttribute.Text = rec.TargetFact.Atribute;
                cmbValue.Text = rec.TargetFact.Value;

                // Помечаем факт как выбранный (чтобы метод CreateRecommendation его увидел)
                this.SelectedFact = rec.TargetFact;
            }
        }

        public FactRecommend CreateRecommendation()
        {
            // Возвращаем объект нашего нового класса
            return new FactRecommend(SelectedFact!, AdviceText, Priority);
        }
    }
}
