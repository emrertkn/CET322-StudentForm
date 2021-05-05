using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CetBookStore.Models
{
    public class Book
    {
        public Book()
        {
            CreatedDate = DateTime.Now;
        }
        public int Id { get; set; }
        [DisplayName("İsim")]
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        public int? PageCount { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Age;

    }

}

