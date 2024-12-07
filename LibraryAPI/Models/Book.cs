﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LibraryAPI.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
    }
}
