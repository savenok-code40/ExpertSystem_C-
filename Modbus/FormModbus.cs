using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using EasyModbus;

namespace ExpertBase_v1
{
    public partial class FormModbus : Form
    {
        private ModbusConnect modbusConnect;
        public FormModbus()
        {
            InitializeComponent();
            InitializeDataGridView();
            txtIpAddress.Text = "192.168.30.110";
            numPort.Value = 502;
        }

        private void InitializeDataGridView()
        {
            // Убедитесь, что AutoGenerateColumns выключен, если вы добавляете их вручную
            dataGridReg.AutoGenerateColumns = false;

            // Добавляем три столбца: Адрес, Alias, Значение
            dataGridReg.Columns.Add("AddressColumn", "Адрес");
            dataGridReg.Columns.Add("AliasColumn", "Alias");
            dataGridReg.Columns.Add("ValueColumn", "Значение");

            // Опционально: настраиваем ширину столбцов
            dataGridReg.Columns["AddressColumn"].Width = 80;
            dataGridReg.Columns["ValueColumn"].Width = 100;
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            string ip = txtIpAddress.Text;
            int port = (int)numPort.Value;

            // Инициализируем наш класс-обертку
            modbusConnect = new ModbusConnect(ip, port);

            if (modbusConnect.Connect())
            {
                MessageBox.Show("Подключение к ПЛК успешно!");
                // Как на скриншоте: читаем 10 регистров, начиная с адреса 0, функцией FC03
                DisplayRegisters(0, 10);
            }
            else
            {
                MessageBox.Show("Не удалось подключиться к ПЛК.");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (modbusConnect != null)
            {
                modbusConnect.Disconnect();
                MessageBox.Show("Отключено.");
            }
        }

        private void DisplayRegisters(int startingAddress, int quantity)
        {
            try
            {
                // Используем метод ReadHoldingRegisters (FC03) нашего класса
                int[] registers = modbusConnect.ReadHoldingRegisters(startingAddress, quantity);

                // Очищаем и заполняем таблицу (dataGridRegisters)
                dataGridReg.Rows.Clear();
                for (int i = 0; i < registers.Length; i++)
                {
                    // Добавляем строку: Адрес (00000+i), Alias (пусто), Значение (из ПЛК)
                    dataGridReg.Rows.Add(startingAddress + i, "", registers[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка чтения данных FC03: {ex.Message}");
            }
        }
    }
}
