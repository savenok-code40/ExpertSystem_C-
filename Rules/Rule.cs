using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertBase_v1
{
    public class Rule
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Описание правила")]
        public string Description { get; set; }

        // Посылка
        [DisplayName("Посылка")]
        public string Condition { get; set; }

        // Заключение
        [DisplayName("Заключение")]
        public string Consequence { get; set; }

        // Достоверность от 0.0 до 1.0
        [DisplayName("Достоверность")]
        public double Truth { get; set; } = 1.0;

        // Конструктор ничего не принимает
        public Rule()
        {
            Description = string.Empty;
            Condition = string.Empty;
            Consequence = string.Empty;
        }

        // Конструктор принимает аргументы
        public Rule(int id, string description, string condition, string consequence, double truth)
        {
            //Id = id;
            Description = description; // название правила
            Condition = condition; // посылка
            Consequence = consequence; // заключение
            Truth = truth; // достоверность
        }

        public override string ToString()
        {
            return $"{Description} : IF {Condition} THEN {Consequence} (Дост.: {Truth}):";
        }
    }
}
