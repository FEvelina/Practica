using System;
namespace Test1.Data.Models
{
	public class Income
	{
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateOnly Date { get; set; }
        public int Amount { get; set; }
        public Type Type { get; set; }
 
    }
    public enum Type
    {
        Salary,
        Scholarship,
        Gift,
        Lucky_Winnings
    }
}

