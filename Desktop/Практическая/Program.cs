using System;

class Student
{
    private string name;
    private int age;
    private double averageGrade;
    private string group;
    private int course;

    public Student(string name, int age, double averageGrade)
    {
        this.name = name;
        this.age = age;
        this.averageGrade = averageGrade;
        this.group = "Не указана";
        this.course = 1;
    }

    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public double GetAverageGrade()
    {
        return averageGrade;
    }

    public string GetGroup()
    {
        return group;
    }

    public int GetCourse()
    {
        return course;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public void SetAverageGrade(double averageGrade)
    {
        this.averageGrade = averageGrade;
    }

    public void SetGroup(string group)
    {
        this.group = group;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Средний балл: {averageGrade}");
        Console.WriteLine($"Группа: {group}");
        Console.WriteLine($"Курс: {course}");
    }

    public string GetPerformance()
    {
        if (averageGrade > 8)
            return "Отлично";
        else if (averageGrade >= 6)
            return "Хорошо";
        else if (averageGrade >= 4)
            return "Удовлетворительно";
        else
            return "Неудовлетворительно";
    }


    public bool IsExcellentStudent()
    {
        return averageGrade >= 9;
    }


    public void IncreaseGrade(double points)
    {
        averageGrade += points;

        if (averageGrade > 10)
            averageGrade = 10;
    }


    public void DecreaseGrade(double points)
    {
        averageGrade -= points;

        if (averageGrade < 0)
            averageGrade = 0;
    }


    public void NextCourse()
    {
        if (course < 4)
            course++;
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("Иван", 19, 9.2);
        Student student2 = new Student("Мария", 20, 7.5);
        Student student3 = new Student("Алексей", 18, 5.8);

        student1.SetGroup("ПИ-101");
        student2.SetGroup("ПИ-102");
        student3.SetGroup("ПИ-103");


        student2.IncreaseGrade(0.5);
        student3.DecreaseGrade(0.8);
        student1.NextCourse();

        Student[] students = { student1, student2, student3 };

        foreach (Student student in students)
        {
            student.ShowInfo();
            Console.WriteLine("Успеваемость: " + student.GetPerformance());
            Console.WriteLine("Отличник: " + (student.IsExcellentStudent() ? "Да" : "Нет"));
            Console.WriteLine(new string('-', 30));
        }
    }
}