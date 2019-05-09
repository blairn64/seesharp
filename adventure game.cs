using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventure_game
{
    class Program
    {
        static void Main(string[] args)
        {

            string hero;
            string hobbie;
            string pet;
            string habbit;
            string friend;
            string chemicals;
            string food;

    Console.WriteLine("Simple Adventure Game");
    Console.WriteLine();
	Console.Write("whot is your hero: ?");
	hero = Console.ReadLine();
    Console.WriteLine();


    Console.Write("what is your hobbie: ?");
	hobbie= Console.ReadLine();
    Console.WriteLine();

    Console.Write("what is your bad habbit: ?");
	habbit = Console.ReadLine();
    Console.WriteLine();

    Console.Write("what is your favourite food: ?");
	food = Console.ReadLine();
    Console.WriteLine();

	Console.Write("Name a chemical: ");
	chemicals = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Name a idiot of a friend you would want with you: ");
    friend = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Name a type of animal: ");
    pet = Console.ReadLine();
    Console.WriteLine();
	
            Console.WriteLine("{0} was one sitting on his couch procrastinating... it was was a Friday the most stressful day of the week/n!, {0} was sitting watching tv the world series of {1} was on" ,hero, hobbie);
            Console.WriteLine(" {0}'s pet {1} started snarling and growling yelping flapping diving quacking pecking and eventually fell asleep", hero, pet);
            Console.WriteLine("the {0}, had had an eventful day doing nothing, the stress of being a {0} really takes it out on these poor animals", pet);
            Console.WriteLine("due to the {0} of {1} and mostly down to procrastination and over indulgence of {2} ", hero,habbit ,food);
            Console.WriteLine("the {0}, which was laced with {1} that were not regulated or commissioned but yet appeared in every {0} known to man ",food, chemicals);
            Console.WriteLine("the {0} were harmful and made people ill, but luckily {1}'s friend {2} had became an aid worker and had spent the last seven years studying medicine, discovered a cure that cured {1}",chemicals, hero, friend);
            Console.WriteLine("{0} was cured forever and it was down to {1}'s secret medicine which turned out to be no more than his granny's soup that has left in a jar under the stairs since 1982, due to this {0} lived up until the age of 105 and had a happy life that involved many {2}",  hero,friend, pet);
        
             Console.ReadLine();      
        }
    }
}
