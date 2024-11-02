<<<<<<< HEAD
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
=======
﻿namespace SupermarketWEB.Models
{
    public class Category
    {

        public int Id { get; set; } // Sera la llave primaria
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Product>? Products { get; set; } // Propiedad de navegacion
    }
}
>>>>>>> 6182bfadce7588acb39cfb53303d29be2806ba20
