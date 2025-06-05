// See https://aka.ms/new-console-template for more information
public abstract class Game 
{
    public abstract void Initialize();
    public abstract void StartPlay();
    public abstract void EndPlay();

    public void Play() 
    {
        Initialize();
        StartPlay();
        EndPlay();
    }
}
