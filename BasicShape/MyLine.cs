using SplashKitSDK;

namespace BasicShape;

class MyLine : Shape
{
    private float _endX;
    private float _endY;

    public float EndX { get => this._endX; set => this._endX = value; }
    public float EndY { get => this._endY; set => this._endY = value; }

    public MyLine(Color clr, float endX, float endY) : base(clr)
    {
        _endX = endX;
        _endY = endY;
    }

    public MyLine() {

    }

    public override void Draw()
    {
        if (Selected) DrawOutline();
        SplashKit.DrawLine(Color, X, Y, EndX, EndY);
    }

    public override void DrawOutline()
    {
        int radius = 2;
        SplashKit.FillCircle(Color.Black, X, Y, radius);
        SplashKit.FillCircle(Color.Black, _endX, _endY, radius);
    }

    public override bool IsAt(Point2D point)
    {
        return SplashKit.PointOnLine(point, SplashKit.LineFrom(X, Y, EndX, EndY), 15);
    }
}