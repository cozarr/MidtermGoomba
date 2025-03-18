class GoombaAdv : Goomba, Villain
{
    protected bool sprite1 = true;
    protected string[] goombaSprite1;
    protected string[] goombaSprite2;

    public GoombaAdv()
    {
        goombaSprite1 = new string[]
        {
            @"     ________  ",
            @"    /        \ ",
            @"   /  \    /  \ ",
            @"  /   |    |   \ ",
            @" /  -^------^-  \ ",
            @"|________________| ",
            @" ____ /    \ ",
            @"/____\      |____ ",
            @"       ==== /____\ ",
            @"                     "
        };

        goombaSprite2 = new string[]
        {
            @"     ________  ",
            @"    /        \ ",
            @"   /  \    /  \ ",
            @"  /   |    |   \ ",
            @" /  -^------^-  \ ",
            @"|________________| ",
            @"      /    \ ____ ",
            @" ____|      /____\ ",
            @"/____\ ====         ",
            @"                     "
        };
    }

    public override void Print()
    {
        for (int i = 0; i < goombaSprite1.Length; i++)
        {
            for (int j = 0; j < count; j++)
            {
                Console.Write("   ");
            }
            Console.WriteLine(sprite1 ? goombaSprite1[i] : goombaSprite2[i]);
        }
        sprite1 = !sprite1;
        Thread.Sleep(150);
    }

    public override void Move()
    {
        if (moveRight)
        {
            count++;
        }
        else
        {
            count--;
        }
    }

    public override void ChangeDir()
    {
        moveRight = !moveRight;
    }
}
