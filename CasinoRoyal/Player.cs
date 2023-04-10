using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoRoyal
{
    class Player
    {
        public string Name { get; set; }
        public int Cash { get; set; }

        /// <summary>
        /// Wyświetla w konsoli imie i posiadana kwote.
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " ma " + Cash + " zl." );
        }

        /// <summary>
        /// Przekazuje pieniadze i usuwa je z portfela lub 0, jesli 
        /// dostepne srodki sa za male (lub parametr amount < 0 lub jest nieprawidlowy
        /// </summary>
        /// <param name="amount"> Przekazywana ilosc pieniedzy </param>
        /// <returns> Ilosc pieniedzy wyjmowanych z portfela lub 0 jesli jesli dostepny srodki sa za male lub parametr jest za maly </returns>
        public int GiveCash(int amount)
        {
            amount = AmountHigherThanCashnCheck(amount);
            amount = AmountLesserThanZeroCheck(amount);
            Cash -= amount;
            return amount;
        }


        /// <summary>
        /// Przyjmuje pieniadze i dodaje je do portfela
        /// </summary>
        /// <param name="amount"> Przyjmowana kwota</param>
        public void ReceiveCash(int amount)
        {
            amount = AmountLesserThanZeroCheck(amount);
            Cash += amount;
        }

        public int AmountHigherThanCashnCheck(int amount)
        {

            if (amount > Cash)
            {
                Console.WriteLine(Name + " mowi: "
                    + "Nie ma wystarczajcych srodkow, aby dac ci " + amount + " zl");
                return 0;
            }
            return amount;
        }

        public int AmountLesserThanZeroCheck(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " mówi: " + amount + " nie jest poprawną kwotą.");
                return 0;
            }
            return amount;
        }
    }
}
