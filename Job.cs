using System;
public class job 
{
string _company = "";
string _jobTitle = "";
int _startYear = "";
int _endYear = "";

public void Display()
{
Console.WriteLine($"{_company} ({_jobTitle}) ({_startYear}) ({_endYear})")
}
}