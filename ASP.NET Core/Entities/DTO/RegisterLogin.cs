using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Entities.Enum;
namespace Entities.DTO
{
    public class RegisterLogin
    {
        [Required]public string username { get; set; }
        [Required][DataType(DataType.Password)] public string password { get; set; }
      
        //[Required][DataType(DataType.Date)] public DateTime creation_date;
        //[Required]
        //public AccountType accType;
    }
}
