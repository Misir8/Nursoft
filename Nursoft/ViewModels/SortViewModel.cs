using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nursoft.ViewModels
{
    public class SortViewModel
    {
        public SortState NameSort { get; private set; } // значение для сортировки по имени
        public SortState Current { get; private set; }     // текущее значение сортировки
        public SortState CategorySort { get; private set; }   // значение для сортировки по компании
        public SortViewModel(SortState sortOrder)
        {
            NameSort = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            CategorySort = sortOrder == SortState.CategoryAsc ? SortState.CategoryDesc : SortState.CategoryAsc;
            Current = sortOrder;
        }

        
    }
    public enum SortState
    {
        NameAsc,    // по имени по возрастанию
        NameDesc,   // по имени по убыванию
        AgeAsc, // по возрасту по возрастанию
        AgeDesc,    // по возрасту по убыванию
        CategoryAsc, // по компании по возрастанию
        CategoryDesc // по компании по убыванию
    }
}
