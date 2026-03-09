using AppModbus;
using ExpertBase.InferenceEngine;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExpertBase
{
    public partial class MainForm : Form
    {
        private DataBase dataBase = new DataBase(); // единый экземпляр базы данных         

        // Конструктор класса
        public MainForm()
        {
            InitializeComponent();

            // Контролы получают ссылки на актуальную базу
            factsControl1.InitializeDatabase(dataBase); 
            rulesControl1.InitializeData(dataBase); 
            inferenceControl1.InitializeDataBase(dataBase); 
            recommendControl1.InitializeData(dataBase); 
        }

        // Обработчик пункта меню Загрузить
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                openDialog.DefaultExt = "json";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    // Загружаем данные в общую базу данных
                    dataBase.LoadBase(openDialog.FileName);

                    // Обновляем таблицу фактов в FactsControl
                    factsControl1.RefreshDataBinding();

                    // Обновляем таблицу правил в FactsControl
                    rulesControl1.RefreshDataBinding();

                    // Обновляем InfernceControl
                    inferenceControl1.UpdateFacts(dataBase.dictionaryFacts);

                    // Обновляем таблицу рекомендаций
                    recommendControl1.RefreshDataBinding();

                    MessageBox.Show("База данных успешно загружена.");
                }
            }
        }

        // Обработчик пункта меню Сохранить (остается без изменений, т.к. не использует factsControl1)
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                saveDialog.DefaultExt = "json";
                saveDialog.FileName = "ventil_base.json";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    dataBase.SaveBase(saveDialog.FileName);

                    MessageBox.Show("База данных успешно сохранена.");
                }
            }
        }

        // Обработчик пункта меню - Modbus
        private void modbusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModbus modbusForm = new FormModbus(); // создаем форму модбас

            modbusForm.ShowDialog(); // отображаем форму как диалог
        }

        // Обработчик события перехода на вкладку Работа - обновляет базу 
        private void tabControl_General_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Если выбрали вкладку "Работа" 
            if (tabControl_General.SelectedTab == tabPage2_Work)
            {
                inferenceControl1.RefreshData(); // обновляем базу знаний в ней
            }
        }

        // Обновляем все таблица при правке фактов
        public void RefreshAllGrids()
        {
            // Проверяем на null, чтобы программа не упала при старте
            factsControl1.RefreshDataBinding();
            rulesControl1.RefreshDataBinding();
            recommendControl1.RefreshDataBinding();
            inferenceControl1.RefreshData();
        }
    }
}
