using ExpertBase.Правила;
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
    public partial class RulesControl : UserControl
    {
        private DataBase dataBaseRC; // хранит ссылку на базу данных (RC - rule control)

        private BindingList<Rule> rulesList; // список для хранения правил и наполения DataGrid 
        public BindingList<Rule> RulesList => rulesList; // Публичное свойство списка rulesList

        // Конструктор
        public RulesControl()
        {
            InitializeComponent();
        }

        //Метод вызываем в MainForm, после создания контрола правил
        public void InitializeData(DataBase db)
        {
            dataBaseRC = db; //получаем ссылку на базу из MainForm 
            SetupDataGridRules(); // аналогично как для фактов заполняем DataGrid
        }

        //Метод заполняет таблицу DataGrid правилами
        private void SetupDataGridRules()
        {            
            rulesList = new BindingList<Rule>(dataBaseRC.dictionaryRules.Values.ToList()); // Инициализируем BindingList из текущего списка правил в БД (словаре)
            
            dataGridRules.DataSource = rulesList; // Устанавливает источник данных для DataGridView
        }

        // Метод обновления списка правил, как у фактов:
        public void RefreshDataBinding()
        {
            // Проверка на null для dataBaseRC и rulesList
            if (dataBaseRC != null && rulesList != null)
            {                
                rulesList.Clear(); // Очищаем существующий список

                // Добавляем все актуальные элементы из базы данных в существующий список
                foreach (var rule in dataBaseRC.dictionaryRules.Values.ToList())
                {
                    rulesList.Add(rule);
                }

            }    
        }

        // Кнопка - Добавить правило
        private void btnAddRules_Click(object sender, EventArgs e)
        {
            // Получаем списки для автозаполнения ComboBox из текущих фактов, хранящихся в базе
            var objects = dataBaseRC.dictionaryFacts.Values.Select(f => f.Group).Distinct().ToList();
            var units = dataBaseRC.dictionaryFacts.Values.Select(f => f.Unit).Distinct().ToList();
            var attributes = dataBaseRC.dictionaryFacts.Values.Select(f => f.Atribute).Distinct().ToList();
            var values = dataBaseRC.dictionaryFacts.Values.Select(f => f.Value).Distinct().ToList();

            // Создаем экземпляр RuleForm с конструктором без параметров
            using (var ruleForm = new RuleForm())
            {
                ruleForm.InitializeData(dataBaseRC); // передаем базу в форму

                // Вызываем новый метод для передачи подсказок
                ruleForm.LoadSuggestionsForRules(objects, units, attributes, values);

                if (ruleForm.ShowDialog() == DialogResult.OK)
                {                   
                    var newRule = new Rule
                    {
                        Description = ruleForm.RuleDescription,
                        listPremise = new List<Fact>(ruleForm.listCurrentPremises),
                        listConclusion = new List<Fact>(ruleForm.listCurrentConclusions),
                        Truth = ruleForm.RuleTruth
                    };

                    dataBaseRC.AddRule(newRule);
                    rulesList.Add(newRule);
                }
            }
        }

        // Кнопка - РЕДАКТИРОВАТЬ ПРАВИЛО
        private void btnEditRules_Click(object sender, EventArgs e)
        {
            if (dataGridRules.SelectedRows.Count == 0 || dataGridRules.CurrentRow.DataBoundItem is not Rule selectedRule)
            {
                MessageBox.Show("Пожалуйста, выберите правило для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var objects = dataBaseRC.dictionaryFacts.Values.Select(f => f.Group).Distinct().ToList();
            var units = dataBaseRC.dictionaryFacts.Values.Select(f => f.Unit).Distinct().ToList();
            var attributes = dataBaseRC.dictionaryFacts.Values.Select(f => f.Atribute).Distinct().ToList();
            var values = dataBaseRC.dictionaryFacts.Values.Select(f => f.Value).Distinct().ToList();

            using (var editForm = new RuleForm())
            {
                editForm.InitializeData(dataBaseRC); // передаем базу в форму

                editForm.LoadSuggestionsForRules(objects, units, attributes, values);
                editForm.LoadRuleData(selectedRule); // Загружаем данные в форму для редактирования

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // 1. Обновляем простые поля
                    selectedRule.Description = editForm.RuleDescription;
                    selectedRule.Truth = editForm.RuleTruth;

                    // 2. ОБНОВЛЯЕМ СПИСКИ ОБЪЕКТОВ (Вместо strPremise и strConclusion)
                    // Мы очищаем текущие списки правила и копируем в них то, что насобирали в форме
                    selectedRule.listPremise.Clear();
                    selectedRule.listPremise.AddRange(editForm.listCurrentPremises);

                    selectedRule.listConclusion.Clear();
                    selectedRule.listConclusion.AddRange(editForm.listCurrentConclusions);

                    // Обновляем UI
                    rulesList.ResetBindings(); 
                }
            }
        }

        // Кнопка - УДАЛИТЬ ПРАВИЛО
        private void btnDeleteRules_Click(object sender, EventArgs e)
        {
            if (dataGridRules.SelectedRows.Count > 0)
            {
                // Вместо CurrentRow используем первую выбранную строку из коллекции SelectedRows
                DataGridViewRow selectedRow = dataGridRules.SelectedRows[0];

                // Получаем объект Rule, привязанный к этой строке
                Rule ruleToRemove = selectedRow.DataBoundItem as Rule;

                if (ruleToRemove != null)
                {
                    // Удаляем правило из базовой базы данных (словаря dictionaryRules) по его ID
                    dataBaseRC.dictionaryRules.Remove(ruleToRemove.Id);

                    // Удаляем правило из привязанного списка. BindingList обновит UI автоматически.
                    rulesList.Remove(ruleToRemove);
                }
            }
        }
    }
}
