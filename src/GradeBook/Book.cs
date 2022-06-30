using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book
  {
    public Book(string name)
    {
      grades = new List<double>();
      Name = name;  
    }

    public void AddLetterGrade(char letter)
    {
      switch(letter)
      {
        case 'A':
          AddGrade(90);
          break;
        case 'B':
          AddGrade(80);
          break;
        case 'C':
          AddGrade(70);
          break;
        case 'D':
          AddGrade(60);
          break;
        case 'F':
          AddGrade(50);
          break;
        default:
          AddGrade(0);
          break;
      }
    }
    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public Statistics GetStatistics()
    {

            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low= double.MaxValue;

            foreach(var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            switch(result.Average)
            {
              case var d when d >= 90.0:
                result.Letter = 'A';
                break;
              case var d when d >= 80.0:
                result.Letter = 'B';
                break;
              case var d when d >= 70.0:
                result.Letter = 'C';
                break;
              case var d when d >= 60.0:
                result.Letter = 'D';
                break;
              default:
                result.Letter = 'F';
                break;
            }

            return result;
    }

    public void ShowStatisics()
    {
      var stats = this.GetStatistics();
      System.Console.WriteLine($"The average grade is {stats.Average:N1}");
      System.Console.WriteLine($"The lowest grade is {stats.Low}");
      System.Console.WriteLine($"The highest grade is {stats.High}");
      System.Console.WriteLine($"The letter grade is {stats.Letter}");
    }

    private List<double> grades;
    public string Name
    {
      get;
      private set;
    }

    readonly string category = "Science";
  }
}