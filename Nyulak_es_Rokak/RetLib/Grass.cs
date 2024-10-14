public enum GrassState
{
    Seedling,    // F�kezdem�ny
    Tender,      // Zsenge f�
    FullGrown    // Kifejlett f�csom�
}

public class Grass
{
    public GrassState State { get; private set; }

    public Grass()
    {
        State = GrassState.Seedling;
    }

    public void Grow()
    {
        if (State == GrassState.Seedling)
            State = GrassState.Tender;
        else if (State == GrassState.Tender)
            State = GrassState.FullGrown;
    }

    public int GetNutritionValue()
    {
        if (State == GrassState.Tender)
            return 1;
        else if (State == GrassState.FullGrown)
            return 2;
        return 0;
    }

    public void ResetToSeedling()
    {
        State = GrassState.Seedling;
    }
}
