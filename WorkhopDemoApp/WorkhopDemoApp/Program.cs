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
	            ,:/+/-
	            /M/              .,-=;//;-
	       .:/= ;MH/,    ,=/+%$XH@MM#@:
	      -$##@+$###@H@MMM#######H:.    -/H#
	 .,H@H@ X######@ -H#####@+-     -+H###@X
	  .,@##H;      +XM##M/,     =%@###@X;-
	X%-  :M##########$.    .:%M###@%:
	M##H,   +H@@@$/-.  ,;$M###@%,          -
	M####M=,,---,.-%%H####M$:          ,+@##
	@##################@/.         :%H##@$-
	M###############H,         ;HM##M$=
	#################.    .=$M##M$=
	################H..;XM##M$=          .:+
	M###################@%=           =+@MH%
	@################M/.          =+H#X%=
	=+M##############M,       -/X#X+;.
	  .;XM##########H=    ,/X#H+:.
	     ,:/%XM####H/.
	          ,.:=-.
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
