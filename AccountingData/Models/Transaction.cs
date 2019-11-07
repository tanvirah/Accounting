using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AccountingData.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int  SerialNo { get; set; }
        public DateTime TransactionDate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Dr { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Cr { get; set; }

        public virtual Account Accounts { get; set; }
        public virtual Voucher Voucher { get; set; }

    }
}
