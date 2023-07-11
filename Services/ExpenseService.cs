using System;
using Test1.Data;
using Test1.Data.Models;

namespace Test1.Services
{
	public class ExpenseService
	{
        private readonly ExpenseTrackerContext _context;
        public ExpenseService(ExpenseTrackerContext context)
        {
            _context = context;
        }
        //public List<Expense> GetExpenses()
        //{
        //    return _context.Expenses.ToList();
        //}
    }
}

