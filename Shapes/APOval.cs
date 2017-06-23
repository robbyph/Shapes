using System;
using System.Drawing;

public class APOval : APShape

{
    int thiccness;

   public APOval() 
   {
   }

	public APOval( int x1, int y1, int x2, int y2, Color c, int size)
        : base(x1, y1, x2, y2, Color.Black)
   {
        this.setColor(c);
        thiccness = size;
   }

    public APOval(int x1, int y1, int x2, int y2)
        : base(x1, y1, x2, y2, Color.Black)
    {

    }

    /// <summary>
    /// Draws an oval
    /// </summary>
    /// <param name="g">Graphics Object</param>
    public override void draw(Graphics g)
    {
        g.DrawEllipse(new Pen(getColor(), thiccness), getX1(), getY1(), getX2() - getX1(), getY2() - getY1());
    }

}
