﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeerDiary_Backend.Models
{
    public class RandomQuestion
    {
        [Column("RandomQuestionId")]
        public int Id { get; set; }
        [Column("RandomQuestionText")]
        [Required(ErrorMessage = "Relation to date missing")]
        public string RandomQuestionText { get; set; }

    }
}