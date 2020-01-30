using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpLone.Interfaces;


namespace HelpLone
{
    class Barbarian : ICharacter, IMeeleFight, ISlash
    {
        public void Bash()
        {
            Console.WriteLine("Bash");
        }

        public void Cleave()
        {
            Console.WriteLine("Cleave");
        }

        public void Die()
        {
            Console.WriteLine("Die");
        }

        public void Fight()
        {
            Console.WriteLine("Fight");
        }

        public void Heal()
        {
            Console.WriteLine("Heal");
        }

        public void Slash()
        {
            Console.WriteLine("Slash");
        }
    }
}
