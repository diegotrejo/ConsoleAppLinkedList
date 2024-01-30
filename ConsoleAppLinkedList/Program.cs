namespace ConsoleAppLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var Hijo = "Hijo";
            var Padre = "Padre";
            var Abuelo = "Abuerlo";
            var Bisaubuelo = "Bisaubuelo";
            var tatarabuelo = "tatarabuelo";


            var arbolGenealogico = new ListaEnlazada(true);
            arbolGenealogico.InsertarInicio( Hijo);
            arbolGenealogico.InsertarInicio( Padre);
            arbolGenealogico.InsertarInicio(Abuelo);
            arbolGenealogico.InsertarInicio(Bisaubuelo);
            arbolGenealogico.InsertarInicio(tatarabuelo);
            arbolGenealogico.InsertarEn(Padre, "abc");
            arbolGenealogico.InsertarEn(Bisaubuelo, "xyz");
            arbolGenealogico.InsertarEn(Abuelo, "mnop");

            //arbolGenealogico.Eliminar(Bisaubuelo);
            //arbolGenealogico.Eliminar(tatarabuelo);
            //arbolGenealogico.Eliminar(Hijo);

            Console.WriteLine("---------------------");
            Console.WriteLine(arbolGenealogico.Inicio.Anterior.Valor);
            Console.WriteLine(arbolGenealogico.Fin.Siguiente.Valor);

            Console.WriteLine("---------------------");
            arbolGenealogico.MoverPrinero();
            arbolGenealogico.Imprimir();

            Console.WriteLine("---------------------");
            arbolGenealogico.ImprimirReverso();
        }

    }
}
