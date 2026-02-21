using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertBase
{
    public class ForwardChaining
    {
        private DataBase db; // поле для хранения базы знаний
        public ForwardChaining(DataBase dataBase)
        {
            this.db = dataBase;
        }

        // Метода проверки заданной цели в прямом выводе
        public void Compute(List<Fact> factsInemory, Fact purposeFact, StringBuilder output)
        {

        }

    }
}
