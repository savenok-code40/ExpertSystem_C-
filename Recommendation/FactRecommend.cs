using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ExpertBase
{
    public class FactRecommend
    {
        [DisplayName("Название")] // Это будет видно в таблице
        public string Name { get; set; } = string.Empty;

        [Browsable(false)]
        public Fact TargetFact { get; set; } = new Fact();

        [DisplayName("Рекомендация")]
        public string AdviceText { get; set; } = string.Empty;

        [DisplayName("Приоритет")]
        public int Priority { get; set; }

        [DisplayName("Связанный факт")]
        public string TargetFactDisplay => TargetFact?.ToString() ?? "Не выбран";

        public FactRecommend() { }

        // Обновленный конструктор
        public FactRecommend(Fact targetFact, string name, string adviceText, int priority)
        {
            TargetFact = targetFact;
            Name = name;
            AdviceText = adviceText;
            Priority = priority;
        }
    }
}
