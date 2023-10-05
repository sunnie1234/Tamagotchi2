

public class Tamagotchi
{
    int Hunger = 0;
    int Boredom = 0;
    List<string> words = new() {"iii"};
    bool isAlive = true;
    Random generator = new Random();
    public string Name;


    public void PrintStats()
    {
        Console.WriteLine($"Hunger = {Hunger}, Boredom = {Boredom} Vocabulary: {words.Count} words");
    }

    public void Feed()
    {

    }

    public void Hi()
    {

    }

    public void Teach(string word)
    {

    }

    public void Tick()
    {
        
    }


}

