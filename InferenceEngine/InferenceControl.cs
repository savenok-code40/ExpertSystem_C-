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
        DataBase db = new DataBase();   

        public InferenceControl()
        {
            InitializeComponent();
        }

        // Метод получения базы знаний. Вызываю в коде главной формы
        public void InitializeDataBase(DataBase db)
        {
            this.db = db;   
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
            ForwardChain forwardChain = new ForwardChain(db);
            forwardChain.ComputeForwardChain(factsInMemory, targetFact, sb);  
            
            // 3. Расчет времени выполнения и вывод сообщений в рич бокс
            DateTime endTime = DateTime.Now;
            TimeSpan timeSpan = endTime - startTime;

            ritchBoxOutputChain.AppendText(sb.ToString());
            ritchBoxOutputChain.AppendText("\n--- --- ---\n");
            ritchBoxOutputChain.AppendText($"Время выполнения: {timeSpan.TotalMilliseconds:F0} мс");
        }

        public void UpdateFacts(Dictionary<int, Fact> facts)
        {
            // Обновляем комбо бокс
            cmbChooseTarget.Items.Clear(); // очищаем комбобокс

            foreach (Fact f in facts.Values)
            {
                if (f.Type == Fact.enTypeFact.Dinamic_OUT)
                {
                    cmbChooseTarget.Items.Add(f);
                }
            }

            if (cmbChooseTarget.Items.Count > 0)
            {
                cmbChooseTarget.SelectedIndex = 0;
            }

            // Обновляем ListBox исходных фактов
            listBoxFactsInit.Items.Clear(); // очищаем

            foreach (Fact f in facts.Values)
            {
                if (f.Type == Fact.enTypeFact.Static || f.Type == Fact.enTypeFact.Dinamic_IN)
                {
                    listBoxFactsInit.Items.Add(f);
                }
            }
        }

        // Двойной клик по факту в поле Исходные добавляет факт в рабочую память и удаляет из исходных
        private void listBoxFactsInit_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxFactsInit.SelectedIndex >= 0)
            {
                listBoxFactsWork.Items.Add(listBoxFactsInit.Items[listBoxFactsInit.SelectedIndex]); // добавить в рабочую память
                listBoxFactsInit.Items.Remove(listBoxFactsInit.Items[listBoxFactsInit.SelectedIndex]); // удалить из исходных
            }
        }

        // Обратное действие - из рабочей памяти в список исходные
        private void listBoxFactsWork_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listBoxFactsWork.SelectedIndex >= 0)
            {
                listBoxFactsInit.Items.Add(listBoxFactsWork.Items[listBoxFactsWork.SelectedIndex]); // добавить в исходные
                listBoxFactsWork.Items.Remove(listBoxFactsWork.Items[listBoxFactsWork.SelectedIndex]); // удалить из рабочей памяти
            }

        }

        
    }
}
