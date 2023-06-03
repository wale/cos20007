using System;
using SplashKitSDK;

namespace BasicShape;

public abstract class Shape 
{
    private Color _color;
    private float _x;
    private float _y;

    private bool _selected; 


    public float X { get => this._x; set => this._x = value; }
    public float Y { get => this._y; set => this._y = value; }

    public Color Color { get => this._color; set => this._color = value; }


    public bool Selected { get => this._selected; set => this._selected = value; }

    public Shape(Color color) 
    {
        this._color = color;
        this._x = 0;
        this._y = 0;
        this._selected = false;
    }

    public Shape() : this(Color.Yellow) 
    {

    }

    public abstract void Draw();

    public abstract bool IsAt(Point2D point);

    public abstract void DrawOutline();
}