using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpLone.Interfaces;
namespace HelpLone
{
    class Knight : ICharacter, IMeeleFight, ISlash, IShieldGlare
    {
        public void Bash()
        {
            Console.WriteLine("I Bash");
        }

        public void Cleave()
        {
            Console.WriteLine("I cleave");
        }

        public void Die()
        {
            Console.WriteLine("I Die");
        }

        public void Fight()
        {
            Console.WriteLine("I fight");
        }

        public void Heal()
        {
            Console.WriteLine("I heal");
        }

        public void ShieldGlare()
        {
            Console.WriteLine("Shild ");
        }

        public void Slash()
        {
            Console.WriteLine("Slash");
        }
    }
}
