namespace Wificheck;

internal class Program
{
    static void Main(string[] args)
    {
        string antwort = Antwort(true);

    }

    static string Antwort(bool status)
    {
        if (status)
        {
            string result = "Check";
            Console.WriteLine(result);
            return result;
        }
        else 
        {
            string result = "Not connected/no accses";
            Console.WriteLine(result);
            return result;
        }
    }
}