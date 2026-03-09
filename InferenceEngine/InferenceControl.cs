using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertBase.InferenceEngine
{
    public partial class InferenceControl : UserControl
    {
        private DataBase dataBaseThis; // получает (хранит) ссылку на базу знаний        

        public InferenceControl()
        {
            InitializeComponent();
        }

        // Метод получения базы знаний. Вызываю в коде главной формы
        public void InitializeDataBase(DataBase db)
        {
            this.dataBaseThis = db;
            UpdateFacts(db.dictionaryFacts); // сразу заполняем списки
        }

        // Кнопка запуска прямого вывода
        private void btnCheckTarget_Click(object sender, EventArgs e)
        {
            // 1. Проверка и подготовка данных        
            Fact targetFact = new Fact(); // цель
            List<Fact> factsInMemory = new List<Fact>(); // рабочая память
            StringBuilder sb = new StringBuilder(); // сообщения в рич бокс

            if (cmbChooseTarget.SelectedItem == null) // если не выбрана цель
            {
                MessageBox.Show("Пожалуйста, выберите целевой факт.");
                return;
            }
            else
            {
                targetFact = (Fact)cmbChooseTarget.SelectedItem;
                MessageBox.Show($"Проверяем цель: {targetFact.ToString()}");
            }

            DateTime startTime = DateTime.Now;
            ritchBoxOutputChain.Clear();

            foreach (object item in listBoxFactsWork.Items)
            {
                factsInMemory.Add((Fact)item);
            }

            // 2. Запуск прямого вывода
            ForwardChain forwardChain = new ForwardChain(dataBaseThis);
            forwardChain.ComputeForwardChain(factsInMemory, targetFact, sb);

            // 3. Поиск и вывод рекомендаций
            var relevantAdvices = dataBaseThis.listRecommendations
                .Where(rec => factsInMemory.Any(f => f.Equals(rec.TargetFact)))
                .ToList();

            this.DisplayRecommendations(relevantAdvices); // метод отрисовки советов

            // 4. Расчет времени выполнения и вывод сообщений в рич бокс
            DateTime endTime = DateTime.Now;
            TimeSpan timeSpan = endTime - startTime;

            ritchBoxOutputChain.AppendText(sb.ToString());
            ritchBoxOutputChain.AppendText("\n--- --- ---\n");
            ritchBoxOutputChain.AppendText($"Время выполнения: {timeSpan.TotalMilliseconds:F0} мс");
        }

        // метод обновляет списки в комбобоксах
        public void UpdateFacts(Dictionary<int, Fact> facts)
        {
            if (facts == null) return; // не выполняем метод если нет объекта

            // Обновляем комбо бокс
            cmbChooseTarget.Items.Clear(); // очищаем комбобокс

            foreach (Fact f in facts.Values)
            {
                if ((f.Type == Fact.enTypeFact.Dinamic_OUT) || (f.Type == Fact.enTypeFact.Static))
                {
                    cmbChooseTarget.Items.Add(f);
                }
            }

            if (cmbChooseTarget.Items.Count > 0)
            {
                cmbChooseTarget.SelectedIndex = 0;
            }

            this.AutoCompleteFacts(); // обновление comboBox 'ов
        }

        // Обратное действие - из рабочей памяти в список исходные
        private void listBoxFactsWork_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxFactsWork.SelectedIndex >= 0)
            {
                listBoxFactsWork.Items.Remove(listBoxFactsWork.Items[listBoxFactsWork.SelectedIndex]); // удалить из рабочей памяти
            }

        }

        public void DisplayRecommendations(List<FactRecommend> foundAdvices)
        {
            richBoxRecommend.Clear(); // Очищаем старые советы

            if (foundAdvices.Count == 0)
            {
                richBoxRecommend.SelectionColor = Color.Gray;
                richBoxRecommend.AppendText("Рекомендаций для текущего состояния нет.");
                return;
            }

            // Сортируем: сначала критические (5), потом остальные
            var sorted = foundAdvices.OrderByDescending(a => a.Priority).ToList();

            foreach (var adv in sorted)
            {
                // 1. Ставим время и заголовок
                richBoxRecommend.SelectionFont = new Font(richBoxRecommend.Font, FontStyle.Bold);

                // Красим заголовок в зависимости от приоритета
                richBoxRecommend.SelectionColor = adv.Priority switch
                {
                    5 => Color.Red,        // КРИТИЧНО
                    4 => Color.OrangeRed,  // ВАЖНО
                    3 => Color.DarkOrange, // ПРЕДУПРЕЖДЕНИЕ
                    _ => Color.Blue        // ИНФО
                };

                richBoxRecommend.AppendText($"[{DateTime.Now:HH:mm:ss}] ПРИОРИТЕТ {adv.Priority}:\n");

                // 2. Выводим текст рекомендации обычным шрифтом
                richBoxRecommend.SelectionFont = new Font(richBoxRecommend.Font, FontStyle.Regular);
                richBoxRecommend.SelectionColor = Color.Black;
                richBoxRecommend.AppendText($"{adv.AdviceText}\n");

                // Разделитель между советами
                richBoxRecommend.AppendText("----------------------------------\n");
            }
        }

        // метод автозаполнения comboBox' ов
        public void AutoCompleteFacts()
        {
            if (dataBaseThis == null) return;

            var facts = dataBaseThis.dictionaryFacts.Values.ToList();

            // Наполняем комбобоксы уникальными значениями из базы
            cmbObject.DataSource = facts.Select(f => f.Group).Distinct().ToList();
            cmbUnit.DataSource = facts.Select(f => f.Unit).Distinct().ToList();
            cmbAttribute.DataSource = facts.Select(f => f.Atribute).Distinct().ToList();
            cmbValue.DataSource = facts.Select(f => f.Value).Distinct().ToList();

            // Настраиваем режим автодополнения (как в форме правил)
            foreach (var cb in new[] { cmbObject, cmbUnit, cmbAttribute, cmbValue })
            {
                cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
                cb.SelectedIndex = -1; // Чтобы изначально были пустыми
            }
        }

        // Метод обновленния обновленния данных базы знаний
        public void RefreshData()
        {
            if (dataBaseThis != null)
            {
                UpdateFacts(dataBaseThis.dictionaryFacts); // обновляем списки для ListBox-ов и комбобокса цели

                AutoCompleteFacts(); // обновляем списки автодополнения
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Проверяем, что во всех комбобоксах что-то выбрано
            if (string.IsNullOrWhiteSpace(cmbObject.Text) || string.IsNullOrWhiteSpace(cmbUnit.Text) ||
                string.IsNullOrWhiteSpace(cmbAttribute.Text) || string.IsNullOrWhiteSpace(cmbValue.Text))
            {
                MessageBox.Show("Пожалуйста, выберите все параметры факта.");
                return;
            }

            // 2. Ищем факт в базе (используем ваш проверенный FirstOrDefault)
            // Важно: сравниваем именно строковые значения из комбобоксов
            var foundFact = dataBaseThis.dictionaryFacts.Values.FirstOrDefault(f =>
                f.Group == cmbObject.Text &&
                f.Unit == cmbUnit.Text &&
                f.Atribute == cmbAttribute.Text &&
                f.Value == cmbValue.Text.Trim());

            // 3. Если нашли - добавляем в рабочую память
            if (foundFact != null)
            {
                // Проверяем на дубликаты в самом списке, чтобы не добавлять одно и то же
                if (!listBoxFactsWork.Items.Contains(foundFact))
                {
                    listBoxFactsWork.Items.Add(foundFact);

                    // СРАЗУ обновляем рекомендации (наш "живой" отклик)
                    //UpdateLiveRecommendations();
                }
            }
            else
            {
                MessageBox.Show("Такой факт не найден в базе знаний! Проверьте правильность выбора.");
            }
        }
    }
}