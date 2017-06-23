using System;
using System.Drawing;

public class APBox : APShape
{
    int thiccness;

   public APBox() 
   {
   }

	public APBox( int x1, int y1, int x2, int y2, Color c, int size)
     : base(x1, y1, x2, y2, Color.Purple)
    {
        setColor(c);
        thiccness = size;
    }

    public APBox(int x1, int y1, int x2, int y2)
     : base(x1, y1, x2, y2, Color.Purple)
    {

    }

    /// <summary>
    /// Draws a box
    /// </summary>
    /// <param name="g">Graphics object</param>
    public override void draw(Graphics g)
    {
        g.DrawRectangle(new Pen(getColor(), thiccness),
            Math.Min(getX1(),getX2()), //find Top left corner X value
            Math.Min(getY1(), getY2()), //find Top left corner Y
            Math.Abs(getX2() - getX1()), //Get Width
            Math.Abs(getY2() - getY1())); //Get Height
        
        
    }
}
