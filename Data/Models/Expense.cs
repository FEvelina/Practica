using System;
namespace Test1.Data.Models
{
	public class Expense
	{
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateOnly Date { get; set; }
        public int Amount { get; set; }
        public bool? Planed { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

	}
}

