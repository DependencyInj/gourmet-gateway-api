using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gourmet_Gateway.Domain.Models
{
    [Table(name: "menu_type")]
    public class Menu_Type
	{
        [Key]
		public int menu_type_id { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
        public string code { get; set; } = "NA";
    }
}

