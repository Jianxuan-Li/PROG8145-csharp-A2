using System.Collections.Generic;

namespace A2_JianxuanLi
{
    /*
     * The code of data is too long, store the data here
     */
    public class StaticData
    {
        // return a 10-persons list here
        public static List<Person> initPerson()
        {
            List<Person> persons = new List<Person>();
            
            Person p1 = new Person()
            {
                FirstName = "Eric", 
                LastName = "Markasy", 
                Age = 15, 
                Gender = "Male", 
                PatientNumber = 1231231230
            };
            persons.Add(p1);
            
            Person p2 = new Person()
            {
                FirstName = "Jason", 
                LastName = "Biden", 
                Age = 17, 
                Gender = "Male", 
                PatientNumber = 1231231231
            };
            persons.Add(p2);
            
            Person p3 = new Person()
            {
                FirstName = "Mocaca", 
                LastName = "Balskon", 
                Age = 16, 
                Gender = "Female", 
                PatientNumber = 1231231232
            };
            persons.Add(p3);
            
            Person p4 = new Person()
            {
                FirstName = "Deekurma", 
                LastName = "Kugua", 
                Age = 30, 
                Gender = "Female", 
                PatientNumber = 1231231233
            };
            persons.Add(p4);
            
            Person p5 = new Person()
            {
                FirstName = "Puma", 
                LastName = "Ueyga", 
                Age = 26, 
                Gender = "Female", 
                PatientNumber = 1231231234
            };
            persons.Add(p5);
            
            Person p6 = new Person()
            {
                FirstName = "Wasaka", 
                LastName = "Kernit", 
                Age = 45, 
                Gender = "Female", 
                PatientNumber = 1231231235
            };
            persons.Add(p6);
            
            Person p7 = new Person()
            {
                FirstName = "Guguglaka", 
                LastName = "Memeka", 
                Age = 42, 
                Gender = "Male", 
                PatientNumber = 1231231236
            };
            persons.Add(p7);
            
            Person p8 = new Person()
            {
                FirstName = "Elon", 
                LastName = "Weber", 
                Age = 70, 
                Gender = "Male", 
                PatientNumber = 1231231237
            };
            persons.Add(p8);
            
            Person p9 = new Person()
            {
                FirstName = "Husky", 
                LastName = "Papa", 
                Age = 80, 
                Gender = "Male", 
                PatientNumber = 1231231238
            };
            persons.Add(p9);
            
            Person p0 = new Person()
            {
                FirstName = "Marsuka", 
                LastName = "Honda", 
                Age = 90, 
                Gender = "Female", 
                PatientNumber = 1231231239
            };
            persons.Add(p0);
            
            return persons;
        }
    }
}