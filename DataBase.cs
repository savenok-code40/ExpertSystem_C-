using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace ExpertBase_v1
{
    public class DataBase
    {
        // Статические счетчики для генерации уникальных ID фактов и правил
        private static int nextFactId = 1; 
        private static int nextRuleId = 1; 

        // Словари для хранения фактов и правил
        public Dictionary<int, Fact> dictionaryFacts { get; set; } = new Dictionary<int, Fact>();
        public Dictionary<int, Rule> dictionaryRules { get; set; } = new Dictionary<int, Rule>();

        // Метод добавления факта (присваивает ID)
        public void AddFact(Fact newFact)
        {
            newFact.ID = nextFactId++;
            dictionaryFacts.Add(newFact.ID, newFact);
        }

        // Метод добавления правила (присваивает ID)
        public void AddRule(Rule newRule)
        {            
            newRule.Id = nextRuleId++;
            dictionaryRules.Add(newRule.Id, newRule);
        }

        // Метод для сохранения базы данных в файл JSON
        public void SaveBase(string filePath)
        {
            // Создается экземпляр класса JsonSerializerOptions
            // WriteIndented = true означает, что итоговый файл JSON будет "красиво" отформатирован с отступами и переносами строк            
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic) // Добавляем кодировщик для кириллицы
            };

            // используется статический класс JsonSerializer
            // берет ваш список factsToSave и преобразует его в одну длинную строку
            // формата JSON, применяя при этом созданные ранее options
            string jsonString = JsonSerializer.Serialize(this, options); // Полученная строка сохраняется в jsonString

            // Используется статический класс File из пространства имен Group.IO
            // Метод WriteAllText записывает всю строку jsonString в файл, указанный в параметре filePath
            File.WriteAllText(filePath, jsonString);
        }

        // Метод для загрузки базы данных из файла JSON
        public void LoadBase(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);

                // Десериализуем данные обратно в новый временный экземпляр DataBase
                var deserializeBase = JsonSerializer.Deserialize<DataBase>(jsonString);

                // Копируем загруженные данные в текущий рабочий экземпляр DataBase
                dictionaryFacts = deserializeBase.dictionaryFacts;
                dictionaryRules = deserializeBase.dictionaryRules;

                // если в словаре больше 0 элементов, то ищем max индекс и счетчик устанавливаем на max+1, иначе 1
                nextFactId = dictionaryFacts.Count > 0 ? dictionaryFacts.Keys.Max() + 1 : 1; 
                nextRuleId = dictionaryRules.Count > 0 ? dictionaryRules.Keys.Max() + 1 : 1;             
            }
        }
    }        
}
