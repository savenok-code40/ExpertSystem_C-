using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertBase.Helpers
{
    // Наследуемся от стандартного BindingList, чтобы добавить функционал сортировки
    public class SortableBindingList<T> : BindingList<T>
    {
        private bool _isSorted; // Флаг: отсортирован ли список сейчас
        private PropertyDescriptor? _sortProperty; // По какому свойству (колонке) идет сортировка
        private ListSortDirection _sortDirection; // Направление: по возрастанию или убыванию

        // Конструктор: принимает обычный список IList (например, ToList() из вашей базы)
        public SortableBindingList(IList<T> list) : base(list) { }

        // Переопределяем системные свойства, чтобы DataGridView "понял", что этот список УМЕЕТ сортироваться
        protected override bool SupportsSortingCore => true; // Разрешаем сортировку
        protected override bool IsSortedCore => _isSorted;    // Сообщаем текущий статус
        protected override PropertyDescriptor? SortPropertyCore => _sortProperty; // Сообщаем текущую колонку
        protected override ListSortDirection SortDirectionCore => _sortDirection; // Сообщаем текущее направление

        // Основной метод, который вызывается при клике на заголовок колонки в Grid
        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            // Получаем доступ к внутреннему списку элементов
            var items = this.Items as List<T>;

            if (items != null)
            {
                // Создаем специальный "сравниватель" (компаратор), который умеет сравнивать значения в колонках
                var pc = new PropertyComparer<T>(prop, direction);

                // Выполняем стандартную сортировку списка List<T>
                items.Sort(pc);

                // Запоминаем текущие параметры сортировки
                _isSorted = true;
                _sortProperty = prop;
                _sortDirection = direction;
            }
            else
            {
                _isSorted = false;
            }

            // ВАЖНО: Уведомляем DataGridView, что список изменился (нужно перерисовать таблицу)
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        // Метод для сброса сортировки (если понадобится программно)
        protected override void RemoveSortCore()
        {
            _isSorted = false;
            _sortProperty = null;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        // ВНУТРЕННИЙ КЛАСС: Логика сравнения двух объектов по любому свойству (рефлексия)
        private class PropertyComparer<TItem> : IComparer<TItem>
        {
            private readonly PropertyDescriptor _prop;
            private readonly ListSortDirection _direction;

            public PropertyComparer(PropertyDescriptor prop, ListSortDirection direction)
            {
                _prop = prop;
                _direction = direction;
            }

            // Метод сравнения двух объектов x и y
            public int Compare(TItem? x, TItem? y)
            {
                if (x == null || y == null) return 0;

                // 1. Сначала сравниваем по выбранной колонке (на которую кликнули)
                var xVal = _prop.GetValue(x);
                var yVal = _prop.GetValue(y);
                int result = CompareValues(xVal, yVal);

                // 2. ВАЖНО: Если значения одинаковые (result == 0), 
                // пробуем отсортировать по дополнительному полю (например, "Atribute")
                if (result == 0)
                {
                    // Пытаемся найти свойство "Atribute" у объекта
                    var secondaryProp = TypeDescriptor.GetProperties(typeof(TItem))["Atribute"];
                    if (secondaryProp != null)
                    {
                        var xSecondary = secondaryProp.GetValue(x);
                        var ySecondary = secondaryProp.GetValue(y);
                        result = CompareValues(xSecondary, ySecondary);
                    }
                }

                return _direction == ListSortDirection.Ascending ? result : -result;
            }

            // Вспомогательный метод для чистоты кода
            private int CompareValues(object? xVal, object? yVal)
            {
                if (xVal is IComparable comparableX)
                    return comparableX.CompareTo(yVal);

                return string.Compare(xVal?.ToString(), yVal?.ToString());
            }
        }
    }
}
