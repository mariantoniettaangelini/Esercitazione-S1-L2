namespace Esercitazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            persona a = new persona();
            a.Nome = "Mario";
            a.Cognome = "Rossi";
            a.Eta = 30;
            a.getNome();
            a.getCognome();
            a.getDettagli();

            persona b = new persona();
            b.Nome = "Luigi";
            b.Cognome = "Bianchi";
            b.Eta = 20;
            b.getNome();
            b.getCognome();
            b.getDettagli();

        }
    }
}
