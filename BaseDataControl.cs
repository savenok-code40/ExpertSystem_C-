using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertBase
{
    // Абстрактный базовый класс для FactsControl и RulesControl
    // T - это тип данных (Fact или Rule)
    public abstract class BaseDataControl<T>: UserControl where T : class
    {
        // Защищенные поля, доступные наследующим классам
        protected DataBase? dataBase;
        protected BindingList<T>? bindingList;        
        public BindingList<T>? BindingList => bindingList; // Публичное свойство для доступа к списку

        // Этот метод должны реализовать дочерние классы для настройки DataGrid
        protected abstract DataGridView DataGrid { get; }

        // Общая логика инициализации данных
        public void InitializeData(DataBase db)
        {
            dataBase = db;
            // Дочерний класс должен вызвать SetupDataGrid() после InitializeData()
        }

        // Общая логика настройки DataGrid и привязки данных
        protected void SetupDataGrid(IEnumerable<T> data)
        {
            bindingList = new BindingList<T>(data.ToList());
            if (DataGrid != null)
            {
                DataGrid.DataSource = bindingList;
            }
        }

        // Общая логика обновления привязки данных (как мы ее исправили ранее)
        public void RefreshDataBinding(IEnumerable<T> data)
        {
            if (bindingList != null)
            {
                bindingList.Clear();
                foreach (var item in data)
                {
                    bindingList.Add(item);
                }
                // DataGrid обновится автоматически через BindingList
            }
        }
    }
}
