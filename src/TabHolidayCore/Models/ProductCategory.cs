using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace TabHolidayCore.Models
{
    public class ProductCategory
    {
        [Key]
        public Int16 ProductCategoryId { get; set; }
        public string Name { get; set; }
    }
}
