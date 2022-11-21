using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.U1_W1_D1.Intro_OOP
{
    internal class Veicolo
    {
        private string _targa, _tipo, _marca;
        private double _velocitaMax = 0;
        private double _velocitaAttuale = 0;
        private Persona _proprietario;
        private Boolean acceso;
        
        public string Targa { get { return _targa; } set { _targa = value; } }
        public string Tipo { get { return _tipo; } set { _tipo = value; } } 
        public string Modello { get { return _marca;} set { _marca = value; } } 
        public double VelocitaMax { get { return _velocitaMax; } set { _velocitaMax = value; } }
 
        public Persona Proprietario { get { return _proprietario; } set { _proprietario = value; } }

        public void Accendi()
        {
            acceso = true;
            Console.WriteLine($"Il veicolo {_marca} si è acceso!");
        }
        public void Accellera()
        {
            if (acceso)
            {
                if (VelocitaMax == 0) 
                {
                    Console.WriteLine("Sei gia alla massima velocità, ovvero 0km/h.");
                 } else { 
                            while (_velocitaAttuale != _velocitaMax)
                            {
                                _velocitaAttuale++;
                                Console.WriteLine($"Il veicolo {_marca} sta accellerando! Sei alla velocità di : " + _velocitaAttuale);
                            }
                            Console.WriteLine($"Hai raggiunto la velocità massima del veicolo {_marca}. Il veicolo si è surriscaldato. Spegnilo!");
                }
                
            } 
            else
            {
                Console.WriteLine($"Non puoi accellerare, il veicolo {_marca} è spento. Accendilo prima.");
            }

        }
            

        public void Spegni()
        {
            acceso = false;
            Console.WriteLine($"Il veicolo {_marca} si è spento!");
        }
    }
}

