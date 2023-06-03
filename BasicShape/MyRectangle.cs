using SplashKitSDK;

namespace BasicShape;

public class MyRectangle : Shape 
{
    private int _width;
    private int _height;

    public int Width { get => this._width; set => this._width = value; }
    public int Height { get => this._height; set => this._height = value; }

    public MyRectangle(Color clr, float x, float y, int width, int height): base (clr) 
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    public MyRectangle() : this(Color.Green, 0, 0, 100, 100) 
    {

    }

    public override void Draw()
    {
        if (Selected) DrawOutline();

        SplashKit.FillRectangle(Color, X, Y, _width, _height);
    }

    public override void DrawOutline()
    {
        SplashKit.FillRectangle(Color.Black, X - 2, Y - 2, _width + 4, _height + 4);
    }

    public override bool IsAt(Point2D point)
    {
        return SplashKit.PointInRectangle(point, SplashKit.RectangleFrom(X, Y, _width, _height));
    }
}