using Microsoft.AspNetCore.Mvc;
using BudgetManagement.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using BudgetManagement.Services;

namespace BudgetManagement.Controllers
{
    public class AccountTypeController : Controller
    {
        private readonly IAccountTypeRepository _accountTypeRepository;

        public AccountTypeController(IAccountTypeRepository accountTypeRepository)
        {
            _accountTypeRepository = accountTypeRepository;
        }

        public IActionResult Create()
        {

            

            return View();
        }

        [HttpPost]
        public IActionResult Create(AccountType accountType)
        {
            if(!ModelState.IsValid)
            {
                return View(accountType);
            }

            accountType.UserId = 1; 
            _accountTypeRepository.Create(accountType);

            return View();
        }
    }
}