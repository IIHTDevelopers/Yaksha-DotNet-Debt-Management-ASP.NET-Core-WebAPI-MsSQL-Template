using DebtManagement.BusinessLayer.Interfaces;
using DebtManagement.BusinessLayer.Services.Repository;
using DebtManagement.BusinessLayer.ViewModels;
using DebtManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement.BusinessLayer.Services
{
    public class DebtService : IDebtService
    {
        private readonly IDebtRepository _DebtRepository;

        public DebtService(IDebtRepository DebtRepository)
        {
            _DebtRepository = DebtRepository;
        }

        public async Task<Debt> CreateDebt(Debt Debt)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteDebtById(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Debt> GetAllDebts()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Debt> GetDebtById(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Debt> UpdateDebt(DebtViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}