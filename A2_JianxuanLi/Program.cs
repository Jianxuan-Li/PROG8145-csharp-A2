/*
Full Name : Jianxuan Li
Student # : 8807952
Section : 2
Date : 6/23/2022
Description : Assignment 2
*/
using System;
using System.Collections.Generic;

namespace A2_JianxuanLi
{
    internal class Program
    {
        static List<Person> Persons = StaticData.initPerson();

        public static string hidePatientNumber(string number)
        {
            char[] s = number.ToCharArray();
            string newNumber = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (i < 3)
                {
                    newNumber += "X";
                }
                else
                {
                    newNumber += s[i].ToString();
                }
            }

            return newNumber;
        }
        // option 1
        public static void ShowPersons()
        {
            // show persons list
            
            int index = 1;
            foreach (var person in Persons)
            {
                Console.WriteLine(Convert.ToString(index) + ". " + person.FirstName + " " + person.LastName + " - " + person.Gender + " - " + Convert.ToString(person.Age) + " - " + hidePatientNumber(Convert.ToString(person.PatientNumber)));
                index += 1;
            }
        }
        
        public static void Main(string[] args)
        {
            // save persons who are already in scheduled
            AppointmentList apList = new AppointmentList();
            
            // start user input
            while (true)
            {
                int option = ConsoleInput.InputOption(apList);

                if (option == 1)
                {
                    // persons list
                    Console.Clear();
                    ShowPersons();
                    ConsoleOutput.Alert("Press any key to return to menu: ");
                    Console.ReadKey();
                }else if (option == 2)
                {
                    // create a schedule
                    Console.Clear();
                    while (true)
                    {
                        // if no seat
                        if (apList.GetCount() >= 8)
                        {
                            break;
                        }
                        
                        // collect person id
                        int personId = ConsoleInput.InputPersonId(apList);
                        if (personId == -1)
                        {
                            // back to menu
                            break;
                        }

                        // collect service name
                        string ServiceName = ConsoleInput.InputServiceName(Persons[personId]);

                        // save to appointment list
                        Appointment app = new Appointment();
                        app.person = Persons[personId];
                        app.service = ServiceName;
                        
                        apList.Add(app);
                    }
                }else if (option == 3)
                {
                    // show schedule
                    Console.Clear();
                    int index = 1;
                    foreach (var app in apList.Get())
                    {
                        DateTime dateA = DateTime.Now;
                        DateTime dateB = new DateTime(dateA.Year, dateA.Month, dateA.Day, index +7, 0, 0);

                        ConsoleOutput.Alert("Schedule " + Convert.ToString(index) + ". " 
                                            + " Datetime: " + dateB.ToString()
                                            + " Name: " + app.person.FirstName + " " + app.person.LastName 
                                            + " Service:" + app.service);
                        index += 1;
                    }
                    ConsoleOutput.Alert("Press any key to return to menu: ");
                    Console.ReadKey();
                }else if(option == 4)
                {
                    // exit
                    break;
                }
            }
        }
    }
}