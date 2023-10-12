
Tamagotchi tama = new();


Console.WriteLine("Döp ditt husdjur");


tama.Name = Console.ReadLine();

while (tama.GetAlive()==true)
{
   
   Console.WriteLine($"Tryck 1 för att mata, 2 för att anropa ord, 3 för att lära {tama.Name} ett nytt ord!");
   tama.PrintStats();

   string svar = Console.ReadLine();

   if (svar =="1")
   {
      tama.Feed();
      tama.Tick();
   }
   else if (svar == "2")
   {
      tama.Hi();
      tama.Tick();
   }
   else if (svar == "3")
   {
      tama.Teach(Console.ReadLine());
      tama.Tick();
   }
   else
   {
      Console.WriteLine("Fel input");
      tama.Tick();
   }

   
}

Console.WriteLine("den död");


Console.ReadLine();