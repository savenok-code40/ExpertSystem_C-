using System.ComponentModel;

namespace ExpertBase_v1
{
    public partial class MainForm : Form
    {
        private DataBase dataBase = new DataBase(); // единый экземпляр базы данных 
        private ModbusPollingService modbusPollingService;

        // Конструктор класса
        public MainForm()
        {
            InitializeComponent();            

            factsControl1.InitializeDatabase(dataBase); // инициализирует экземпляр DataBase в FactsControl
            rulesControl1.InitializeData(dataBase); // Инициализация RulesControl

            InitializeModbusService();
            modbusPollingService.StartPolling();
        }

        private void InitializeModbusService()
        {
            modbusPollingService = new ModbusPollingService(dataBase);
            // Подписываемся на событие обновления данных, чтобы обновить UI
            modbusPollingService.DataUpdated += PollingService_DataUpdated;
        }

        // Обработчик обновления UI (вызывается сервисом Modbus)
        private void PollingService_DataUpdated(object sender, EventArgs e)
        {
            // Обновляем привязку данных на экране пользователя
            //factsControl1.RefreshDataBinding();
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
            // При открытии формы настроек можно временно остановить фоновый опрос
            modbusPollingService.StopPolling();
            FormModbus settingsForm = new FormModbus();
            settingsForm.ShowDialog();
            modbusPollingService.StartPolling(); // Возобновляем опрос после закрытия формы
        }
    }
}
