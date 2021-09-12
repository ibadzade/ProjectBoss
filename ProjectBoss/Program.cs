using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_Project
{
    interface IHuman
    {
        string Name { get; set; }
        string Surname { get; set; }
        string City { get; set; }
        string PhoneNumber { get; set; }
        int Id { get; set; }
        int Age { get; set; }
    }
    class Program
    {
        /*static void Sides(int ch)
        {
            if (ch == 1)
            {

            }
        }*/
        static void Main(string[] args)
        {
            Employee emply1 = new Employee
            {
                Name = "IDK",
                Surname = "IDKyev",
                Age = 10,
                City = "Lenkaran",
                Id = 1999,
                PhoneNumber = "904779960",
            };
            Employer emplyr1 = new Employer
            {
                Name = "Elxan",
                Surname = "Atayev",
                Age = 22,
                City = "Baku",
                Id = 12,
                PhoneNumber = "055 751 08 88",
                Vacancies = new Vacancy
                {
                    MaxSalary = 2000,
                    MinSalary = 1500,
                    RequiredDegree = "High",
                    Category = "Programmer",
                    Experience = "More than 3 years"
                }
            };

            User us = new User { };
            us.SignIn();


            Console.WriteLine("\nAre You Employee Or Empoyer?\n1)Employee\n2)Employer");
            int choose = int.Parse(Console.ReadLine());

            Console.Clear();

            if (choose == 1)
            {
                Console.WriteLine("1)Add CV \n2)Edit CV \n3)Show Your Character and CV \n4)Show All Vacancies\n5)Back");
                int chooseAction = int.Parse(Console.ReadLine());

                if (chooseAction == 1)
                {
                    emply1.AddCv();
                    Console.WriteLine("Do you want to go back?\n1)yes\n2)no");
                    int chooseAction1 = int.Parse(Console.ReadLine());
                    if (chooseAction1 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("1)Add CV \n2)Edit CV \n3)Show Your Character and CV \n4)Show All Vacancies");
                        int chooseAction2 = int.Parse(Console.ReadLine());
                        if (chooseAction2 == 1)
                        {
                            emply1.AddCv();
                        }
                        else if (chooseAction2 == 2)
                        {
                            emply1.EditCv();

                        }
                        else if (chooseAction2 == 3)
                        {
                            Console.WriteLine(emply1);
                        }
                        else if (chooseAction2 == 4)
                        {
                            emply1.Show_All_Vacancies();
                        }
                    }

                }
                else if (chooseAction == 2)
                {
                    emply1.EditCv();
                    Console.WriteLine("Do you want to go back?\n1)yes\n2)no");
                    int chooseAction1 = int.Parse(Console.ReadLine());
                    if (chooseAction1 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("1)Add CV \n2)Edit CV \n3)Show Your Character and CV \n4)Show All Vacancies");
                        int chooseAction2 = int.Parse(Console.ReadLine());
                        if (chooseAction2 == 1)
                        {
                            emply1.AddCv();
                        }
                        else if (chooseAction2 == 2)
                        {
                            emply1.EditCv();

                        }
                        else if (chooseAction2 == 3)
                        {
                            Console.WriteLine(emply1);
                        }
                        else if (chooseAction2 == 4)
                        {
                            emply1.Show_All_Vacancies();
                        }
                    }
                }
                else if (chooseAction == 3)
                {
                    Console.WriteLine(emply1);
                    Console.WriteLine("Do you want to go back?\n1)yes\n2)no");
                    int chooseAction1 = int.Parse(Console.ReadLine());
                    if (chooseAction1 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("1)Add CV \n2)Edit CV \n3)Show Your Character and CV \n4)Show All Vacancies");
                        int chooseAction2 = int.Parse(Console.ReadLine());
                        if (chooseAction2 == 1)
                        {
                            emply1.AddCv();
                        }
                        else if (chooseAction2 == 2)
                        {
                            emply1.EditCv();

                        }
                        else if (chooseAction2 == 3)
                        {
                            Console.WriteLine(emply1);
                        }
                        else if (chooseAction2 == 4)
                        {
                            emply1.Show_All_Vacancies();
                        }
                    }
                }
                else if (chooseAction == 4)
                {
                    emply1.Show_All_Vacancies();
                    Console.WriteLine("Do you want to go back?\n1)yes\n2)no");
                    int chooseAction1 = int.Parse(Console.ReadLine());
                    if (chooseAction1 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("1)Add CV \n2)Edit CV \n3)Show Your Character and CV \n4)Show All Vacancies");
                        int chooseAction2 = int.Parse(Console.ReadLine());
                        if (chooseAction2 == 1)
                        {
                            emply1.AddCv();
                        }
                        else if (chooseAction2 == 2)
                        {
                            emply1.EditCv();

                        }
                        else if (chooseAction2 == 3)
                        {
                            Console.WriteLine(emply1);
                        }
                        else if (chooseAction2 == 4)
                        {
                            emply1.Show_All_Vacancies();
                        }
                    }
                }
                else if (chooseAction == 5)
                {
                    Console.Clear();
                    Console.WriteLine("\nAre You Employee Or Empoyer?\n1)Employee\n2)Employer");
                    int choose1 = int.Parse(Console.ReadLine());
                }

            }
            else if (choose == 2)
            {
                Console.WriteLine("1)See All CV\n2)Add Vacancy\n3)Edit Vacancy");
                int chooseEmplyr1m = int.Parse(Console.ReadLine());
                if (chooseEmplyr1m == 1)
                {
                    emplyr1.Show_All_CV();
                    Console.WriteLine("Do you want to go back?\n1)yes\n2)no");
                    int chooseforback1 = int.Parse(Console.ReadLine());
                    if (chooseforback1 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("1)See All CV\n2)Add Vacancy\n3)Edit Vacancy");
                        int chooseEmplyr2 = int.Parse(Console.ReadLine());
                        if (chooseEmplyr2 == 1)
                        {
                            emplyr1.Show_All_CV();
                        }
                        else if (chooseEmplyr2 == 2)
                        {
                            emplyr1.Add_Vacancy();
                        }
                        else if (chooseEmplyr2 == 3)
                        {
                            emplyr1.Edit_Vacancy();
                        }
                    }
                }
                else if (chooseEmplyr1m == 2)
                {
                    emplyr1.Add_Vacancy();
                    Console.WriteLine("Do you want to go back?\n1)yes\n2)no");
                    int chooseforback2 = int.Parse(Console.ReadLine());
                    if (chooseforback2 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("1)See All CV\n2)Add Vacancy\n3)Edit Vacancy");
                        int chooseEmplyr2 = int.Parse(Console.ReadLine());
                        if (chooseEmplyr2 == 1)
                        {
                            emplyr1.Show_All_CV();
                        }
                        else if (chooseEmplyr2 == 2)
                        {
                            emplyr1.Add_Vacancy();
                        }
                        else if (chooseEmplyr2 == 3)
                        {
                            emplyr1.Edit_Vacancy();
                        }
                    }
                }
                else if (chooseEmplyr1m == 3)
                {
                    emplyr1.Edit_Vacancy();
                    Console.WriteLine("Do you want to go back?\n1)yes\n2)no");
                    int chooseforback3 = int.Parse(Console.ReadLine());
                    if (chooseforback3 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("1)See All CV\n2)Add Vacancy\n3)Edit Vacancy");
                        int chooseEmplyr2 = int.Parse(Console.ReadLine());
                        if (chooseEmplyr2 == 1)
                        {
                            emplyr1.Show_All_CV();
                        }
                        else if (chooseEmplyr2 == 2)
                        {
                            emplyr1.Add_Vacancy();
                        }
                        else if (chooseEmplyr2 == 3)
                        {
                            emplyr1.Edit_Vacancy();
                        }
                    }
                }
            }
        }
    }
}
