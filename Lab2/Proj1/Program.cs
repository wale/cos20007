using System;
using SplashKitSDK;

namespace Proj1
{
    public class Program
    {
        public static void Main()
        {
            Window window = SplashKit.OpenWindow("Hello World", 800, 600);

            SplashKit.Delay(3000);
        }
    }
}
