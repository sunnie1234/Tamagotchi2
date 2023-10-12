

public class Tamagotchi
{
    int Hunger = 0;
    int Boredom = 0;
    List<string> words = new() {""};
    bool isAlive = true;
    Random generator = new Random();
    public string Name;


    public void PrintStats()
    {
        Console.WriteLine($"{Name}\nHunger = {Hunger}, Boredom = {Boredom} Vocabulary: {words.Count} words");
    }

    public void Feed()
    {
        Hunger-=2;
        if (Hunger < 0)
        {
            Hunger = -1;
        }
    }

    public void Hi()
    {
        int wordNum = generator.Next(words.Count);
        Console.WriteLine(words[wordNum]);
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        Boredom += 1;
        Hunger += 1;
        if (Boredom >= 10 || Hunger >= 10)
        {
            isAlive = false;
        }
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    private void ReduceBoredom()
    {        
        Boredom--;
    }


}

