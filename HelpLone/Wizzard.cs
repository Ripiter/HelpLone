using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpLone.Interfaces;
namespace HelpLone
{
    class Wizzard : ICharacter, ITeleport
    {
        public void Die()
        {
            Console.WriteLine("die");
        }

        public void Fight()
        {
            Console.WriteLine("fight");
        }

        public void Heal()
        {
            Console.WriteLine("heal");
        }

        public void Teleport()
        {
            Console.WriteLine("Teleport");
        }
    }
}
