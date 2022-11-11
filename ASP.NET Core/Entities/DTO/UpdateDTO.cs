using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DTO
{
    public  class UpdateDTO
    {
        [Required] public string password { get; set; }
        [Required] public string repeatPassword { get; set; }
    }
}
