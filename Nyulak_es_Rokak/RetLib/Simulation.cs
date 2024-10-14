

public class Simulation
{
    public Grid Grid { get; private set; }
    public int Turns { get; private set; }

    public Simulation(int width, int height)
    {
        Grid = new Grid(width, height);
        Turns = 0;
    }

    public void RunTurn()
    {
        // Grass grows
        foreach (var cell in Grid.Cells)
        {
            if (cell.Rabbit == null)
            {
                cell.Grass.Grow();
            }
        }

        // Process rabbits
        foreach (var cell in Grid.Cells)
        {
            if (cell.Rabbit != null)
            {
                cell.Rabbit.Starve();
                if (cell.Rabbit.IsDead())
                {
                    cell.Rabbit = null;  // Ny�l elpusztul
                }
                else
                {
                    cell.Rabbit.Eat(cell.Grass);  // Ny�l legel
                    // Ny�l mozg�sa
                    // Szaporod�s, ha van hely �s m�sik ny�l k�zelben
                }
            }
        }

        // Process foxes
        foreach (var cell in Grid.Cells)
        {
            if (cell.Fox != null)
            {
                cell.Fox.Starve();
                if (cell.Fox.IsDead())
                {
                    cell.Fox = null;  // R�ka elpusztul
                }
                else
                {
                    // R�ka t�pl�lkoz�sa �s mozg�sa
                }
            }
        }

        Turns++;
    }
}