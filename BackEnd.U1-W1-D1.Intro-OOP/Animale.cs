using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.U1_W1_D1.Intro_OOP
{
    internal class Animale
    {
        private string _razza, _pelo;
        private byte _numeroZampe;

        private Persona _proprietario;

        private string Razza { get { return _razza; } set { _razza = value; } }
        private string Pelo { get { return _pelo; } set { _pelo = value; } }    
        private byte NumeroZampe { get { return _numeroZampe;} set { _numeroZampe = value; } }

        public Persona Proprietario { get { return _proprietario; } set { _proprietario = value; } }
    }
}
