namespace Primerparcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, ladobase, areapiramide, volumenpiramide, arista, cantidadpiramide;
            cantidadpiramide = 0;
            do
            {

                Console.WriteLine("Ingrese la altura");
                altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el lado de la base");
                ladobase = double.Parse(Console.ReadLine());
                areapiramide = Areadelapiramide(ladobase, altura);
                arista = Valordearista(ladobase, altura);
                volumenpiramide = volumendelapiramide(ladobase, altura);
                cantidadpiramide = cantidadpiramide + 1;
                Console.WriteLine($"el area de la piramide es {areapiramide} y el volumen es {volumenpiramide}");
                if (altura == 0) 
                {  
                    if (ladobase == 0) { }
                
                }
                
               

                
                




            } while (true);
            Console.WriteLine($"la cantidad de piramides ingresadas es {cantidadpiramide}");

        }
        private static double volumendelapiramide(double ladobase, double altura)=> (Math.Pow(ladobase,2) * altura) / 3;
        private static double Valordearista(double ladobase, double altura) => Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(ladobase, 2) / 2);
        private static double Areadelapiramide(double ladobase, double altura) =>ladobase*(ladobase + Math.Sqrt(4*Math.Pow(altura,2)+Math.Pow(ladobase,2)));
    }
}