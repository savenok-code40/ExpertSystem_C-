using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using EasyModbus;

namespace ExpertBase_v1
{
    public class ModbusDataManager
    {
        private readonly DataBase dataBaseMD;
        private readonly ModbusConnect modbusConnect;

        public ModbusDataManager(DataBase dataBase, string ipAddress)
        {
            dataBaseMD = dataBase;
            modbusConnect = new ModbusConnect(ipAddress);
        }

        // 
        public void Disconnect()
        {
            modbusConnect.Disconnect();
        }

        // Основной метод, который можно вызывать периодически
        public void UpdateAllDynamicFacts()
        {
            if (!modbusConnect.Connect())
            {
                return; // Если не подключились, выходим
            }

            // Используем lock для безопасного доступа к dictionaryFacts, если опрос идет в отдельном потоке
            lock (dataBaseMD.dictionaryFacts)
            {
                var factsToUpdate = dataBaseMD.dictionaryFacts.Values
                                         .Where(f => f.Type == Fact.enTypeFact.Dinamic_IN &&
                                                     f.RegAddr >= 0);

                foreach (var fact in factsToUpdate)
                {
                    UpdateSingleFact(fact);
                }
            }
            modbusConnect.Disconnect();
        }

        private void UpdateSingleFact(Fact fact)
        {
            object rawValue = null;

            switch (fact.FunModbus)
            {
                case Fact.enFunModbus.ReadDO_01Fun:
                    bool[] coils = modbusConnect.ReadCoilStatus(fact.RegAddr, 1);
                    if (coils != null && coils.Length > 0) rawValue = coils[0]; // Берем первый элемент
                    break;

                case Fact.enFunModbus.ReadDI_02Fun:
                    bool[] inputs = modbusConnect.ReadInputStatus(fact.RegAddr, 1);
                    if (inputs != null && inputs.Length > 0) rawValue = inputs[0];
                    break;

                case Fact.enFunModbus.ReadAO_03Fun:
                    int[] holdingRegs = modbusConnect.ReadHoldingRegisters(fact.RegAddr, 1);
                    if (holdingRegs != null && holdingRegs.Length > 0) rawValue = holdingRegs[0];
                    break;

                case Fact.enFunModbus.ReadAI_04Fun:
                    int[] inputRegs = modbusConnect.ReadInputRegisters(fact.RegAddr, 1);
                    if (inputRegs != null && inputRegs.Length > 0) rawValue = inputRegs[0];
                    break;
            }

            if (rawValue != null)
            {
                // Обновляем строковое поле Value факта
                string newValue = rawValue.ToString();
                if (fact.Value != newValue)
                {
                    fact.Value = newValue;
                    fact.Truth = 1.0;
                    Console.WriteLine($"Факт {fact.ID} обновлен: Value='{fact.Value}'");
                }
            }
        }
    }
}
