using AccountingData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingData
{
    public interface IAccount
    {
        IEnumerable<Account> GetAll();
        void Add(Account newGlAccount);
        Account GetById(int id);
        Account GetAccountInfo(int id);
        string GetAccountTitle(int id);        
    }
}
