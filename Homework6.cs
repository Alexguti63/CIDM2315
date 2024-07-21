namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        foreach(Student stu in Student.student_list){
            stu.PrintInfo();
        }
        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);
        if (!gradebook.ContainsKey("Tom")){
            gradebook.Add("Tom", 3.3);
        }
        double total = 0;
        foreach (double gpa in gradebook.Values){
            total += gpa;
        }
        double average = total / gradebook.Count;
        Console.WriteLine($"\nAverage GPA: {average}");
        foreach(KeyValuePair<string, double> entry in gradebook){
            if (entry.Value > average){
                //I needed help with this part and I used cs50.ai.
                if(Student.student_list.Exists(s=> s.GetStudentName()==entry.Key)){
                    Student student = Student.student_list.Find(s => s.GetStudentName() == entry.Key);
                    student.PrintInfo();
                }
            }
        }
    }
}

class Student{
    public static List<Student> student_list = new List<Student>();
    private int studentID;
    public int _studentId{
        get{return studentID;}
        set{studentID = value;}
    }
    private string studentName;
    public string GetStudentName(){
        return studentName;
    }
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {_studentId}, Student Name: {studentName}");
    }
    public Student(int inputId, string inputName){
        studentID = inputId;
        studentName = inputName;
        student_list.Add(this);
    }
}
