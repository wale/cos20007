using SplashKitSDK;

namespace BasicShape;

class MyCircle : Shape 
{
    private int _radius;

    public int Radius { get => this._radius; set => this._radius = value; }
    public MyCircle(Color clr, int radius) 
    {
        this.Color = clr;
        this.Radius = radius;
    }

    public MyCircle() : this(Color.Blue, 50)
    {
       
    }

    public override void Draw()
    {
        if (Selected) DrawOutline();
        SplashKit.FillCircle(Color, X, Y, _radius);
    }

    public override void DrawOutline()
    {
        SplashKit.FillCircle(Color.Black, SplashKit.CircleAt(X, Y, Radius + 4));
    }

    public override bool IsAt(Point2D point)
    {
        return SplashKit.PointInCircle(point, SplashKit.CircleAt(X, Y, Radius));
    }
}