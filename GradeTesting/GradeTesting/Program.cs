// See https://aka.ms/new-console-template for more information
using GradeTesting;

var gradeCalculator=new GradeCalculator();

Console.WriteLine("Enter the percentage :");
var percentage=Convert.ToInt32(Console.ReadLine());

var grade=gradeCalculator.GetGrade(percentage);
Console.WriteLine($"Student grade : {grade}");