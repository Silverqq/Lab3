using System;

struct Student
{
    public string Name;
    public string Group;
    public int[] Grades;

    public double AverageGrade
    {
        get
        {
            double sum = 0;
            foreach (int grade in Grades)
            {
                sum += grade;
            }
            return sum / Grades.Length;
        }
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[7];

        // Инициализация объектов
        students[0] = new Student { Name = "Прокофьев И.Г.", Group = "Группа1", Grades = new int[] { 4, 5, 4, 3, 5 } };
        students[1] = new Student { Name = "Кондратьев П.Н.", Group = "Группа1", Grades = new int[] { 3, 4, 4, 5, 5 } };
        students[2] = new Student { Name = "Шорников С.Л.", Group = "Группа2", Grades = new int[] { 5, 5, 4, 4, 5 } };
        students[3] = new Student { Name = "Селиверстова К.Д.", Group = "Группа2", Grades = new int[] { 3, 4, 3, 4, 4 } };
        students[4] = new Student { Name = "Синельников М.М.", Group = "Группа1", Grades = new int[] { 5, 5, 5, 5, 5 } };
        students[5] = new Student { Name = "Алексеева А.С.", Group = "Группа2", Grades = new int[] { 4, 4, 3, 4, 3 } };
        students[6] = new Student { Name = "Завьялов Б.К.", Group = "Группа1", Grades = new int[] { 4, 3, 4, 4, 3 } };

        // Сортировка массива по среднему баллу
        Array.Sort(students, (s1, s2) => s1.AverageGrade.CompareTo(s2.AverageGrade));

        // Вывод упорядоченного списка студентов
        Console.WriteLine("Студенты, упорядоченные по возрастанию среднего балла:");
        foreach (Student student in students)
        {
            Console.WriteLine($"Студент: {student.Name}, Группа: {student.Group}, Средний балл: {student.AverageGrade:F2}");
        }
    }
}