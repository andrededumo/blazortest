using System.Collections.ObjectModel;

namespace BlazorApp.ViewModels
{
    public class StudentListViewModel
    {
        public ObservableCollection<Student> Students { get; set; } = new ObservableCollection<Student>();

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
    //List of Student enrolled
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public int YearLevel { get; set; }
    }
}
