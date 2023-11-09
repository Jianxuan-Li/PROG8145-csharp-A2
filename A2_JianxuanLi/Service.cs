using System.Collections.Generic;

namespace A2_JianxuanLi
{
    /*
     all services:
     
     Cleaning
     CavityFill
     CheckUp
     XRay
     BracesFitted // for children
     VeneersFitted // for adult
     Dentures // for senior
     */

    public abstract class ServiceAbstract
    {
        public abstract List<string> GetChildrenServices();
        public abstract List<string> GetAdultServices();
        public abstract List<string> GetSeniorServices();
    }

    public class Service : ServiceAbstract
    {
        private List<string> Names = new List<string>();

        public Service()
        {
            // common service
            Names.Add("Cleaning");
            Names.Add("Cavity Fill");
            Names.Add("Check Up");
            Names.Add("XRay");
        }

        public override List<string> GetChildrenServices()
        {
            List<string> CommonNames = new List<string>(Names);
            CommonNames.Add("Braces Fitted");
            return CommonNames;
        }

        public override List<string> GetAdultServices()
        {
            List<string> CommonNames = new List<string>(Names);
            CommonNames.Add("Veneers Fitted");
            return CommonNames;
        }

        public override List<string> GetSeniorServices()
        {
            List<string> CommonNames = new List<string>(Names);
            CommonNames.Add("Dentures");
            return CommonNames;
        }
    }
}