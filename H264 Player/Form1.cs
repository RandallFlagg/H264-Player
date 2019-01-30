using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FFmpeg.AutoGen;

namespace H264_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Size SetSize(Size sourceSize, Size destinationSize)
        {
            float minSize = Math.Min(destinationSize.Width, destinationSize.Height);

            float ratio;
            if (sourceSize.Width > sourceSize.Height)
            {
                ratio = minSize / (float)sourceSize.Width;
            }
            else
            {
                ratio = minSize / (float)sourceSize.Height;
            }

            var width = (int)(sourceSize.Width * ratio);
            width -= (width % 4);

            var height = (int)(sourceSize.Height * ratio);
            if (height % 2 != 0)
            {
                //height = height;
            }

            return new Size(width, height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                //String file = "http://www.quirksmode.org/html5/videos/big_buck_bunny.mp4";
                String file = @"D:\nana\01\21\145659_100_095856149_0914.h264";
                using (VideoStreamDecoder decoder = new VideoStreamDecoder(file))
                {
                    if (progressBar1.InvokeRequired)
                    {
                        progressBar1.Invoke((Action)(() =>
                        {
                            progressBar1.Maximum = (int)decoder.Duration;
                        }));
                    }
                    else
                    {
                        progressBar1.Maximum = (int)decoder.Duration;
                    }

                    if (lblFrameSize.InvokeRequired || lblCodecName.InvokeRequired)
                    {
                        pictureBox1.Invoke((Action)(() =>
                        {
                            lblFrameSize.Text = decoder.FrameSize.Width + " x " + decoder.FrameSize.Height;
                            lblCodecName.Text = decoder.CodecName;
                        }));
                    }
                    else
                    {
                        lblFrameSize.Text = decoder.FrameSize.Width + " x " + decoder.FrameSize.Height;
                        lblCodecName.Text = decoder.CodecName;
                    }

                    Console.WriteLine($"codec name: {decoder.CodecName}");

                    var info = decoder.GetContextInfo();
                    info.ToList().ForEach(x => Console.WriteLine($"{x.Key} = {x.Value}"));

                    var sourceSize = decoder.FrameSize;
                    var sourcePixelFormat = decoder.PixelFormat;
                    //var pictureBoxSize = new Size(pictureBox1.Width, pictureBox1.Height);
                    var pictureBoxSize = new Size(this.Width, this.Height);
                    var destinationSize = SetSize(sourceSize, pictureBoxSize);
                    var destinationPixelFormat = AVPixelFormat.AV_PIX_FMT_BGR24;
                    using (var vfc = new VideoFrameConverter(sourceSize, sourcePixelFormat, destinationSize, destinationPixelFormat))
                    {
                        var frameNumber = 0;
                        while (decoder.TryDecodeNextFrame(out var frame))
                        {
                            var convertedFrame = vfc.Convert(frame);
                            if (progressBar1.InvokeRequired)
                            {
                                progressBar1.Invoke((Action)(() =>
                                {
                                    progressBar1.Maximum = (int)decoder.Duration;
                                }));
                            }
                            unsafe
                            {
                                byte[] data = new byte[convertedFrame.width * convertedFrame.height * 3];
                                Marshal.Copy((IntPtr)convertedFrame.data[0], data, 0, data.Length);
                                IntPtr rawData = Marshal.UnsafeAddrOfPinnedArrayElement(data, 0);
                                //using (var bitmap = new Bitmap(convertedFrame.width, convertedFrame.height, convertedFrame.linesize[0], PixelFormat.Format24bppRgb, rawData))
                                var bitmap = new Bitmap(convertedFrame.width, convertedFrame.height, convertedFrame.linesize[0], PixelFormat.Format24bppRgb, rawData);
                                //Bitmap.FromStream();
                                //aaa(decoder);
                                //var bitmap = new Bitmap(convertedFrame.width, convertedFrame.height, convertedFrame.linesize[0], PixelFormat.Format24bppRgb, (IntPtr)convertedFrame.data[0]);
                                //using (var bitmap = new Bitmap(convertedFrame.width, convertedFrame.height, convertedFrame.linesize[0], PixelFormat.Format24bppRgb, (IntPtr)convertedFrame.data[0]))
                                {
                                    if (pictureBox1.InvokeRequired)
                                    {
                                        pictureBox1.Invoke((Action)(() => { pictureBox1.Image = bitmap; }));
                                    }
                                    else
                                    {
                                        pictureBox1.Image = bitmap;
                                    }
                                    //bitmap.Save($"frame.{frameNumber:D8}.jpg", ImageFormat.Jpeg);
                                }
                            }

                            if (progressBar1.InvokeRequired)
                            {
                                progressBar1.Invoke((Action)(() =>
                                {
                                    progressBar1.PerformStep();
                                    progressBar1.Value++;
                                }));
                            }
                            else
                            {
                                progressBar1.PerformStep();
                            }

                            Console.WriteLine($"frame: {frameNumber}");
                            frameNumber++;
                        }
                    }
                }
            });
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        //private readonly SwsContext* _pConvertContext;
        //        private unsafe void aaa(VideoStreamDecoder decoder)
        //        {
        //            System.Drawing.Size sourceSize = decoder.FrameSize;
        //            SwsContext* _pConvertContext = ffmpeg.sws_getContext(sourceSize.Width, sourceSize.Height, AVPixelFormat.AV_PIX_FMT_RGB24, //sourcePixelFormat
        //                sourceSize.Width/4, sourceSize.Height/4,
        //                //destinationSize.Width, destinationSize.Height,
        //                AVPixelFormat.AV_PIX_FMT_RGB24,//destinationPixelFormat,
        //ffmpeg.SWS_FAST_BILINEAR, null, null, null); ;
        //            AVFrame sourceFrame;

        //            var dstData = new byte_ptrArray4();
        //            var dstLinesize = new int_array4();
        //            ffmpeg.av_image_alloc(ref dstData, ref dstLinesize, sourceSize.Width / 4, sourceSize.Height / 4, AVPixelFormat.AV_PIX_FMT_RGB24, 1);
        //            decoder.TryDecodeNextFrame(out sourceFrame);
        //            ffmpeg.sws_scale(_pConvertContext, sourceFrame.data, sourceFrame.linesize, 0, sourceFrame.height, dstData, dstLinesize);
        //            //sourceFrame.
        //            //int x = 5;
        //        }
    }
}