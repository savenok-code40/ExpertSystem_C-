using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExpertBase_v1
{
    public class ModbusPollingService
    {
        private readonly DataBase dataBaseMPS;
        private readonly ModbusDataManager modbusData;
        private readonly System.Windows.Forms.Timer modbusTimer;
        private const string PlcIpAddress = "192.168.30.110";

        // Событие, которое можно вызвать, когда данные обновлены (для обновления UI)
        public event EventHandler DataUpdated;

        public ModbusPollingService(DataBase dataBase)
        {
            dataBaseMPS = dataBase;
            modbusData = new ModbusDataManager(dataBaseMPS, PlcIpAddress);

            modbusTimer = new System.Windows.Forms.Timer();
            modbusTimer.Interval = 1000; // 1 секунда
            modbusTimer.Tick += UpdateTimer_Tick;
        }

        public void StartPolling()
        {
            modbusTimer.Start();
            Console.WriteLine("Автоматический опрос Modbus запущен.");
        }

        public void StopPolling()
        {
            modbusTimer.Stop();
            Console.WriteLine("Автоматический опрос Modbus остановлен.");
            modbusData.Disconnect(); // Отключаемся при остановке опроса
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            // Выполняем опрос и обновление фактов
            modbusData.UpdateAllDynamicFacts();

            // Уведомляем подписчиков (например, MainForm), что данные обновились
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
