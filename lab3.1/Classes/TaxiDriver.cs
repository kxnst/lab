using System;
using System.Collections.Generic;
using System.Text;

namespace lab3._1.Classes
{
    class TaxiDriver : Human, IStudy, IDrive
    {
        public TaxiDriver(string fname, string sname) : base(fname, sname)
        {

        }

        public void Drive()
        {
            View.View.GenerateMessage($"{FirstName} {LastName} drives");
        }

        public void Study()
        {
            View.View.GenerateMessage($"{FirstName} {LastName} studies");
        }
        public override string ToString()
        {
            return $"TaxiDriver {FirstName}{LastName}{{" +
                $"'fname':'{FirstName}', 'sname':'{LastName}'}}";
        }
    }
}
