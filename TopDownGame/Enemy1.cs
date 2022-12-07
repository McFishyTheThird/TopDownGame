using Raylib_cs;

public class Enemy1
{
    public Rectangle rect;

    public Texture2D enemy1;

    public Enemy1()
    {
        enemy1 = Raylib.LoadTexture("Monster1.png");
        rect = new Rectangle(0, 0, enemy1.width, enemy1.height);
    }

    public void Draw()
    {
        
    }
}