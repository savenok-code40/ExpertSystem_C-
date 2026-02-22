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
        //DataBase db = new DataBase();   

        public InferenceControl()
        {
            InitializeComponent();
        }

        private void btnCheckTarget_Click(object sender, EventArgs e)
        {
            // 1. Проверка и подготовка данных
            if (cmbChooseTarget.SelectedItem == null) // если не выбрана цель
            {
                MessageBox.Show("Пожалуйста, выберите целевой факт.");
                return;
            }

            DateTime startTime = DateTime.Now;
            ritchBoxOutputChain.Clear();
            StringBuilder sb = new StringBuilder();                 
        }

        public void UpdateFacts(Dictionary<int, Fact> facts)
        {
            cmbChooseTarget.Items.Clear(); // очищаем комбобокс

            foreach (Fact f in facts.Values)
            {
                if(f.Type == Fact.enTypeFact.Dinamic_OUT)
                {
                    cmbChooseTarget.Items.Add(f);    
                }
            }

            if (cmbChooseTarget.Items.Count > 0)
            {
                cmbChooseTarget.SelectedIndex = 0;
            }
        }
    }
}
