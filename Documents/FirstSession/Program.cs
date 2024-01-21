namespace FirstSession
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello, World!");*/ // First Method
           // Algo1 algo1 = new Algo1();
            Console.WriteLine("Please Enter First Name:");
            string Fname = Console.ReadLine();
            Console.WriteLine("Please Enter Second Name:");
            string Sname = Console.ReadLine();
            /* Console.WriteLine(algo1.JoinTwoString(Fname, Sname));*/ //First Method
            Console.WriteLine("Your name is " + Algo1.JoinTwoString(Fname, Sname) + ", Right?");// experimenting...
           // Console.WriteLine(Algo1.JoinTwoString(Fname, Sname)); ////Second Method
        }
    }
}
