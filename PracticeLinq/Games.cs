using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLinq
{
    public class Games
    {
        public Games()
        {

        }
        public Games(string name, int date, string company)
        {
            Name = name;
            Date = date;
            Company = company;
        }
        public string Name { get; set; }
        public int Date { get; set; }
        public string Company { get; set; }
    }
}
