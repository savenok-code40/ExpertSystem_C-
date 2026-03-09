using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel; // Нужно для INotifyPropertyChanged
using System.Runtime.CompilerServices;

namespace ExpertBase 
{
    public class Fact : INotifyPropertyChanged
    {
        // события
        public event PropertyChangedEventHandler? PropertyChanged;

        // Вспомогательный метод (Оповещатель изменений)
        protected void OnPropertyChanged(string propertyName)
        {
            // Если на событие кто-то подписан (PropertyChanged != null)
            if (PropertyChanged != null)
            {
                // Вызываем всех подписчиков и передаем им имя измененного свойства
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // Перечисление типы фактов
        public enum enTypeFact{Static, Dinamic_IN, Internal, Dinamic_OUT}

        // Перечисление функции Modbus
        public enum enFunModbus{ReadDO_01Fun, ReadDI_02Fun, ReadAO_03Fun, ReadAI_04Fun}

        private int _id;
        private string _group = string.Empty;
        private string _unit = string.Empty;
        private string _attribute = string.Empty;
        private string _value = string.Empty;
        private double _truth = 1;
        private enTypeFact _type = enTypeFact.Dinamic_IN;
        private enFunModbus _funModbus = enFunModbus.ReadDI_02Fun;
        private int _regAddr;

        // Добавляем { get; set; }, чтобы DataGridView увидел свойства
        [DisplayName("ID")]
        public int ID 
        {
            get => _id;
            set { if (_id != value) { _id = value; OnPropertyChanged("ID"); } }
        }

        [DisplayName("Объект (группа)")]
        public string Group
        {
            get => _group;
            set
            {
                if (_group != value)
                { 
                    _group = value;
                    OnPropertyChanged("Group");
                } 
            }
        }

        [DisplayName("Узел (подгруппа)")]
        public string Unit
        {
            get => _unit;
            set { if (_unit != value) { _unit = value; OnPropertyChanged("Unit"); } }
        }

        [DisplayName("Атрибут (свойство)")]
        public string Atribute
        {
            get => _attribute;
            set { if (_attribute != value) { _attribute = value; OnPropertyChanged("Atribute"); } }
        }

        [DisplayName("Значение")]
        public string Value
        {
            get => _value;
            set { if (_value != value) { _value = value; OnPropertyChanged("Value"); } }
        }

        [DisplayName("Достоверность")]
        public double Truth
        {
            get => _truth;
            set
            { if (_truth != value)
                {
                    _truth = value;
                    OnPropertyChanged("Truth");
                }
            }
        }

        [DisplayName("Тип факта")]
        public enTypeFact Type
        {
            get => _type;
            set { if (_type != value) { _type = value; OnPropertyChanged("Type"); } }
        }

        [DisplayName("Функция Modbus")]
        public enFunModbus FunModbus
        {
            get => _funModbus;
            set { if ( _funModbus != value) { _funModbus = value; OnPropertyChanged("FunModbus"); } }
        }

        [DisplayName("Адрес регистра")]
        public int RegAddr
        {
            get => _regAddr;
            set { if (_regAddr != value) { _regAddr = value; OnPropertyChanged("RegAddr"); } }
        }

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
