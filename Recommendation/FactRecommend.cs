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
        // Ссылка на объект-клон факта из вашей базы
        public Fact TargetFact { get; set; } = new Fact();  

        public string AdviceText { get; set; } = string.Empty;

        public int Priority { get; set; }

        // Пустой конструктор для JSON
        public FactRecommend() { }

        public FactRecommend(Fact targetFact, string adviceText, int priority)
        {
            // При создании рекомендации мы сохраняем ссылку на клон факта
            TargetFact = targetFact;
            AdviceText = adviceText;
            Priority = priority;
        }
    }
}
