using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Models
{
    public class Document
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter title.")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Enter author.")]
        public string Author { get; set; }

        [Required(ErrorMessage ="Enter username.")]
        public string UserName { get; set; }
    }
}
