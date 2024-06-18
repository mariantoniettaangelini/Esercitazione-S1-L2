using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    internal class persona
    {
        string nome;
        string cognome;
        int eta;

        public string Nome
        {
            get { return nome; } set { nome = value; }
        }
        public string Cognome
        {
            get { return cognome; } set { cognome = value; }
        }
        public int Eta
        {
            get { return eta; } set { eta = value; }
        }

        public void getNome()
        {
            Console.WriteLine(nome);
        }
        public void getCognome()
        {
            Console.WriteLine(cognome);
        }
        public void getDettagli()
        {
            Console.WriteLine("Mi chiamo" + " " + nome + " " + cognome + " " + "e ho anni" + " " + eta);
        }
    }
}
