using AccountingData.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;

namespace AccountingData
{
    public class AccountingContext : DbContext
    {
        public AccountingContext( DbContextOptions options) : base(options){}
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        
    }
}
