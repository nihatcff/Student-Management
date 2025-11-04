using StudentManagement;

Student[] students = [];

Console.WriteLine("Xos gelmisiniz!");

repeat:
Console.WriteLine("1. Yeni telebe elave et.");
Console.WriteLine("2. Telebeye qiymet elave et.");
Console.WriteLine("3. Butun telebelerin siyahisi");
Console.WriteLine("4. Çıxış");
    
Console.Write("Seciminiz: ");
string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.Write("Ad: ");
        string name = Console.ReadLine();
        Console.Write("Soyad: ");
        string surname = Console.ReadLine();

        Student student = new Student()
        {
            ID = students.Length + 1,
            Name = name,
            Surname = surname,
            Grades = []
        };

        Array.Resize(ref students, students.Length + 1);
        students[students.Length - 1] = student;
        Console.WriteLine("Telebe elave olundu.");
        break;


    case "2":

        Console.Write("Qiymet elave edilecek telebenin ID'si: ");
        int gradeId = Convert.ToInt32(Console.ReadLine());

        Student check = null;

        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].ID == gradeId)
            {
                check = students[i];
                break;
            }
        }

        if (check == null)
        {
            Console.WriteLine("Bu ID'e sahib telebe yoxdur!");
        }
        else
        {
            Console.Write("Elave edilecek qiymet: ");
            int addGrade = Convert.ToInt32(Console.ReadLine());

            int[] grades = check.Grades;
            Array.Resize(ref grades, grades.Length + 1);
            grades[grades.Length - 1] = addGrade;
            check.Grades = grades;

            Console.WriteLine("Qiymet elave olundu.");
        }
        break;


    case "3":

        if (students.Length == 0)
        {
            Console.WriteLine("Telebe hal hazirda yoxdur!");
        }
        else
        {
            Console.WriteLine("Telebeler siyahisi: ");
            for (int i = 0; i < students.Length; i++)
            {
                students[i].ShowInfo();
            }
        }
        break;

    case "4":
        Console.WriteLine("Cixis etdiniz..");
        return;

    default:
        Console.WriteLine("Bele secim movcud deil!");
        break;
}
Console.WriteLine("");
Console.WriteLine("Devam etmek isteyirsen?Y/N: ");


while (true)
{
    string devam = Console.ReadLine();

    if (devam == "Y")
    {
        goto repeat;
    }
    else if (devam == "N")
    {
        Console.WriteLine("Cixis etdiniz..");
        return;
    }
    else
    {
        Console.WriteLine("Yanlis secim etdiniz. Y/N daxil edin: ");
        continue;
    }
}
