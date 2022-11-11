using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Entities.DTO
{
    public class ReviewDTO
    {
        [Required] public string review { get; set; }
        [Required] public int score { get; set; }

    }
}
