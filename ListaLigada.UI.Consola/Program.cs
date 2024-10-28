using ListaLigada.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! Lista Ligada simple");
        Console.WriteLine("");

        var singleList = new SingleList<String>();

        singleList.Add("Alondra");
        singleList.Add("Karla");
        singleList.Add("Pris");
        singleList.Add("Uri");
        singleList.Add("Gonza");
        singleList.Add("Yoshua");

        Console.WriteLine(singleList);



        Console.ReadKey();
    }
}