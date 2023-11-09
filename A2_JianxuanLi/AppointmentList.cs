using System.Collections.Generic;

namespace A2_JianxuanLi
{
    public class AppointmentList
    {
        private List<Appointment> _appointments = new List<Appointment>();

        // add an appointment
        public void Add(Appointment app)
        {
            _appointments.Add(app);
        }

        // get this list
        public List<Appointment> Get()
        {
            return _appointments;
        }

        // get the count of this list
        public int GetCount()
        {
            return _appointments.Count;
        }

        // check does this list have an appointment
        public bool CheckExists(int id)
        {
            List<Person> persons = StaticData.initPerson();
            foreach (var app in _appointments)
            {
                if (app.person.PatientNumber == persons[id].PatientNumber)
                {
                    return true;
                } 
            }

            return false;
        }
    }
}