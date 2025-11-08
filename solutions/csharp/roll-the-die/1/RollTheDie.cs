
public class Player
{
    public int RollDie()
    {
        Random rnd = new Random();
        int result = rnd.Next(1,19);
        return result;
    }

    public double GenerateSpellStrength()
    {
        Random rnd = new Random();
        double result = 100*rnd.NextDouble();
        return result;
    }
}
