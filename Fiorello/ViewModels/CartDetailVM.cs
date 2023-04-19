﻿using System;
using Fiorello.Models;

namespace Fiorello.ViewModels
{
	public class CartDetailVM
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}