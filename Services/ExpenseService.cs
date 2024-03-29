﻿using System;
using Microsoft.EntityFrameworkCore;
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
        public List<Expense> GetExpense()
        {

            return _context.Expenses.Include(expense => expense.Category).ToList();
        }


        public Expense AddExpense(Expense expense)
        {
            _context.Expenses.Add(expense);
            _context.SaveChanges();

            return expense;
        }


        //To Update the records of a particluar user
        public Expense UpdateExpense(Expense expense)
        {
            expense.Date = expense.Date.ToUniversalTime();
            _context.Entry(expense).State = EntityState.Modified;
            _context.SaveChanges();

            return expense;
        }

        //Get the details of a particular user
        public Expense GetExpenseData(int id)
        {
            try
            {
                Expense? expense = _context.Expenses.Find(id);
                if (expense != null)
                {
                    return expense;
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





        public void DeleteExpense(int id)
        {
            try
            {
                Expense? expense = _context.Expenses.Find(id);
                if (expense != null)
                {
                    _context.Expenses.Remove(expense);
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

