using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_ex_1
{
    class Program
    {
        static int Main(string[] args)
        {
            var rnd = new Random();
            string A = "0123456789ABCDEFGHIGKLMNOPQISTUVWXYZ";
            Console.WriteLine("Сколько паролей нужно создать?");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for ( int k=0; k <= n; k++)
            {
                string passwd = "";
                for (int i = 0; i < 8; i++)
                {
                    passwd += A[rnd.Next(0, 36)];
                }
                Console.WriteLine(passwd);
            }
            Console.ReadKey();
            return 0;
        }
    }
}
