/*
1992 05 31
2016 06 17

*/
using _05.DateModifier;

string firstDateAsString = Console.ReadLine();
string secondDateAsString = Console.ReadLine();

DateTime firstDate = DateTime.Parse(firstDateAsString);
DateTime secondDate = DateTime.Parse(secondDateAsString);

int daysDiff = DateModifier.CalculateDateDiffInDays(firstDate, secondDate);

Console.WriteLine(daysDiff);
