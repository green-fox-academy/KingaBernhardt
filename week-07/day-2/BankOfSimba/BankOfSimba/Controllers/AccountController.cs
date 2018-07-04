using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    public class AccountController : Controller
    {
        public static List<BankAccount> bankAccounts = new List<BankAccount>()
        {
            new BankAccount() { Name = "Pumba", Balance = 305, AnimalType = "warthog", IsKing = false, IsGood = true },
            new BankAccount() { Name = "Zordon", Balance = 1, AnimalType = "lion", IsKing = false, IsGood = false },
            new BankAccount() { Name = "Timon", Balance = 359, AnimalType = "meercat", IsKing = false, IsGood = true },
            new BankAccount() { Name = "Nala", Balance = 200, AnimalType = "lion", IsKing = false, IsGood = true },
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Simba()
        {
            BankAccount bankAccount = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = "lion"
            };
            return View(bankAccount);
        }

        [HttpPost]
        public IActionResult GetLogInPage()
        {
            return RedirectToAction("GetLogInPage");
        }

        [HttpGet("GetLogInPage")]
        public IActionResult LoggedIn()
        {
            return View(bankAccounts);
        }

        public IActionResult LionKing()
        {
            return View(bankAccounts); 
        }
        
        [HttpPost]
        [Route("AddCurrency")]
        public IActionResult AddCurrency(int id)
        {
            bankAccounts[id].AddMoney(id);
            return RedirectToAction("LionKing");
        }
    }
}