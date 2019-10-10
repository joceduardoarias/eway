using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace WebApplication1.Models
{
    public class Movie
    {
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Rating { get; set; }
    }
    /*La MovieDBContextclase que creó maneja la tarea de conectarse 
     * a la base de datos y asignar Movieobjetos a los registros de la base de datos.*/
    public class MovieDBContext : DbContext
    {   
        public DbSet<Movie> Movies { get; set; }
    }
}