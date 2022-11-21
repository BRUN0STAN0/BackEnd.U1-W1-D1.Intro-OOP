using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.U1_W1_D1.Intro_OOP
{
    internal class Persona
    {
        private string _nome, _cognome;
        private byte _eta, _altezza;
        private Veicolo _veicolo;
        public string Nome { get { return _nome; } set { _nome = value; } }
        public string Cognome { get { return _cognome; } set { _cognome = value; } }
        public byte Eta { get { return _eta;}set{_eta = value; } }
        public byte Altezza { get { return _altezza; }set{_altezza = value; } }

        public Veicolo Veicolo { get { return _veicolo; } set { _veicolo = value; } }
    }
}
