﻿using DebtManagement.BusinessLayer.Interfaces;
using DebtManagement.BusinessLayer.ViewModels;
using DebtManagement.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DebtManagement.Controllers
{
    [ApiController]
    public class DebtController : ControllerBase
    {
        private readonly IDebtService _DebtService;
        public DebtController(IDebtService DebtService)
        {
            _DebtService = DebtService;
        }

        [HttpPost]
        [Route("create-debt")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateDebt([FromBody] Debt model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("update-debt")]
        public async Task<IActionResult> UpdateDebt([FromBody] DebtViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("delete-debt")]
        public async Task<IActionResult> DeleteDebt(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("get-debt-by-id")]
        public async Task<IActionResult> GetDebtById(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("get-all-debts")]
        public async Task<IEnumerable<Debt>> GetAllDebts()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}