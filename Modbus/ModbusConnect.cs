using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
using System.IO.Ports;

namespace ExpertBase_v1
{
    public class ModbusConnect
    {
        // Используем приватное поле типа ModbusClient из библиотеки EasyModbus
        private ModbusClient modbusClient;

        public ModbusConnect(string ipAddress, int port = 502)
        {
            // Создаем экземпляр внешнего класса EasyModbus.ModbusClient
            modbusClient = new ModbusClient(ipAddress, port);
            modbusClient.ConnectionTimeout = 1500; // Установка таймаута
        }

        public bool Connect()
        {
            try
            {
                if (!modbusClient.Connected)
                {
                    modbusClient.Connect();
                    Console.WriteLine($"Подключение к {modbusClient.IPAddress}:{modbusClient.Port} успешно.");
                }
                return modbusClient.Connected;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка подключения к Modbus: {e.Message}");
                return false;
            }
        }

        public void Disconnect()
        {
            if (modbusClient.Connected)
            {
                modbusClient.Disconnect();
                Console.WriteLine("Отключение от Modbus.");
            }
        }

        // FC 01: Read Coil Status
        public bool[] ReadCoilStatus(int startingAddress, int quantity)
        {
            // Проверяем соединение перед выполнением операции
            if (!modbusClient.Connected) Connect();
            return modbusClient.ReadCoils(startingAddress, quantity);
        }

        // FC 02: Read Input Status
        public bool[] ReadInputStatus(int startingAddress, int quantity)
        {
            // Проверяем соединение перед выполнением операции
            if (!modbusClient.Connected) Connect();
            return modbusClient.ReadDiscreteInputs(startingAddress, quantity);
        }

        // FC 03: Read Holding Registers
        public int[] ReadHoldingRegisters(int startingAddress, int quantity)
        {
            // Проверяем соединение перед выполнением операции
            if (!modbusClient.Connected) Connect();
            return modbusClient.ReadHoldingRegisters(startingAddress, quantity);
        }

        // FC 04: Read Input Registers
        public int[] ReadInputRegisters(int startingAddress, int quantity)
        {
            // Проверяем соединение перед выполнением операции
            if (!modbusClient.Connected) Connect();
            return modbusClient.ReadInputRegisters(startingAddress, quantity);
        }
    }
}
