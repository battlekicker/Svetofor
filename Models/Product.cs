using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Svetofor.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string Title { get; set; }
        [Display(Name = "Вес")]
        public string Weight { get; set; }
        [Display(Name = "Цена")]
        public double Price { get; set; }
    }
}
