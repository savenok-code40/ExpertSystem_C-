using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertBase
{
    public class Fact
    {
        // Перечисление типы фактов
        public enum enTypeFact
        {
            Static,
            Dinamic_IN,
            Internal,
            Dinamic_OUT
        }
        // Перечисление функции Modbus
        public enum enFunModbus
        {
            ReadDO_01Fun,
            ReadDI_02Fun,
            ReadAO_03Fun,
            ReadAI_04Fun
        }

        // Добавляем { get; set; }, чтобы DataGridView "увидел" эти данные
        public int ID { get; set; }        
        public string Group { get; set; }
        public string Unit { get; set; }
        public string Atribute { get; set; }
        public string Value { get; set; }
        public double Truth { get; set; }
        public enTypeFact Type { get; set; }
        public enFunModbus FunModbus { get; set; } // Тип данных Enum
        public int RegAddr { get; set; } = -1; // адрес регистра модбас        

        // Конструктор класса
        public Fact() // Требуется для десериализации System.Text.Json
        {
            // инициализируем пустыми значениями, чтобы не ругался на null
            Group = string.Empty;
            Unit = string.Empty;
            Atribute = string.Empty;
            Value = string.Empty;
        } 
        public Fact(string group, string unit, string attribute,
            string value, double truth, enTypeFact type, enFunModbus fun, int reg)
        {
            Group = group;
            Unit = unit;
            Atribute = attribute;
            Value = value;
            Truth = truth;
            Type = type;
            RegAddr = reg;
            FunModbus = fun;
        }

        // переопределяем метод ToString - вывод объекта типа Факт
        public override string ToString()
        {            
            return $"{Group}.{Unit}.{Atribute}.{Value}"; // .{Value}.{Type}
        }

        // переопределяем метод Equals - сравнения объектов типа Факт
        public override bool Equals(object? obj)
        {
            if (obj is Fact other)
            {
                // сравниваем факты по трем полям
                return Group == other.Group &&
                    Unit == other.Unit &&
                    Atribute == other.Atribute &&
                    Value == other.Value; 
            }
            return false;
        }

        //  
        public override int GetHashCode()
        {
            return HashCode.Combine(Group, Unit, Atribute, Value);
        }    
    }
}
