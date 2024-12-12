using System;
using System.Collections.Generic;

class Student
{
    // Klass för att representera en student
    public string Name { get; set; }
    public int Grade { get; set; }

    // Konstruktor för att skapa en ny student med namn och betyg
    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }
}

class Program
{
    // Lista för att hålla alla studenter
    static List<Student> students = new List<Student>();

    // Metod för att lägga till en ny student till listan
    static void AddStudent(string name, int grade)
    {
        students.Add(new Student(name, grade)); // Lägg till en ny student i listan
    }

    // Metod för att sortera studenter baserat på deras betyg (högsta först)
    static void BubbleSort()
    {
        int n = students.Count; // Antal studenter i listan

        // Loopar genom listan flera gånger för att sortera
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                // Byter plats på två studenter om den första har lägre betyg
                if (students[j].Grade < students[j + 1].Grade)
                {
                    Student temp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = temp;
                }
            }
        }
    }

    // Metod för att visa alla studenter i listan
    static void DisplayStudents()
    {
    
        // Skriver ut varje students namn och betyg
        Console.WriteLine("Studentlista:");
        foreach (Student student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade} poäng");
        }
    }

    static void Main()
    {
        // Fråga användaren hur många studenter de vill lägga till
        Console.WriteLine("Hur många studenter vill du lägga till?");
        int numberOfStudents = int.Parse(Console.ReadLine()); 

        // Loop för att lägga till varje student
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"\nStudent {i + 1}:");

            // Fråga efter studentens namn
            Console.Write("Ange studentens namn: ");
            string name = Console.ReadLine();

            // Fråga efter studentens betyg
            Console.Write("Ange studentens betyg (poäng): ");
            int grade = int.Parse(Console.ReadLine()); 

            // Lägg till studenten i listan
            AddStudent(name, grade);
        }

        // Visa listan innan sortering
        Console.WriteLine("\nInnan sortering:");
        DisplayStudents();

        // Sortera listan efter betyg
        BubbleSort();

        // Visa listan efter sortering
        Console.WriteLine("\nEfter sortering:");
        DisplayStudents();

        // Vänta på att användaren trycker på en tangent innan programmet avslutas
        Console.WriteLine("\nProgrammet är klart. Tryck på valfri tangent för att avsluta.");
        Console.ReadKey(); 
    }
}

// Tidigare avslutades programmet direkt efter att det visade resultaten, och användaren hann inte se vad som hände. 
// Detta berodde på att programmet kördes som en konsolapplikation, och efter att Main()-metoden var klar, stängdes fönstret automatiskt.

// Jag lade till Console.ReadKey() i slutet av programmet för att vänta på att användaren trycker på en tangent innan det stängs. 
// Detta gör att användaren kan läsa resultaten och förstå vad programmet gjorde innan det avslutas.
