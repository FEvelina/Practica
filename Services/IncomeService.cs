using System;
using Microsoft.EntityFrameworkCore;
using Test1.Data;
using Test1.Data.Models;

namespace Test1.Services
{
	public class IncomeService
	{
        private readonly ExpenseTrackerContext _context;
        public IncomeService(ExpenseTrackerContext context)
        {
            _context = context;
        }
        public List<Income> GetIncome()
        {

            return _context.Incomes.ToList();
        }


        public Income AddIncome(Income income)
        {
            _context.Incomes.Add(income);
            _context.SaveChanges();

            return income;
        }


        //To Update the records of a particluar user
        public Income UpdateIncome(Income income)
        {
            income.Date = income.Date.ToUniversalTime();
            _context.Entry(income).State = EntityState.Modified;
            _context.SaveChanges();

            return income;
        }

        //Get the details of a particular user
        public Income GetIncomeData(int id)
        {
            try
            {
                Income? income = _context.Incomes.Find(id);
                if (income != null)
                {
                    return income;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }





        public void DeleteIncome(int id)
        {
            try
            {
                Income? income = _context.Incomes.Find(id);
                if (income != null)
                {
                    _context.Incomes.Remove(income);
                    _context.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}

