namespace ConsoleAppListasEnlazadasNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            string
                nieto = "nieto",
                padre = "padre",
                abuelo = "abuelo",
                bisabuelo = "bisabuelo",
                tatarabuelo = "tatarabuelo";

            list.AddFirst(abuelo);
            list.AddLast(tatarabuelo);
            list.AddFirst(nieto);
            list.AddAfter( list.Find(nieto), padre);
            list.AddBefore(list.Find(tatarabuelo), bisabuelo);

            

            Console.WriteLine("------------------");
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("------------------");
            foreach (string str in list.Reverse()) 
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("------------------");
            LinkedListNode<string> item = list.First;

            while(item != null)
            {
                Console.WriteLine(item.Value);
                item = item.Next;
            }

            Console.WriteLine("------------------");
            LinkedListNode<string> item2 = list.Last;

            while (item2 != null)
            {
                Console.WriteLine(item2.Value);
                item2 = item2.Previous;
            }
            Console.ReadLine();
        }
    }
}
