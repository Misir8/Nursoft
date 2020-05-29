using Microsoft.AspNetCore.Mvc.Rendering;
using Nursoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nursoft.ViewModels
{
    public class FilterViewModel
    {
        public FilterViewModel(List<CategoryProduct> categoryProducts, int? category, string name)
        {
            // устанавливаем начальный элемент, который позволит выбрать всех
            categoryProducts.Insert(0, new CategoryProduct { Name = "Bütün kateqoriyalar", Id = 0 });
            Categories = new SelectList(categoryProducts, "Id", "Name", category);
            SelectedCategory = category;
            SelectedName = name;
        }
        public SelectList Categories { get; private set; } // список компаний
        public int? SelectedCategory { get; private set; }   // выбранная компания
        public string SelectedName { get; private set; }    // введенное имя
    }
}
