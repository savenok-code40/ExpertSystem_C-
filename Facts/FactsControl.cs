using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertBase
{
    public partial class FactsControl : UserControl
    {
        // Знак ? говорит компилятору, что поля при создании FactsControl могут быть Null
        private DataBase? dataBaseThis; // получает (хранит) ссылку на базу знаний

        private BindingList<Fact>? factsBindingList; // закрытая переменная для хранения базы фактов и наполения DataGrid                                                   
        public BindingList<Fact>? FactsBindingList => factsBindingList; // Публичное свойство закрытой factsBindingList

        // Конструктор класса
        public FactsControl()
        {
            InitializeComponent();  
        }

        // Методы для получения экземпляра DataBase и отображения его в таблице DataGrid
        public void InitializeDatabase(DataBase db)
        {
            dataBaseThis = db;
            factsBindingList = new BindingList<Fact>(dataBaseThis.dictionaryFacts.Values.ToList()); // Инициализируем BindingList текущим списком фактов в БД 
            dataGridFacts.DataSource = factsBindingList; // Устанавливаем источник данных для DataGridView             
        }   

        // Метод для обновления таблицы DataGrid после загрузки базы из файла
        public void RefreshDataBinding()
        {
            if (dataBaseThis != null && factsBindingList != null)
            {                
                factsBindingList.Clear(); // Очищаем существующий список

                // Добавляем все актуальные элементы из базы данных в существующий список
                foreach (var fact in dataBaseThis.dictionaryFacts.Values.ToList())
                {
                    factsBindingList.Add(fact);
                }
            }
        }    

        // Кнопка добавить факт - вызывает окно создания факта
        private void btnAddFact_Click(object sender, EventArgs e)
        {
            // Проверка, что список фактов factsBindingList инициализирован, перед его использованием в factForm.AutoFillComboBoxes(factsBindingList.ToList());
            if (factsBindingList == null)
            {
                MessageBox.Show("Не инициализирован factsBindingList.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // using гарантирует, что экземпляр класса удалиться после закрытия окна 
            using (var factForm = new FactForm()) // экземпляр модальной формы FactForm (открыли окно)
            {
                factForm.AutoFillComboBoxes(factsBindingList.ToList()); // вызвали метод автозаполнения из FactForm.cs

                if (factForm.ShowDialog() == DialogResult.OK) // Если после заполнения нажали OK
                {
                    // Если пользователь нажал OK, считываем данные из полей формы и создаем новый факт
                    var newFact = new Fact(
                        factForm.FactObject,
                        factForm.FactUnit,    
                        factForm.FactAttribute,
                        factForm.FactValue,
                        factForm.Truth,
                        factForm.FactType,
                        factForm.FunModbus,
                        factForm.AddrReg
                    );

                    // Проверяем, существует ли факт с такими же основными параметрами
                    bool existsFact = factsBindingList.Any(f =>
                        f.Group == newFact.Group &&
                        f.Unit == newFact.Unit &&
                        f.Atribute == newFact.Atribute && 
                        f.Value == newFact.Value); // Проверка на совпадение всех 4 полей

                    if (existsFact)
                    {
                        MessageBox.Show("Факт с такими параметрами уже существует в базе данных.", "Дубликат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Прерываем добавление
                    }

                    // Добавьте проверку для dataBaseThis здесь:
                    if (dataBaseThis != null && factsBindingList != null)
                    {
                        // Теперь безопасно добавляем факт в базу данных (в словарь с генерацией ID) и  в BindingList
                        dataBaseThis.AddFact(newFact); 
                        factsBindingList.Add(newFact); 
                    }
                    else
                    {
                        MessageBox.Show("Невозможно добавить факт: Не инициализирована  dataBaseThis", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                   
                }
            }
        }

        // Обработчик кнопки "Удалить" с защитой, если применен в правилах и рекомендациях, то удалить нельзя
        private void btnDeleteFact_Click(object sender, EventArgs e)
        {
            // 1. Защита от Null (ваша проверка инициализации)
            if (dataBaseThis == null || factsBindingList == null)
            {
                MessageBox.Show("База данных не инициализирована.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Проверка, что в таблице что-то выбрано
            if (dataGridFacts.SelectedRows.Count > 0 && dataGridFacts.CurrentRow.DataBoundItem is Fact factToRemove)
            {
                // 3. ПРОВЕРКА ЦЕЛОСТНОСТИ (Новый блок)
                // Проверяем, не используется ли этот объект в правилах
                bool isUsedInRules = dataBaseThis.dictionaryRules.Values
                    .Any(r => r.listPremise.Contains(factToRemove) ||
                              r.listConclusion.Contains(factToRemove));

                // Проверяем использование в рекомендациях
                bool isUsedInRecs = dataBaseThis.listRecommendations
                    .Any(rec => rec.TargetFact.Equals(factToRemove));

                if (isUsedInRules || isUsedInRecs)
                {
                    MessageBox.Show("Нельзя удалить факт! Он используется в правилах или рекомендациях.\n" +
                                    "Сначала удалите или отредактируйте связанные с ним правила/советы.",
                                    "Ошибка целостности", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return; // Прерываем удаление
                }

                // 4. Если всё чисто — удаляем (ваш проверенный код)
                dataBaseThis.dictionaryFacts.Remove(factToRemove.ID);
                factsBindingList.Remove(factToRemove);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите факт для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Обработчик кнопки Редактировать
        private void btnEditFact_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли строка и есть ли данные
            if (dataGridFacts.SelectedRows.Count == 0 || dataGridFacts.CurrentRow.DataBoundItem is not Fact selectedFact)
            {
                MessageBox.Show("Пожалуйста, выберите факт для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // открываем окно (форму создания/редактирования факта) 
            using (var factForm = new FactForm())
            {                
                if (factsBindingList != null)
                {
                    factForm.AutoFillComboBoxes(factsBindingList.ToList()); // автозаполнения comboBox
                } 

                factForm.LoadFactData(selectedFact); // Передаем в форму данные выделенного факта для отображения

                if (factForm.ShowDialog() == DialogResult.OK) // нажимаем ОК после редактирования
                {
                    // обновляем факт selectedFact новыми данными из формы                     
                    selectedFact.Group = factForm.FactObject;
                    selectedFact.Unit = factForm.FactUnit;
                    selectedFact.Atribute = factForm.FactAttribute;
                    selectedFact.Value = factForm.FactValue;
                    selectedFact.Truth = factForm.Truth;
                    selectedFact.Type = factForm.FactType;
                    selectedFact.FunModbus = factForm.FunModbus;
                    selectedFact.RegAddr = factForm.AddrReg;

                    // Так как мы изменили свойства объекта, который уже находится в factsBindingList и dataBaseThis.dictionaryFacts, UI обновится автоматически                  
                    
                    factsBindingList!.ResetBindings(); // Иногда требуется для гарантии обновления UI. Вызываем с проверкой на null
                                                       // использование !, говорит компилятору "довериться мне" по риску пустой ссылки
                }
            }

            // Обновляем в правилах и рекомендациях 
            if (this.ParentForm is MainForm main)
            {
                main.RefreshAllGrids(); // Даем команду главной форме обновить всё
            }
        }

        // Обработчик кнопки Вверх
        private void btnMoveUpFact_Click(object sender, EventArgs e)
        {
            if (dataGridFacts.CurrentRow != null)
            {
                int currentIndex = dataGridFacts.CurrentRow.Index; // Возвращаем индекс выбранной строки
                
                if (currentIndex > 0 && factsBindingList != null) // Проверяем, что не на первой строке и factsBindingList есть в памяти
                {
                    // Получаем объект, который нужно переместить
                    Fact factToMove = factsBindingList[currentIndex];

                    // Удаляем его из текущей позиции
                    factsBindingList.RemoveAt(currentIndex);

                    // Вставляем его на позицию выше
                    factsBindingList.Insert(currentIndex - 1, factToMove);

                    // ИСПРАВЛЕНИЕ: Устанавливаем текущую ячейку, чтобы сохранить фокус
                    dataGridFacts.CurrentCell = dataGridFacts.Rows[currentIndex - 1].Cells[0];
                }
            }
        }

        // Обработчик кнопки Вниз
        private void btnMoveDownFact_Click(object sender, EventArgs e)
        {
            if (dataGridFacts.CurrentRow != null && factsBindingList != null)
            {
                int currentIndex = dataGridFacts.CurrentRow.Index;
                
                if (currentIndex < (factsBindingList.Count - 1)) // Проверяем, что не на последней строке
                {                    
                    Fact factToMove = factsBindingList[currentIndex]; // Получаем объект, который нужно переместить
                    
                    factsBindingList.RemoveAt(currentIndex); // Удаляем его из текущей позиции
                    
                    factsBindingList.Insert(currentIndex + 1, factToMove); // Вставляем его на позицию ниже

                    // Устанавливаем текущую ячейку, чтобы сохранить фокус
                    dataGridFacts.CurrentCell = dataGridFacts.Rows[currentIndex + 1].Cells[0];
                }
            }
        }
    }
}
