using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting.Models.Ledger
{
    public class LedgerListingModel
    {
        public int Id { get; set; }

        public string AccountNo { get; set; }
        public string AccountTitle { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DrBalance { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CrBalance { get; set; }

        //public AccountType AccountType { get; set; }
    }
}
