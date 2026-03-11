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

        // Метода расчета прямого вывода
        public void ComputeForwardChain(List<Fact> factsInMemory, Fact targetFact, StringBuilder sb)
        {
            int i = 1; // счетчик итераций прямого ввывода
            bool achievedTarget = false; // флаг достижения цели
            var copyRules = new Dictionary<int, Rule>(db.dictionaryRules); // копия правил из базы знаний

            sb.AppendLine("--- Начало прямого вывода ---");

            while (!achievedTarget && copyRules.Count > 0)
            {
                sb.AppendLine($"\n--- Итерация №{i} ---\n");
                sb.AppendLine("Факты в памяти:");

                foreach (Fact f in factsInMemory)
                {
                    sb.AppendLine($" {f.ToString()}");
                }

                // 1. Формирование конфликтного набора
                var conflictSet = (from rule in copyRules.Values
                                   where rule.listPremise.All(factInPremise => factsInMemory.Contains(factInPremise))
                                   select rule).ToList();

                if (conflictSet.Count == 0)
                {
                    sb.AppendLine("Конфликтный набор пуст");
                    break;
                }

                sb.AppendLine($"  Конфликтный набор: {conflictSet.Count} правил");
                
                var SelectRuleMaxTruth = conflictSet.MaxBy(r => r.Truth); // выбор правила из конфликтного набора с max достоверностью

                if (SelectRuleMaxTruth != null)
                {
                    sb.AppendLine($" Сработало правило: {SelectRuleMaxTruth.Description}");

                    // 2. Расчет достоверности, сработавшего правила

                    // 3. Выполнение правила: добавление факта в память
                    foreach (Fact factInConclusion in SelectRuleMaxTruth.listConclusion)
                    {
                        // Проверяем, нет ли этого факта УЖЕ в рабочей памяти (используем Equals)
                        var existingInWorkMemory = factsInMemory.FirstOrDefault(f => f.Equals(factInConclusion)); // проверяем нет ли уже факта в памяти

                        if (existingInWorkMemory == null) // если факта нет
                        {  
                            factsInMemory.Add(factInConclusion);   

                            sb.AppendLine($"\n Добавлен новый факт: {factInConclusion.ToString()} ");

                            // Проверка достижения цели
                            if (factInConclusion.Equals(targetFact)) // если достигли
                            {
                                achievedTarget = true; // то взводим флаг достижения
                            }
                        }
                        else
                        {
                            sb.AppendLine($"\n Факт: {existingInWorkMemory.ToString()} уже был в памяти");
                        }
                    }

                    copyRules.Remove(SelectRuleMaxTruth.Id); // Удаляем сработавшее правило из копии правил ,чтобы не зациклиться
                    i++;
                }                
            } 

            sb.AppendLine("\n--- Поиск завершен ---\n");

            if (achievedTarget)
            {
                sb.AppendLine($"Цель - {targetFact.ToString()} - ** достигнута !** ");
            }
            else
            {
                sb.AppendLine($"Цель - {targetFact.ToString()} - не достигнута");
            }
        }
    }
}
