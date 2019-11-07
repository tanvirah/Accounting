using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingData.Models
{
    public class Voucher
    {
        public int Id { get; set; }
        public int VoucherNo { get; set; }
        public DateTime VoucherDate { get; set; }
        //public virtual VoucherType {get; set;}

        //public virtual IEnumerable<Transaction> Transactions { get; set; }
        
    }
}


