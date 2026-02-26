using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertBase
{
    public class Rule
    {
        // списки для логики
        public List<Fact> listPremise { get; set; } = new List<Fact>();
        public List<Fact> listConclusion { get; set; } = new List<Fact>();

        //свойства для UI
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Описание правила")]
        public string Description { get; set; } = string.Empty;

        // Посылка
        [DisplayName("Посылка")]
        public string strPremise => string.Join(" && ", listPremise.Select(f => f.ToString()));

        // Заключение
        [DisplayName("Заключение")]
        public string strConclusion => string.Join(" && ", listConclusion.Select(f => f.ToString()));

        // Достоверность от 0.0 до 1.0
        [DisplayName("Достоверность")]
        public double Truth { get; set; } = 1.0;

        // Конструктор ничего не принимает. Нужен JSON сериализации/десериализации 
        public Rule() { }

        // Конструктор принимает аргументы
        public Rule(int id, string description, List<Fact> listPremise, List<Fact> listConclusion, double truth)
        {
            Id = id;
            Description = description; // название правила
            this.listPremise = listPremise ?? new List<Fact>(); // посылка
            this.listConclusion = listConclusion ?? new List<Fact>(); // заключение
            Truth = truth; // достоверность
        }

        public override string ToString()
        {
            return $"{Description} : IF {strPremise} THEN {strConclusion} (Дост.: {Truth}):";
        }
    }
}
