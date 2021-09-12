using System;
using System.Collections.Generic;

namespace Boss_Project
{
    public class Employee : IHuman
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public CV Cvs { get; set; }

        public void AddCv()
        {
            Console.WriteLine("Degree : ");//ali,orta ve s.
            string degree = Console.ReadLine();

            Console.WriteLine("Skills : ");
            string skills = Console.ReadLine();

            Console.WriteLine("Profession");
            string prof = Console.ReadLine();

            Console.WriteLine("Languages : ");
            string languages = Console.ReadLine();

            Console.WriteLine("Levels of Languages : ");
            string levoflang = Console.ReadLine();

            Console.WriteLine("University : ");
            string univer = Console.ReadLine();

            Console.WriteLine("ID : ");//cv nin id si
            int cvid = int.Parse(Console.ReadLine());


            CV cv = new CV
            {
                Degree = degree,
                Language = languages,
                CVId = cvid,
                Language_Level = levoflang,
                Profession = prof,
                Skills = skills,
                University = univer
            };

            Cvs = cv;
        }

        public void EditCv()
        {
            Console.WriteLine("Degree : ");
            string degree = Console.ReadLine();

            Console.WriteLine("Skills : ");
            string skills = Console.ReadLine();

            Console.WriteLine("Profession");
            string prof = Console.ReadLine();

            Console.WriteLine("Languages : ");
            string languages = Console.ReadLine();

            Console.WriteLine("Levels of Languages : ");
            string levoflang = Console.ReadLine();

            Console.WriteLine("University : ");
            string univer = Console.ReadLine();

            Console.WriteLine("ID : ");//cv nin id si
            int cvid = int.Parse(Console.ReadLine());

            CV cv_edited = new CV
            {
                Degree = degree,
                Language = languages,
                CVId = cvid,
                Language_Level = levoflang,
                Profession = prof,
                Skills = skills,
                University = univer
            };
            Cvs = cv_edited;
        }

        public void Show_All_Vacancies()
        {
            List<Employer> employers = new List<Employer>
            {
                new Employer
                {
                    Name = "Orxan",
                    Surname = "Atayev",
                    Age = 20,
                    City = "Baku",
                    Id = 10,
                    PhoneNumber = "093 8923 83 13",
                    Vacancies = new Vacancy
                    {
                        Category = "Gamer",
                        Experience = "Less than 1 year",
                        MinSalary = 1000,
                        MaxSalary = 2000,
                        RequiredDegree = "Middle"
                    }
                },
                new Employer
                {
                    Name = "Kamran",
                    Surname = "Mirzeliyev",
                    Age = 21,
                    City = "Lenkaran",
                    Id = 11,
                    PhoneNumber = "+994 55 999 99 99",
                    Vacancies = new Vacancy
                    {
                        Category = "Farmer",
                        Experience = "from 1 year to 3 years",
                        RequiredDegree = "Middle",
                        MinSalary = 550,
                        MaxSalary = 950
                    }
                },
                new Employer
                {
                    Name = "Nihad",
                    Surname="Sovetsky",
                    City="Baku",
                    Age = 19,
                    PhoneNumber = "+944 54 459 98 89",
                    Id = 12,
                    Vacancies = new Vacancy
                    {
                        Category = "Teacher",
                        RequiredDegree = "Science Degree",
                        Experience = "Less than 1 year",
                        MinSalary = 1200,
                        MaxSalary = 1800
                    }
                },
                new Employer
                {
                    Name = "Ramiz",
                    Surname = "Nazimli",
                    City = "Naxcivan",
                    Age = 16,
                    Id = 13,
                    PhoneNumber = "+994 04 722 73 45",
                    Vacancies = new Vacancy
                    {
                        Category = "Programmer",
                        RequiredDegree = "High",
                        Experience = "More than 3 years",
                        MinSalary = 1200,
                        MaxSalary = 2000
                    }
                },
                new Employer
                {
                    Name = "Tuncay",
                    Surname = "Mehtiyev",
                    Age=20,
                    City = "Xankendi",
                    Id = 14,
                    PhoneNumber = "+994 56 326 76 75",
                    Vacancies = new Vacancy
                    {
                        Category = "Doctor",
                        RequiredDegree = "Income High",
                        Experience = "from 1 to 3 years",
                        MinSalary = 1000,
                        MaxSalary = 3200,

                    }
                }
            };

            foreach (var item in employers)
            {
                Console.WriteLine(item);
            }
        }

        public override string ToString()
        {
            return $"Name : {Name}\nSurname : {Surname}\nAge : {Age}\nCity : {City}\nPhone Number : {PhoneNumber}\nID : {Id}\nCV : {Cvs}\n";
        }
    }
}
