public class repeticao : MonoBehavior
{
    public int municao = 10;

    public void start()
    {
        Shotgun();
    }
    
    public void Shotgun()
    {
        while (municao > 0)
        {
            print("pewl");
            municao -= 1;
        }
    }
    
}