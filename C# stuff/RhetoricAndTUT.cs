using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace MegaManZero
{
    class Game
    {
        public bool RGCheck 
        {
            get {return RealGame;} 
            set 
            { 
                if (RGCheck = true || false)
                {
                    RealGame = value;
                }
                else 
                {
                    RealGame = null;
                };
            }
        } 

        static void Main (string[] args)
        {
            Actor Zero = new Actor();
            Zero.skills = 42;

            Zero.weapons= "Zsaber";
            Zero.pwr = 350;

            Actor X = new Actor();
            X.skills = 42;
            X.weapons= "Xbuster";
            X.pwr = 410;
            
            RGCheck = true;
            Console.WriteLine(x.skills);
        }

        public bool RealGame()
        {
            if (MegaManZero.Game.RGCheck == true)
            {
                //Print to the screen basically
                ConsoleWriteLine("OK!");
            }
            else
            {
                //Print to the screen basically
                ConsoleWriteLine("BadGame Check CID!");
            };
            return null;
        }

        
    }
}

