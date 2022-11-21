using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.U1_W1_D1.Intro_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Veicolo BMWe46 = new Veicolo();

            BMWe46.Modello = "E46";
            BMWe46.Tipo = "Auto";

            Persona Bruno = new Persona();

            Bruno.Altezza = 170;
            Bruno.Cognome = "Stano";
            Bruno.Nome = "Bruno";
            Bruno.Eta = 28;

            BMWe46.Proprietario = Bruno;

            BMWe46.Accellera();

            BMWe46.Accendi();
            BMWe46.Accellera();

            
            BMWe46.VelocitaMax = 70;
            BMWe46.Spegni();
            BMWe46.Accendi();
            BMWe46.Accellera();


            Console.ReadLine();
        }
    }
}
