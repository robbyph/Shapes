using System.Drawing;

public class APLine : APShape

{
    int thiccness;

    public APLine() 
    {
    }

    public APLine( int x1, int y1, int x2, int y2, Color c, int size)
          : base(x1, y1, x2, y2, Color.Red)
    {
        setColor(c);
        thiccness = size;
    }

    public APLine(int x1, int y1, int x2, int y2)
          : base(x1, y1, x2, y2, Color.Red)
    {

    }

    /// <summary>
    /// Draws a line
    /// </summary>
    /// <param name="g">Graphics Object</param>
    public override void draw(Graphics g)
    {
        g.DrawLine(new Pen(getColor(), thiccness), getX1(), getY1(), getX2(), getY2()); 
    }

}
