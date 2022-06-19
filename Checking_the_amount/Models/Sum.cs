using Azure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Checking_the_amount.Models
{
    public class Sum
    {
        public Sum()
        {
            Random random = new Random();
            ValueOne = random.Next(0, 1000);
            ValueTwo = random.Next(0, 1000);
            Result = ValueOne + ValueTwo;
        }
        public int ValueOne { get; set; }
        public int ValueTwo { get; set; }
        public int Result { get; set; }

        [Required(ErrorMessage = "必须设置字段")]
        [Compare("Result", ErrorMessage = "结果错误")]
        public int InputValue { get; set; }
    }
}
