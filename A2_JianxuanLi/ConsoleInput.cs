using System;
using System.Collections.Generic;
using System.Linq;

namespace A2_JianxuanLi
{
    public class ConsoleInput
    {
        // Main menu options
        public static int InputOption(AppointmentList apList)
        {
            Console.Clear();
            ConsoleOutput.Alert("Menu:");
            ConsoleOutput.Alert("1. List all persons");
            if (apList.GetCount() >= 8)
            {
                ConsoleOutput.Alert("2. Create a schedule (no more seat)");
            }
            else
            {
                ConsoleOutput.Alert("2. Create a schedule");
            }
            ConsoleOutput.Alert("3. Display the day's schedule");
            ConsoleOutput.Alert("4. Exit");
            ConsoleOutput.Alert("Please select from 1-4: ", true);
            string opt = Console.ReadLine();
            try
            {
                int option = Convert.ToInt16(opt);
                if (option >= 1 && option <= 4)
                {
                    return option;
                }
                return InputOption(apList);
            }
            catch (Exception e)
            {
                // retry when the user input is invalied
                return InputOption(apList);
            }
        }
        
        // let user input person id to make schedule
        public static int InputPersonId(AppointmentList apList)
        {
            ConsoleOutput.Alert("Create a new schedule ", true);
            ConsoleOutput.Alert("Please select a person from 1-10, or 0 to go back to menu: ", true);
            string input = Console.ReadLine();
            try
            {
                int id = Convert.ToInt16(input);
                id -= 1; // set to an index value of the persons list

                if (id == -1)
                {
                    // return to menu
                    return -1;
                }
                
                // check the id
                if (id < -1 || id > 9)
                {
                    return InputPersonId(apList);
                }

                if (apList.CheckExists(id))
                {
                    ConsoleOutput.Alert("This person already have schedule, please select another.");
                    return InputPersonId(apList);
                }
                
                return id; // otherwise, return to menu
            }
            catch (Exception e)
            {
                // retry when the user input is invalied
                return InputPersonId(apList);
            }
        }

        // get service name by user input id
        public static string InputServiceName(Person p)
        {
            ConsoleOutput.Alert("Please select a Service from this list: ");
            List<string> services;
            Service svc = new Service();
            if (p.Age < 19)
            {
                services = svc.GetChildrenServices();
            } else if (p.Age > 18 && p.Age < 65) {
                services = svc.GetAdultServices();
            } else {
                services = svc.GetSeniorServices();
            }

            for (int i = 0; i < services.Count; i++)
            {
                ConsoleOutput.Alert(Convert.ToString(i + 1) + ". " + services[i]);
            }
            
            ConsoleOutput.Alert("Please select a service from 1-" + Convert.ToString(services.Count) + ", or 0 to go back to menu: ", true);
            string input = Console.ReadLine();
            try
            {
                int index = Convert.ToInt16(input);
                
                // check the id
                if (index < 1 || index > services.Count)
                {
                    return InputServiceName(p);
                }

                return services[index - 1];
            }
            catch (Exception e)
            {
                // retry when the user input is invalied
                return InputServiceName(p);
            }
        }
    }
}