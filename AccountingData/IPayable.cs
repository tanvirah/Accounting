using AccountingData.Models;
using System.Collections.Generic;

namespace AccountingData
{
    public interface IPayable
    {
        IEnumerable<Transaction> GetAll();
        void Add(Transaction newTransaction);
        Transaction GetById(int id);
        Account GetAccountInfo(int id);
        string GetAccountTitle(int id);
        void CreatePayment(Transaction newPayment);
        //void MakePayment(Transaction newPayment);

    }
}
