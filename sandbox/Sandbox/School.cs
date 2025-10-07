public class School
{
    public string _name;
    public int _numStudents;
    public int _numTeachers;

    public List<Student> _students = new List<Student>();

    public void AddStudent()
    {
        Student newStudent = new Student();

        Console.WriteLine($"Adding a new student to {_name}");

        newStudent._id = _students.Count + 1;
        Console.WriteLine($"Student ID: {newStudent._id}");

        Console.Write("Enter student name: ");
        newStudent._name = Console.ReadLine();

        _students.Add(newStudent);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{_name} has {_numStudents} students and {_numTeachers} teachers.");

        foreach (Student student in _students)
        {
            Console.WriteLine($"Student ID: {student._id} Name: {student._name}");
        }
    }
}