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
