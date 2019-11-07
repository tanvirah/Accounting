using AccountingData;
using AccountingData.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AccountingServices
{
    public class AccountsPayableService : IPayable
    {
        private AccountingContext _context;

        public AccountsPayableService (AccountingContext context)
        {
            _context = context;
        }
        public void Add(Transaction newTransaction)
        {
            _context.Add(newTransaction);
            _context.SaveChanges();
        }

        public void CreatePayment(Transaction newPayment)
        {
            _context.Add(newPayment);
            _context.SaveChanges();
        }

        public Account GetAccountInfo(int id)
        {
            return GetById(id).Accounts;
        }

        public string GetAccountTitle(int id)
        {
            return GetAccountInfo(id).AccountTitle;
        }

        public IEnumerable<Transaction> GetAll()
        {
            return _context.Transactions
                .Include(asset => asset.Accounts)
                .Include(asset => asset.Voucher);
        }

        public Transaction GetById(int id)
        {
            return _context.Transactions
                .Include(asset => asset.Accounts)
                .Include(asset => asset.Voucher)
                .FirstOrDefault(asset => asset.Id == id);
        }

     
    }
}
