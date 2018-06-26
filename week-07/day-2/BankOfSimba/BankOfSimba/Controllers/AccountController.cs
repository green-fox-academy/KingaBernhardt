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

        public IActionResult LionKing()
        {
            List<BankAccount> bankAccounts = new List<BankAccount>()
            {
                new BankAccount(){ Id = 1, Name = "Pumba", Balance = 305, AnimalType = "warthog"},
                new BankAccount() {Id = 2, Name = "Zordon", Balance = 1, AnimalType= "lion"},
                new BankAccount() {Id= 3, Name = "Timon", Balance = 359, AnimalType= "meercat"},
                new BankAccount() {Id = 4, Name = "Nala", Balance = 200, AnimalType= "lion"}
            };

            return View(bankAccounts);
        }
    }
}