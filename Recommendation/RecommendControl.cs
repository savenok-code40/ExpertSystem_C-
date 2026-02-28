using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExpertBase
{
    public partial class RecommendControl : UserControl
    {
        private DataBase dataBaseRC; // Поле класса
        private BindingList<FactRecommend> recommendsList; // Поле класса

        public RecommendControl()
        {
            InitializeComponent();
        }

        public void InitializeData(DataBase db)
        {
            dataBaseRC = db;
            SetupDataGrid();
        }

        private void SetupDataGrid()
        {
            recommendsList = new BindingList<FactRecommend>(dataBaseRC.listRecommendations);
            dataGridRecommend.DataSource = recommendsList;

            if (dataGridRecommend.Columns["TargetFact"] != null)
                dataGridRecommend.Columns["TargetFact"].Visible = false;
        }

        public void RefreshDataBinding()
        {
            // Исправлено: имена полей класса
            if (dataBaseRC != null && recommendsList != null)
            {
                recommendsList.Clear();
                foreach (var rec in dataBaseRC.listRecommendations)
                {
                    recommendsList.Add(rec);
                }
            }
        }

        private void btnAddRecommend_Click_1(object sender, EventArgs e)
        {
            // Списки для автозаполнения
            var objects = dataBaseRC.dictionaryFacts.Values.Select(f => f.Group).Distinct().ToList();
            var units = dataBaseRC.dictionaryFacts.Values.Select(f => f.Unit).Distinct().ToList();
            var attributes = dataBaseRC.dictionaryFacts.Values.Select(f => f.Atribute).Distinct().ToList();
            var values = dataBaseRC.dictionaryFacts.Values.Select(f => f.Value).Distinct().ToList();

            using (var recForm = new RecommendForm())
            {
                recForm.InitializeData(dataBaseRC);
                recForm.LoadSuggestionsForRules(objects, units, attributes, values);

                if (recForm.ShowDialog() == DialogResult.OK)
                {
                    var newRec = recForm.CreateRecommendation();
                    dataBaseRC.listRecommendations.Add(newRec);
                    recommendsList.Add(newRec);
                }
            }
        }

        private void btnEditRecommend_Click(object sender, EventArgs e)
        {
            if (dataGridRecommend.CurrentRow?.DataBoundItem is not FactRecommend selectedRec)
            {
                MessageBox.Show("Выберите рекомендацию для редактирования.");
                return;
            }

            // Исправлено: получение списков внутри метода редактирования
            var objects = dataBaseRC.dictionaryFacts.Values.Select(f => f.Group).Distinct().ToList();
            var units = dataBaseRC.dictionaryFacts.Values.Select(f => f.Unit).Distinct().ToList();
            var attributes = dataBaseRC.dictionaryFacts.Values.Select(f => f.Atribute).Distinct().ToList();
            var values = dataBaseRC.dictionaryFacts.Values.Select(f => f.Value).Distinct().ToList();

            using (var editForm = new RecommendForm())
            {
                editForm.InitializeData(dataBaseRC); // Исправлено: dataBaseRC
                editForm.LoadSuggestionsForRules(objects, units, attributes, values);
                editForm.LoadRecommendData(selectedRec); // Убедитесь, что метод в RecommendForm есть

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    var updated = editForm.CreateRecommendation();

                    selectedRec.TargetFact = updated.TargetFact;
                    selectedRec.AdviceText = updated.AdviceText;
                    selectedRec.Priority = updated.Priority;

                    recommendsList.ResetBindings(); // Исправлено: recommendsList
                }
            }
        }

        private void btnDeleteRecommend_Click(object sender, EventArgs e)
        {
            if (dataGridRecommend.SelectedRows.Count > 0)
            {
                var recToRemove = dataGridRecommend.SelectedRows[0].DataBoundItem as FactRecommend;

                if (recToRemove != null)
                {
                    dataBaseRC.listRecommendations.Remove(recToRemove);
                    recommendsList.Remove(recToRemove);
                }
            }
        }
    }
}

