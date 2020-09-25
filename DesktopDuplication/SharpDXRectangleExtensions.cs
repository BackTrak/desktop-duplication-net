
using Rectangle = SharpDX.Mathematics.Interop.RawRectangle;

namespace DesktopDuplication
{
    public static class SharpDXRectangleExtensions
    {
        public static int Width(this Rectangle rectangle)
        {
            return rectangle.Right - rectangle.Left;
        }

        public static int Height(this Rectangle rectangle)
        {
            return rectangle.Bottom - rectangle.Top;
        }
    }
}
