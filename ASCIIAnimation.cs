public class ASCIIAnimation
{   
    public ASCIIAnimation() { }

    public void StartAni(Villain g)
    {
        while (true)
        {
            for (int i = 0; i < 10; i++) 
            {
                Console.Clear();
                g.Move();
                g.Print();
            }
            g.ChangeDir();
        }
    }
}