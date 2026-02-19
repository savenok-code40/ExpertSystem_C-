using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpertBase
{
    public static class RuleParser
    {
        // Находит факт в словаре по полному пути: "Объект.Узел.Атрибут.Значение"
        public static Fact? GetFactByPath(string path, IEnumerable<Fact> memory)
        {
            string cleanPath = path.Trim();
            return memory.FirstOrDefault(f =>
                $"{f.Group}.{f.Unit}.{f.Atribute}.{f.Value}" == cleanPath);
        }

        // Разделяет строку по оператору "И" (&&)
        public static List<string> SplitByAnd(string condition)
        {
            if (string.IsNullOrWhiteSpace(condition)) return new List<string>();
            return condition.Split(new[] { "&&" }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(p => p.Trim()).ToList();
        }

        // Проверяет наличие оператора "НЕ" (!) и возвращает чистый путь
        public static bool IsInverted(string condition, out string cleanPath)
        {
            string trimmed = condition.Trim();
            if (trimmed.StartsWith("!"))
            {
                cleanPath = trimmed.Substring(1).Trim();
                return true;
            }
            cleanPath = trimmed;
            return false;
        }

        // Пытается получить числовое значение из факта. Если в Value не число, возвращает 0
        public static double GetDoubleValue(Fact fact)
        {
            if (double.TryParse(fact.Value, out double result))
                return result;
            return 0;
        }

        // Проверяет, является ли значение факта истинным (true)
        public static bool IsTrue(Fact fact)
        {
            return fact.Value.Trim().Equals("true", StringComparison.OrdinalIgnoreCase);
        }

        // Регулярное выражение для поиска операторов сравнения
        private static readonly Regex ComparisonRegex = new Regex(@"^(?<left>.+?)\s*(>=|<=|==|!=|>|<)\s*(?<right>.+)$");


        // Разбирает строку условия на левую часть, оператор и правую часть.
        public static bool TryParseComparison(string condition, out string left, out string op, out string right)
        {
            var match = ComparisonRegex.Match(condition.Trim());
            if (match.Success)
            {
                left = match.Groups["left"].Value.Trim();
                op = match.Groups["op"].Value;
                right = match.Groups["right"].Value.Trim();
                return true;
            }

            left = op = right = string.Empty;
            return false;
        }

        // Сравнивает два факта по их путям
        public static bool CompareFacts(string leftPath, string op, string rightPath, IEnumerable<Fact> memory)
        {
            var leftFact = GetFactByPath(leftPath, memory);
            var rightFact = GetFactByPath(rightPath, memory);

            if (leftFact == null || rightFact == null) return false;

            double leftVal = GetDoubleValue(leftFact);
            double rightVal = GetDoubleValue(rightFact);

            return op switch
            {
                ">" => leftVal > rightVal,
                "<" => leftVal < rightVal,
                _ => false
            };
        }
    }
}
