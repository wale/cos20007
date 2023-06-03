using System;
using SplashKitSDK;

namespace BasicShape
{
    public class Program
    {
        private enum ShapeKind 
        {
            Rectangle,
            Circle,
            Line
        }
        public static void Main()
        {
            Window window = new Window("Shape Drawer", 800, 600);
            Drawing myDrawing = new Drawing();

            ShapeKind kindToAdd = ShapeKind.Circle;

            float startX = 0;
            float startY = 0;
            float endX = 0;
            float endY = 0;

            do {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if (SplashKit.KeyTyped(KeyCode.RKey)) 
                {
                    kindToAdd = ShapeKind.Rectangle;
                }
                
                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                }

                if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                }

                if (SplashKit.MouseClicked(MouseButton.LeftButton)) 
                {
                    var xPos = (int) SplashKit.MouseX();
                    var yPos = (int) SplashKit.MouseY();
                    
                    Shape newShape;

                    if (kindToAdd == ShapeKind.Circle)
                    {
                        newShape = new MyCircle { X = xPos, Y = yPos }; // Combine property setters onto one line
                        myDrawing.AddShape(newShape);
                    } 
                    
                    if(kindToAdd == ShapeKind.Rectangle)
                    {
                        newShape = new MyRectangle { X = xPos, Y = yPos };
                        myDrawing.AddShape(newShape);
                    } 

                    if(kindToAdd == ShapeKind.Line)
                    {
                        if (startX == 0 && startY == 0) 
                        {
                            startX = SplashKit.MouseX();
                            startY = SplashKit.MouseY();
                        } else if (endX == 0 && endY == 0)
                        {
                            if (SplashKit.MouseClicked(MouseButton.LeftButton)) 
                            {
                                endX = SplashKit.MouseX();
                                endY = SplashKit.MouseY();

                                newShape = new MyLine { X = startX, Y = startY, EndX = endX, EndY = endY };

                                startX = 0;
                                startY = 0;
                                endX = 0;
                                endY = 0;

                                myDrawing.AddShape(newShape);
                            }
                        }
                    }
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton)) 
                {
                    myDrawing.SelectShapesAt(SplashKit.MousePosition());
                }


                if (SplashKit.KeyTyped(KeyCode.BackspaceKey) || SplashKit.KeyTyped(KeyCode.DeleteKey)) 
                {
                    foreach (var shape in myDrawing.SelectedShapes) {
                        myDrawing.RemoveShape(shape);
                    }
                }

                if (SplashKit.KeyDown(KeyCode.SpaceKey)) {
                    myDrawing.Background = SplashKit.RandomRGBColor(255);
                }

                myDrawing.Draw();

                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }
    }
}
