using System.Drawing;

public abstract class APShape

{
    private int x1, x2, y1, y2;
    private Color myColor;

    public APShape() 
    { 
        setX1( 0 );
        setX2( 0 );
        setY1( 0 );
        setY2( 0 );
		myColor = Color.Black;
    }

    public APShape( int x1, int y1, int x2, int y2, Color c ) 
    { 
        setX1( x1 );
        setX2( x2 );
        setY1( y1 );
        setY2( y2 );
		setColor( c );
    }

    public void setX1( int x1 ) { this.x1 = ( x1 >= 0 ? x1 : 0 ); }
    public void setX2( int x2 ) { this.x2 = ( x2 >= 0 ? x2 : 0 ); }
    public void setY1( int y1 ) { this.y1 = ( y1 >= 0 ? y1 : 0 ); }
    public void setY2( int y2 ) { this.y2 = ( y2 >= 0 ? y2 : 0 ); }
	public void setColor(Color c) {this.myColor = c;}

    public int getX1() { return x1; }
    public int getX2() { return x2; }
    public int getY1() { return y1; }
    public int getY2() { return y2; }
	public Color getColor() { return myColor; }

    public abstract void draw(Graphics g);
}
