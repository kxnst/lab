using System;
using System.Collections.Generic;
using System.Text;

namespace lab3._1.Classes
{
    class Teacher : Human, IStudy, ITeach
    {
        public Teacher(string fname, string sname) : base(fname, sname)
        {

        }
        public void Teach()
        {
            View.View.GenerateMessage($"{FirstName} {LastName} teaches");
        }

        public void Study()
        {
            View.View.GenerateMessage($"{FirstName} {LastName} studies");
        }
        public override string ToString()
        {
            return @$"Teacher {FirstName}{LastName}{{'fname':'{FirstName}', 'sname':'{LastName}'}}";
        }
    }
}
