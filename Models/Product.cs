<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketEF.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public string Decimal { get; set; } 
        public int Stock {  get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
=======
﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Product
    {
        // [key] -> Anotacion si la propiedad no se llama Id, ejemplo ProductId

        public int Id { get; set; } // Sera la llave primaria
        public string Name { get; set; }

        [Column(TypeName = "decimal(6,2)")]

        public decimal Price { get; set; }
        public int Stork { get; set; }
        public int CategoryId { get; set; } // Sera la llave foranea
        public Category Category { get; set; } // Propiedad de navegacion
>>>>>>> 6182bfadce7588acb39cfb53303d29be2806ba20
    }
}
