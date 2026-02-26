using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertBase
{
    public class ForwardChain
    {
        private DataBase db; // поле для хранения базы знаний
        public ForwardChain(DataBase dataBase)
        {
            this.db = dataBase;
        }

        // Метода проверки заданной цели в прямом выводе
        public void ComputeForwardChain(List<Fact> factsInMemory, Fact targetFact, StringBuilder sb)
        {
            int i = 1; // счетчик итераций прямого ввывода
            bool achievedTarget = false; // флаг достижения цели
            var copyRules = new Dictionary<int, Rule>(db.dictionaryRules); // копия правил из базы знаний

            sb.AppendLine("--- Начало прямого вывода ---");

            if (!achievedTarget && copyRules.Count > 0)
            {
                sb.AppendLine($"\n--- Итерация №{i} ---\n");
                sb.AppendLine("Факты в памяти:");

                foreach (Fact f in factsInMemory)
                {
                    sb.AppendLine($" {f.ToString()}");
                }

                // конфликтный набор
                var conflictSet = (from rule in copyRules.Values
                                   where rule.listPremise.All(factInPremise => factsInMemory.Contains(factInPremise))
                                   select rule).ToList();

                if (conflictSet.Count == 0)
                {
                    sb.AppendLine("Конфликтный набор пуст");
                    //break;
                }

                sb.AppendLine($"  Конфликтный набор: {conflictSet.Count} правил");

            }



            sb.AppendLine("\n--- Поиск завершен ---\n");

            if (achievedTarget)
            {
                sb.AppendLine($"Цель - {targetFact.ToString()} - ** достигнута !** Достоверность: {targetFact.Truth:F2}");
            }
            else
            {
                sb.AppendLine($"Цель - {targetFact.ToString()} - не достигнута");
            }
        }

    }
}
