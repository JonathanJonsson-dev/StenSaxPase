using System;
using System.Collections.Generic;
using System.Text;

namespace StenSaxPåse
{
    public class Computer
    {
        public string Choice { get; set; }

        public Computer()
        {
            ComputerChoice();
        }

        private void ComputerChoice()
        {
            Random random = new Random();
            int randomNumber = random.Next(3);

            if (randomNumber == 0)
            {
                Choice = "Sten";
            }
            if (randomNumber == 1)
            {
                Choice = "Sax";
            }
            if (randomNumber == 2)
            {
                Choice = "Påse";
            }
        }
    }
}
