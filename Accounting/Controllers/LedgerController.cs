using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingData;
using AccountingData.Models;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.Controllers
{
    public class LedgerController : Controller
    {
        public IAccount _accountsService;
        public LedgerController(IAccount acoountsService)
        {
            _accountsService = acoountsService;
        }

        public IActionResult Index()
        {
            IEnumerable<Account> leadgerlist = _accountsService.GetAll();
            return View();
        }
    }
}