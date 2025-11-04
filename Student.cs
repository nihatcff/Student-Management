namespace StudentManagement;
public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int[] Grades { get; set; }


    public Student(int id, string name, string surname) //Student obyekti yarananda bu melumatlar daxil edilsin
    {
        ID = id;
        Name = name;
        Surname = surname;
        Grades = [];
    }

    public Student()
    {
    }

    public void ShowInfo() //Melumatlari gosteren method
    {
        Console.WriteLine($"Ad: {Name}, Soyad: {Surname}, Ortalama: {GetAverage(Grades)}");
    }
    public double GetAverage(int[] grades) //Umumi qiymet ortalamasi ucun method
    {
        int sum = default;
        foreach (int grade in grades)
        {
            sum += grade;
        }
        double average = sum / grades.Length;
        return average;
    }

}






