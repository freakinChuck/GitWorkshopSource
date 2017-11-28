using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkhopDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String computerNameInAppConfig = ConfigurationManager.AppSettings["MachineName"] ?? string.Empty;

            if (computerNameInAppConfig.ToUpper() == Environment.MachineName.ToUpper())
            {
                Console.WriteLine("");

                Console.WriteLine("The experiment is nearing its conclusion.");
                Console.WriteLine("The Enrichment Center is required to remind you that you will be baked, and then there will be cake.");

                //TODO: Insert Cake Write Function here ('Program.PrintCake();')

                Program.PrintFinish();
            }
            else
            {
                Console.WriteLine("Please Adjust the Computer Name in the App.Config File for this example to work.");
            }
            Console.WriteLine("Press any Key to Continue....");
            Console.ReadKey();
        }

        static bool hasPrintCakeBeenCalled = false;
        private static void PrintCake()
        {
            hasPrintCakeBeenCalled = true;
            string cake = @"
	            ,:/+/-                                     x    ________________                  ________________
                /M/              .,-=;//;-                 x   |                                                  |
	       .:/= ;MH/,    ,=/+%$XH@MM#@:                    x   |                _________________                 | 
	      -$##@+$###@H@MMM#######H:.    -/H#               x   |                                                  |
	 .,H@H@ X######@ -H#####@+-     -+H###@X               x   |          ____                    ____            |
	  .,@##H;      +XM##M/,     =%@###@X;-                 x   |         /                             \
	X%-  :M##########$.    .:%M###@%:                      x   |    ____/                               \____
	M##H,   +H@@@$/-.  ,;$M###@%,          -               x   |   |                                         |
	M####M=,,---,.-%%H####M$:          ,+@##               x   |   |                                         |
	@##################@/.         :%H##@$-                x   |   |                                         |
	M###############H,         ;HM##M$=                    x   |   |                                         |
	#################.    .=$M##M$=                        x   |   |                                         |
	################H..;XM##M$=          .:+               x   |   |_____                               _____|
	M###################@%=           =+@MH%               x   |         \                             /
	@################M/.          =+H#X%=                  x   |          \____                   ____/
	=+M##############M,       -/X#X+;.                     x   | 
	  .;XM##########H=    ,/X#H+:.                         x   |                _________________ 
	     ,:/%XM####H/.                                     x   |
	          ,.:=-.                                       x   |________________                  ________________|
";


            Console.Write(cake);
            Console.WriteLine();

        }


        private static void PrintFinish()
        {
            if (hasPrintCakeBeenCalled)
            {
                Console.WriteLine("This was a triumph.");
                Console.WriteLine("I'm making a note here: HUGE SUCCESS.");
                Console.WriteLine("It's hard to overstate my satisfaction!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The cake is a lie?");
                Console.WriteLine("Please adjust the code and get yourself some cake.");
                Console.WriteLine();
            }
        }

    }
}
