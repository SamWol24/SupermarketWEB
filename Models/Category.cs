﻿namespace SupermarketEF.Models
{
    public class Category
    {
        public int Id { get; set; } // llave primaria
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> products { get; set; } //propiedad de navegacion
    }
}