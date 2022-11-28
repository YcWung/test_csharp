using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using OpenCvSharp;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var IMG = Cv2.ImRead("C:\\Users\\yongc\\Pictures\\app_depth_image_viewer.jpg", 0);
            Cv2.ImShow("0",IMG);
            Cv2.WaitKey(0);
        }
    }
}