using DebtManagement.BusinessLayer.ViewModels;
using DebtManagement.DataLayer;
using DebtManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement.BusinessLayer.Services.Repository
{
    public class DebtRepository : IDebtRepository
    {
        private readonly DebtDbContext _dbContext;
        public DebtRepository(DebtDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Debt> CreateDebt(Debt debt)
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