using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;

namespace JahovaManagment
{
    public class CameraImaging
    {
        // enumerate video devices
        public FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        //camera
        public VideoCaptureDevice videoSource;
        //screen shot
        public Bitmap bitmap;
        public string Text { get; set; }
        public string FileName { get; set; }

        public CameraImaging(string fileName)
        {
            FileName = fileName;
            // create video source
            videoSource = new VideoCaptureDevice(videoDevices[1].MonikerString);
            // set NewFrame event handler
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);

            videoSource.Start();
            //videoSource.Stop();

        }
        public void StartVideo()
        {
            // start the video source
            videoSource.Start();
            // ...
        }
        public void StopVideo()
        {
            // stop the video source
            videoSource.Stop();
            // ...
        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // get new frame
            bitmap = (Bitmap)eventArgs.Frame.Clone();

            string filename = @"C:\Users\User\Desktop\Ally\JahovaManagment\static\" + FileName + ".png";

            // process the frame

            try
            {
                var rgbarray = ImageToByteArray(bitmap);

                LuminanceSource source = new RGBLuminanceSource(rgbarray, bitmap.Width, bitmap.Height);
                BinaryBitmap abitmap = new BinaryBitmap(new HybridBinarizer(source));

                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode(source);
                bitmap.Save(filename);
                if (result != null)
                {

                    Text = result.Text;
                }
            }
            catch (Exception)
            {


            }

        }

        public static byte[] ImageToByteArray(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
    }

}
