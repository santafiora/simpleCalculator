using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    /// <summary>
    /// einfacherTaschenrechner
    /// Für Anfänger es Zeigt die Grundlagen einer statischen Methode
    /// Wie Operatoren zum rechnen eingesetzt werden können und den Modulo Restoperator
    /// Das ganze wird Simple gehalten durch eine if u. Else if Kontrollstruktur welches ja auch ein (switch ist)
    /// </summary>

    class Program
    {
        /// <summary>
        /// Keine Parameter dies ist nur für Doxygen
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //!Youtube Kanal ChessSuite
            //!Sprung in die statische Methode Menue siehe Weiter unten
            Menue();

            Console.WriteLine("Bitte die erste Zahl eingeben: ");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte die zweite Zahl eingeben: ");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte den Operanden eingeben um die Grundrechenart zu bestimmen: [ +  -  *  / ]");
            string operatorenEingabe = Console.ReadLine();

            //!Operatoren Behandlung durch if und Else If

            if (operatorenEingabe == "+")
            {
                Console.WriteLine("Das Ergebnis lautet " + (Zahl1 + Zahl2));
            }

            else if (operatorenEingabe == "-")
            {
                Console.WriteLine("Das Ergebnis lautet " + (Zahl1 - Zahl2));
            }

            else if (operatorenEingabe == "*")
            {
                Console.WriteLine("Das Ergebnis lautet " + (Zahl1 * Zahl2));
            }

            else if (operatorenEingabe == "/")
            {
                Console.WriteLine("Das Ergebnis lautet " + (Zahl1 / Zahl2));


                //!Module Ausgabe bei Rest Division also 22 / 7 = Rest 1
                int restAusModulo = Zahl1 % Zahl2;
                //!Falls nicht null dann eben die Ausgabe
                if (restAusModulo != 0)
                    Console.WriteLine("Rest aus der Division " + restAusModulo);
            }

            else
            {
                Console.WriteLine("Diesen Operator haben Sie noch nicht entwickelt ??? ");

            }
            Console.WriteLine("Programmende");
            Console.ReadKey();
        }
        /// <summary>
        /// Doxygen Doku Aufbau siehe Video Doxygen auf meinem Kanal
        /// Menue Aufbau Begrüssung Taschenrechner
        /// Hier wird in der Schleife das Minus Zeichen ausgegeben über die Laufvariable i
        /// </summary>
        static void Menue()
        {
            Console.WriteLine("Willkommen ich bin ein einfacher Taschenrechner");


            for (int i = 0; i < 48; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
        }
    }
}