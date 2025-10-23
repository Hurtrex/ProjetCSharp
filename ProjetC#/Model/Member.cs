using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC_.Model
{
    public class Member
    {
        public string Name { get; set; }

        public Member(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"Member Name: {Name}";
        }
    }
}
