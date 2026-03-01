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
        // Скрываем сам объект, так как он не может быть отрисован в ячейке адекватно
        [Browsable(false)] // атрибут нужен , чтобы в датаГрид не создал колонку
        public Fact TargetFact { get; set; } = new Fact();

        [DisplayName("Рекомендация")]
        public string AdviceText { get; set; } = string.Empty;

        [DisplayName("Приоритет")]
        public int Priority { get; set; }

        [DisplayName("Связанный факт")]  // Это свойство "вытягивает" актуальную строку из объекта Fact
        public string TargetFactDisplay => TargetFact?.ToString() ?? "Не выбран";

        public FactRecommend() { }

        public FactRecommend(Fact targetFact, string adviceText, int priority)
        {
            TargetFact = targetFact;
            AdviceText = adviceText;
            Priority = priority;
        }
    }
}
