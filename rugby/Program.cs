namespace Rugby
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] s = RugbyPl.AddRugbyPlayers();//her henter den arrayes fra den anden klasse 
            Tools.PrintArray(s);// her sender den til klassen tools for at for det udskravet i de forksellige loops 

        }
    }




}


