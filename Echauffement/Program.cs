namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        string name = "";
        int age;
        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Hi, My name is Kevin");
        Console.WriteLine("My favourite name is NieR:Automata");
        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        while (name == "")
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
        int age1 = 0;
        while (age1 == 0)
        {
            Console.WriteLine("How old are you?");
            age1 = Convert.ToInt32(Console.ReadLine());
            if (age1 < 0)
            {
                Console.WriteLine("You can't be negative years old.");
            }

        }
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        age = Convert.ToInt32(age1);
        if (age == 0)
        {
            Console.WriteLine("Hello," + name + ". You aren't born yet");
        }
        else if (age < 18)
        {
            Console.WriteLine("Hello," + name + ". You are a Minor");
        }
        else if (age >= 18)
        {
            Console.WriteLine("Hello," + name + ". You are an Adult");
        }
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("How much money do you have? XXXX.XXX");
        double money = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("You have " + money + " Euros");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        string[] weaponname = { "", "Virtuous Contract", "Cruel Oath", "Virtuous Treaty", "Cruel Blood Oath" };
        double[] weaponprice = { 0, 310.31, 129.13, 19321.13, 1313131313131313 };
        Console.WriteLine("Welcome to the Shop!");
        Console.WriteLine("We have 4 weapons in Stock");
        Console.WriteLine("1:  " + weaponname[1] + "   :" + weaponprice[1] + " Euros");
        Console.WriteLine("2:  " + weaponname[2] + "   :" + weaponprice[2] + " Euros");
        Console.WriteLine("3:  " + weaponname[3] + "   :" + weaponprice[3] + " Euros");
        Console.WriteLine("4:  " + weaponname[4] + "   :" + weaponprice[4] + " Euros");


        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        int weapon = 0;
        while (weapon <= 0 || weapon > 4)
        {
            Console.WriteLine("Please choose a weapon, Enter a Number");
            weapon = Convert.ToInt32(Console.ReadLine());


            switch (weapon)
            {
                case 1:
                    Console.WriteLine("You have chosen " + weaponname[1] + ", this weapon costs " + weaponprice[1]);

                    break;
                case 2:
                    Console.WriteLine("You have chosen " + weaponname[2] + ", this weapon costs " + weaponprice[2]);

                    break;
                case 3:
                    Console.WriteLine("You have chosen " + weaponname[3] + ", this weapon costs " + weaponprice[3]);

                    break;
                case 4:
                    Console.WriteLine("You have chosen " + weaponname[4] + ", this weapon costs " + weaponprice[4]);

                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }
        }
        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
        if (weaponprice[weapon] <= money)
        {
            Console.WriteLine("You have enough money to buy this.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("You do not have enough money to purchase this weapon, gtfo.");
        }
        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible
        
        if (age >= 18 && (weaponprice[weapon] <= money))
        {
            Console.WriteLine("You have bought the" + weaponname[weapon] + ", You now have " + (money - weaponprice[weapon] + "euros."));
        }
        else if (weaponprice[weapon] <= money)
        {
            Console.WriteLine("Minors are unauthorized to purchase weapons.");
        }
        else 
            {
            Console.WriteLine("");
            }
            /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}