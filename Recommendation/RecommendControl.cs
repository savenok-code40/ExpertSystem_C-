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
        private DataBase dataBaseThis; // Поле класса
        private BindingList<FactRecommend> recommendsList; // Поле класса

        public RecommendControl()
        {
            InitializeComponent();
        }

        public void InitializeData(DataBase db)
        {
            dataBaseThis = db;
            SetupDataGrid();
        }

        private void SetupDataGrid()
        {
            recommendsList = new BindingList<FactRecommend>(dataBaseThis.listRecommendations);
            dataGridRecommend.DataSource = recommendsList;

            // Настраиваем колонку с текстом факта (FactDisplay)
            if (dataGridRecommend.Columns["FactDisplay"] != null)
            {   
                dataGridRecommend.Columns["FactDisplay"].DisplayIndex = 0; // Ставим первой
                dataGridRecommend.Columns["FactDisplay"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        public void RefreshDataBinding()
        {
            // Исправлено: имена полей класса
            if (dataBaseThis != null && recommendsList != null)
            {
                recommendsList.Clear();
                foreach (var rec in dataBaseThis.listRecommendations)
                {
                    recommendsList.Add(rec);
                }

                recommendsList.ResetBindings(); // сообщаем UI, что список полностью изменился
            }
        }

        private void btnAddRecommend_Click_1(object sender, EventArgs e)
        {
            // Списки для автозаполнения
            var objects = dataBaseThis.dictionaryFacts.Values.Select(f => f.Group).Distinct().ToList();
            var units = dataBaseThis.dictionaryFacts.Values.Select(f => f.Unit).Distinct().ToList();
            var attributes = dataBaseThis.dictionaryFacts.Values.Select(f => f.Atribute).Distinct().ToList();
            var values = dataBaseThis.dictionaryFacts.Values.Select(f => f.Value).Distinct().ToList();
                       
            using (var recForm = new RecommendForm()) // Создаем новый объект в памяти - пустую форму
            {
                recForm.InitializeData(dataBaseThis);
                recForm.AutoCompleteFact(objects, units, attributes, values); // передаем факты из базы

                // здесь программа замирает, пока не нажата Сохранить или Закрыть
                if (recForm.ShowDialog() == DialogResult.OK) // если нажата Сохранить или Закрыть
                {
                    var newRec = recForm.CreateRecommendation(); // просим собрать из своих тестБоксов новый объект
                    dataBaseThis.listRecommendations.Add(newRec); // кладем в базу 
                    recommendsList.Add(newRec); // кладем в BindingList, чтобы появился на экране
                }
            }
        }

        private void btnEditRecommend_Click(object sender, EventArgs e)
        {
            // берем из таблицы объект, на котором стоит курсор
            if (dataGridRecommend.CurrentRow?.DataBoundItem is not FactRecommend selectedRec)
            {
                MessageBox.Show("Выберите рекомендацию для редактирования.");
                return;
            }

            // Исправлено: получение списков внутри метода редактирования
            var objects = dataBaseThis.dictionaryFacts.Values.Select(f => f.Group).Distinct().ToList();
            var units = dataBaseThis.dictionaryFacts.Values.Select(f => f.Unit).Distinct().ToList();
            var attributes = dataBaseThis.dictionaryFacts.Values.Select(f => f.Atribute).Distinct().ToList();
            var values = dataBaseThis.dictionaryFacts.Values.Select(f => f.Value).Distinct().ToList();

            using (var editForm = new RecommendForm())
            {
                editForm.InitializeData(dataBaseThis); // 
                editForm.AutoCompleteFact(objects, units, attributes, values);
                editForm.LoadRecommendData(selectedRec); // копируем данные из объекта, который редактируем в текстовые поля

                if (editForm.ShowDialog() == DialogResult.OK) // когда нажата Ок
                {
                    var updated = editForm.CreateRecommendation(); // создаем временный объект

                    // переносим данные из него в selectedRec
                    selectedRec.TargetFact = updated.TargetFact;
                    selectedRec.AdviceText = updated.AdviceText;
                    selectedRec.Priority = updated.Priority;

                    recommendsList.ResetBindings(); // Таблице говорим перерисовать объекты
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
                    dataBaseThis.listRecommendations.Remove(recToRemove); // удаляем из базы
                    recommendsList.Remove(recToRemove); // кдаляем с экрана
                }
            }
        }
    }
}

