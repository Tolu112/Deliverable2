using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Hello, welcome to Tolu's $9.99 all you can eat buffet! Your choice of drinks include a fountain drink for just an extra $1.00 or coffee for an extra $2.00. We can accomodate a party of 6 or less. How many are in your party?: ");
        int numberofparty = int.Parse(Console.ReadLine());
        int numberofCoffeeRequests = 0;
        int numberofFountainDrinkRequests = 0;
        if (numberofparty <= 6)
        {
            Console.WriteLine("\n" + "Great! Table for " + numberofparty + ". I'll get you seated right away.");
            for (int i = 1; i <= numberofparty; i++)
            {
                Console.Write("\n" + "Person " + i + ", would you like a fountain drink or coffee?: ");
                string beverage = Console.ReadLine();
                if (beverage == "coffee" || beverage == "Coffee" || beverage == "fountain drink" || beverage == "Fountain Drink" || beverage == "fountain Drink" || beverage == "Fountain drink" || beverage == "fountain" || beverage == "Fountain")
                {
                    if (beverage == "coffee" || beverage == "Coffee") { Console.WriteLine("Coffee, got it!"); numberofCoffeeRequests++; }
                    else { Console.WriteLine("A fountain drink, excellent!"); numberofFountainDrinkRequests++; }
                }

                else { Console.Write("\n" + "Unfortunately, we don't have this beverage." + "\n"); }
            }
            decimal buffet = 9.99m;
            decimal buffetbill = numberofparty * buffet;
            String buffetString = buffetbill.ToString("C");
            decimal coffee = 2.00m;
            decimal coffeebill = coffee * numberofCoffeeRequests;
            String coffeebillString = coffeebill.ToString("C");
            decimal fountaindrink = 1.00m;
            decimal fountaindrinkbill = fountaindrink * numberofFountainDrinkRequests;
            String fountaindrinkbillString = fountaindrinkbill.ToString("C");
            decimal total = buffetbill + coffeebill + fountaindrinkbill;
            String totalString = total.ToString("C");
            Console.WriteLine("\n" + "Thank you for coming, here is your bill:" + "\n" + "\n" + numberofparty + " ($9.99 each) Buffet ticket(s): " + buffetString + "\n" + numberofCoffeeRequests + " ($2.00 each) Cup(s) of coffee: " + coffeebillString + "\n" + numberofFountainDrinkRequests + " ($1.00 each) Fountain drink(s): " + fountaindrinkbillString + "\n" + "\n" + "Total: " + totalString + "\n" + "\n" + "There's no rush with the bill, please come again soon!");
        }
        else { Console.Write("\n" + "Unfortunately, we can only accomodate parties of 6 or less. We hope you come back soon."); }
    }
}