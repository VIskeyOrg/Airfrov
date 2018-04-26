using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace TabHolidayCore.Models
{
    public class ProductRequest
    {
        [Key]
        public Int64 ProductRequestId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string ProductDescription { get; set; }

    }
}
