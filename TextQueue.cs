public class TextQueueItem
{
	public int ID {get;set;}
	public string Name{get;set;}
	public Frequency Frequency {get;set;}
	public int Year {get;set;}
	public int Month {get;set;}
	public int Day {get;set;}
	public DayOfWeek DayOfWeek {get;set;}
	public int Hour {get;set;}
	public int Seconds {get;set;}
}

public enum Frequency
{
	OneTime = 0,
	Daily = 1,
	Weekly = 2,
	Monthly = 3,
	Annualy = 4,
}
