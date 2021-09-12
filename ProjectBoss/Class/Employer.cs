using System;
using System.Collections.Generic;

namespace Boss_Project
{
    public class Employer : IHuman
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public Vacancy Vacancies { get; set; }
        public void Show_All_CV()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Name = "Alabama",
                    Surname = "Barack",
                    Age = 34,
                    City = "Vashington",
                    PhoneNumber = "+1234567899",
                    Id = 1,

                    Cvs = new CV
                    {
                         Degree = "High",
                            Profession = "Programmer",
                            Language = "English,,Russian and Azerbaijan",
                            Language_Level = "C1",
                            Skills = "I can write in C# , C/C++ , Java , Phyton languages . I was Designer for a year",
                            University = "Computer Engineering University of Milan",
                            CVId = 1
                    }
                },
                new Employee
                {
                    Name = "Bertram",
                    Surname = "Kopp",
                    Age = 31,
                    City = "Berlin",
                    Id = 2,
                    PhoneNumber = "+994 55 788 76 76",

                    Cvs = new CV
                    {
                        Degree = "Science Degree",
                            CVId = 2,
                            Language = "German,Italian,Azerbaijan and Turkish",
                            Language_Level = "B2 and C1",
                            Profession = "Designer",
                            Skills = "I can work on Photoshop , Paint and Krita . I was an artist for 3 years",
                            University = "Design and Art University of Berlin"
                        }
                },
                new Employee
                {
                    Name = "Toyama",
                    Surname="Fujiwara",
                    City = "Tokio",
                    Age = 28,
                    Id = 3,
                    PhoneNumber = "+87476890095",
                    Cvs = new CV{
                    Degree = "Income High",
                            Language = "Azerbaijani,Japanesse,Russian and English",
                            Language_Level = "C1 and C2",
                            Profession = "Translate",
                            Skills = "Nothing Special",
                            University = "University of Baku",
                            CVId = 3
                    }

                },
                new Employee
                {
                    Name = "Ali",
                    Surname = "Shixiyev",
                    Age = 40,
                    City = "Sumqayit",
                    Id = 4,
                    PhoneNumber = "+994 77 899 88 89",
                    Cvs = new CV
                    {
                        Degree = "High",
                            Language = "Azerbaijan , Russian and English",
                            Language_Level = "B2 and C1",
                            Profession = "Electrics Engineer",
                            Skills = "I am freelance programmer , I know HTML , CSS , Java , JavaScript , C#",
                            University = "Engineering University of Baku",
                            CVId = 4
                    }
                }
            };

            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }


        public void Add_Vacancy()
        {
            Console.WriteLine("Minimum Salary : ");
            int minsalary = int.Parse(Console.ReadLine());

            Console.WriteLine("Maximum Salary : ");
            int maxsalary = int.Parse(Console.ReadLine());

            Console.WriteLine("Required Degree : ");
            string requiredDegree = Console.ReadLine();

            Console.WriteLine("Expeience : ");
            string experince = Console.ReadLine();

            Console.WriteLine("Category : ");
            string category = Console.ReadLine();

            Vacancy vacancy = new Vacancy
            {
                RequiredDegree = requiredDegree,
                Category = category,
                Experience = experince,
                MinSalary = minsalary,
                MaxSalary = maxsalary
            };
            Vacancies = vacancy;
        }

        public void Edit_Vacancy()
        {
            Console.WriteLine("Minimum Salary : ");
            int minsalary = int.Parse(Console.ReadLine());

            Console.WriteLine("Maximum Salary : ");
            int maxsalary = int.Parse(Console.ReadLine());

            Console.WriteLine("Required Degree : ");
            string requiredDegree = Console.ReadLine();

            Console.WriteLine("Expeience : ");
            string experince = Console.ReadLine();

            Console.WriteLine("Category : ");
            string category = Console.ReadLine();

            Vacancy edited_vacancy = new Vacancy
            {
                RequiredDegree = requiredDegree,
                Category = category,
                Experience = experince,
                MinSalary = minsalary,
                MaxSalary = maxsalary
            };
            Vacancies = edited_vacancy;
        }
        public override string ToString()
        {
            return $"Name : {Name}\nSurname : {Surname}\nCity : {City}\nAge : {Age}\nPhone Number : {PhoneNumber}\nID : {Id}\nVacancies {Vacancies}";
        }
    }
}
