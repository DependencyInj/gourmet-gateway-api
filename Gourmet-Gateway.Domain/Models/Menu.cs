using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gourmet_Gateway.Domain.Models
{
    [Table(name:"menu")]
	public class Menu
	{
        [Key]
		public int menu_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int menu_type_id { get; set; }
        public string image { get; set; }
    }
}

