using BlazorTest.Data;
using System.Collections.Generic;


public class StudentListViewModel
{
    public List<Student> Students { get; set; }

    public StudentListViewModel()
    {
        Students = new List<Student>
        {
            new Student { Id = 1, FirstName = "John", LastName = "Doe", Course = "Computer Science", YearLevel = 3, Background = "Excellent in coding" },
            new Student { Id = 2, FirstName = "Jane", LastName = "Smith", Course = "Business Management", YearLevel = 2, Background = "Great leadership skills" },
            new Student { Id = 3, FirstName = "Michael", LastName = "Johnson", Course = "Engineering", YearLevel = 4, Background = "Strong analytical thinking" },
            new Student { Id = 4, FirstName = "Emily", LastName = "Davis", Course = "Marketing", YearLevel = 1, Background = "Creative content developer" },
            new Student { Id = 5, FirstName = "Sarah", LastName = "Brown", Course = "Finance", YearLevel = 3, Background = "Excellent financial analysis" }
        };
    }
}
