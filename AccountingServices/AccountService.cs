using AccountingData;
using AccountingData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingServices
{
    public class AccountService : IAccount
    {
        private AccountingContext _context;

        public AccountService(AccountingContext context)
        {
            _context = context;
        }

        public void Add(Account newGlAccount)
        {
            throw new NotImplementedException();
        }

        public Account GetAccountInfo(int id)
        {
            throw new NotImplementedException();
        }

        public string GetAccountTitle(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Account> GetAll()
        {
            throw new NotImplementedException();
        }

        public Account GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
