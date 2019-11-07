using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AccountingData.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string AccountNo { get; set; }
        public string AccountTitle { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DrBalance { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CrBalance { get; set; }

        public AccountType  AccountType { get; set; }
        //public AccountNature AccountNature { get; set; }
    }
}


