using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MyLittlePhotoshop
{
    public class Filters
    {
        public static Bitmap MapPixels(Bitmap img, Func<Color, Color> f)
        {
            return img; //FIXME
        }

        public static Bitmap Convolution(Bitmap img, float[,] mat)
        {
            return img; //FIXME
        }

        public static Bitmap MirrorH(Bitmap img)
        {
            return img; //FIXME
        }

        public static Bitmap MirrorV(Bitmap img)
        {
            return img; //FIXME
        }

        public static Color Greyscale(Color c)
        {
            return c; //FIXME
        }

        public static Color Pinkify(Color c)
        {
            return c; //FIXME
        }

        public static Color Binarize(Color c)
        {
            return c; //FIXME
        }

        public static Color Invert(Color c)
        {
            return c; //FIXME
        }

        public static float[,] AverageMat;

        public static float[,] GaussMat;

        public static float[,] EdgeMat;
    }
}
