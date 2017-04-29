using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConnectDBIP
{
    public class Test
    {
        public int Id{get;set;}
        public string Name { get; set; }
        public string Sex { set; get; }
        public int Age{get;set;}

        public Test()
        {
            Id = 0;
            Name = "";
            Sex = "";
            Age = 0;
        }

        public Test(int id, string name, string sex, int age)
        {
            Id = id;
            Name = name;
            Sex = sex;
            Age = age;
        }
    }
}
