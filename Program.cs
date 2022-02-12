using static System.Console;

namespace desafiodotnet
{
    public class Program
    {
        static void CuboQuadrado()
        {
            int n = int.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = inicio; i <= n; i++)
            {
               
                int quadrado = i * i;
                int cubo = quadrado *i;

                Console.WriteLine("{0} {1} {2}", i, quadrado, cubo );
                

            }
        }
        
        public static int SomaPares(int x)
        {
            var total = 0;
            var temp = x;
            for (int i = 1; i <= 5; i++)
            {
                total += temp;
                temp += 2;
            }

            return total;
        }
        static void Main(string[] args)
        {
          
          while(true){
            
            int x = int.Parse(Console.ReadLine());
            
            if(x == 0) break;
            
            int total = 0;
    
            if (x % 2 == 0)
            {
                total = SomaPares(x);
            }
            else 
            {
                total = SomaPares(x+1);
            }
            
            Console.WriteLine(total);
              
          }
          
        }
    }
}
