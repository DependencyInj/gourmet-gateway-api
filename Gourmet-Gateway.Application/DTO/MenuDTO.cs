﻿using System;
namespace Gourmet_Gateway.Application.DTO
{
	public class MenuDTO
	{
        public int menu_id { get; set; }
        public string Name { get; set; }
		public string? Description { get; set; }
		public decimal Price { get; set; }
		public string? Type { get; set; }
        public string? Image { get; set; }
    }
}

