using System.IO.Compression;

public class Goomba
{
    protected int count = 0;
    protected bool moveRight = true;
    protected string[] goombaSprite;
    protected string[] starSprite;
    public Goomba()
    {
starSprite = new string[10];
starSprite[0] = @"          ";
starSprite[1] = @"  ___/\___";
starSprite[2] = @"  \  ||  / ";
starSprite[3] = @"  /__  __\";
starSprite[4] = @"     \/   ";
starSprite[5] = @"          "; 

goombaSprite = new string[10];
       goombaSprite[0] = @"     ________  ";
       goombaSprite[1] = @"    /        \ ";
       goombaSprite[2] = @"   /  \    /  \ ";
       goombaSprite[3] = @"  /   |    |   \ ";
       goombaSprite[4] = @" /  -^------^-  \ ";
       goombaSprite[5] = @"|________________| ";
       goombaSprite[6] = @"      /    \ ";
       goombaSprite[7] = @" ____|      |____ ";
       goombaSprite[8] = @"/____\ ==== /____\ ";
       goombaSprite[9] = @"                     ";



    }

    public virtual void PrintStar(){
        for (int i = 0; i < starSprite.Length; i++){
            Console.WriteLine(starSprite[i]);
        }
    }

    public virtual void Print(){
        // Prints a single line of goomba
        
        for (int i = 0; i < goombaSprite.Length; i++){
            //
            for (int j = 0; j < count; j++){
                Console.Write("   ");
            }
            Console.WriteLine(goombaSprite[i]);
        }
        Thread.Sleep(70);
    }

    public virtual void Move(){
        if (moveRight){
            count++;
        } else {
            count--;
        }
    }
        
    public virtual void ChangeDir(){
        moveRight = !moveRight;
    }
}