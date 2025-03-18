class Goomba2DPainter : GoombaAdv, Villain
{
    private int x = 10, y = 5; //goomba pos
    private int direction = 0;
    private char[,] canvas = new char[40, 80]; //canvas size 

    public Goomba2DPainter()
    {
        //initial canvas 
        for (int i = 0; i < 40; i++)
            for (int j = 0; j < 80; j++)
                canvas[i, j] = ' ';
    }

    public override void Move()
    {
        //previous goomba pos 
        int prevX = x;
        int prevY = y;

        //moving goomba 
        if (direction == 0) x += 8;      //right
        else if (direction == 1) y += 4; //down
        else if (direction == 2) x -= 8; //left
        else if (direction == 3) //up
        {
            if (y - 4 < 5) //overshooting top row stops goomba before it does 
                y = 5; //start pos
            else
                y -= 4; //upward movement
        }

        //bounds
        x = Math.Clamp(x, 8, 72);
        y = Math.Clamp(y, 4, 36);

        //draw trail if " "
        if (canvas[prevY, prevX] == ' ')
            canvas[prevY, prevX] = '*';
    }

    public override void Print()
    {
        Console.Clear();

        
        for (int i = 0; i < 40; i++)
        {
            for (int j = 0; j < 80; j++)
            {
                Console.Write(canvas[i, j]);
            }
            Console.WriteLine();
        }

        //goombaAdv sprite
        string[] sprite = sprite1 ? goombaSprite1 : goombaSprite2;
        for (int s = 0; s < sprite.Length; s++)
        {
            Console.SetCursorPosition(x, y + s);
            Console.Write(sprite[s]);
        }

        sprite1 = !sprite1; //goomba stomp left goomba stomp right switch back and fourth
        Thread.Sleep(100); //goomba speed 
    }

    public override void ChangeDir()
    {
        direction = (direction + 1) % 4; //90 degrees clockwise
    }
}
