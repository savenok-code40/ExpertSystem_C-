using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertBase
{
    public class Fact
    {
        // Перечисление типы фактов
        public enum enTypeFact{Static, Dinamic_IN, Internal, Dinamic_OUT}

        // Перечисление функции Modbus
        public enum enFunModbus{ReadDO_01Fun, ReadDI_02Fun, ReadAO_03Fun, ReadAI_04Fun}

        // Добавляем { get; set; }, чтобы DataGridView увидел свойства
        [DisplayName("ID")]
        public int ID { get; set; }

        [DisplayName("Объект (группа)")]
        public string Group { get; set; } = string.Empty;

        [DisplayName("Узел (подгруппа)")]
        public string Unit { get; set; } = string.Empty;

        [DisplayName("Атрибут (свойство)")]
        public string Atribute { get; set; } = string.Empty;

        [DisplayName("Значение")]
        public string Value { get; set; } = string.Empty;

        [DisplayName("Достоверность")]
        public double Truth { get; set; }

        [DisplayName("Тип факта")]
        public enTypeFact Type { get; set; }

        [DisplayName("Функция Modbus")]
        public enFunModbus FunModbus { get; set; }

        [DisplayName("Адрес регистра")]
        public int RegAddr { get; set; } = -1;

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
            return $"{Group}.{Unit}.{Atribute}.{Value}";
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
