using System;
namespace Test1.Data.Models
{
	public class Category
	{
		public int Id { get; set; }
        public string? Name { get; set; }
		public ICollection<Expense> Expenses { get; } = new List<Expense>();

	}


}

