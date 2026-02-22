using System.ComponentModel;
using AppModbus;

namespace ExpertBase
{
    public partial class MainForm : Form
    {
        private DataBase dataBase = new DataBase(); // единый экземпляр базы данных         

        // Конструктор класса
        public MainForm()
        {
            InitializeComponent();            

            factsControl1.InitializeDatabase(dataBase); // инициализирует экземпляр DataBase в FactsControl
            rulesControl1.InitializeData(dataBase); // Инициализация RulesControl 
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

        private void modbusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModbus modbusForm = new FormModbus(); // создаем форму модбас

            modbusForm.ShowDialog(); // отображаем форму как диалог
        }
    }
}
