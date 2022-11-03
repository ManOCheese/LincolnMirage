using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System.Diagnostics;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int currDelay = 1;
        int delayCompensation = 0;
        int compDelay = 1;
        int threadCount;
        List<int> frameTimes = new List<int>();

        Mat image = new Mat();

        // static Tuple<Emgu.CV.CvEnum.CapProp> hwAcc = new Tuple<Emgu.CV.CvEnum.CapProp>(Emgu.CV.CvEnum.CapProp.HwAcceleration, (int)Emgu.CV.CvEnum.VideoAccelerationType.D3D11);
        

        VideoCapture capture = new VideoCapture(0, VideoCapture.API.Any, new Tuple<Emgu.CV.CvEnum.CapProp, int>(Emgu.CV.CvEnum.CapProp.HwAcceleration, (int)Emgu.CV.CvEnum.VideoAccelerationType.VaAPI)); //create a camera captue
        

        public Form1()
        {
            InitializeComponent();

            capture.FlipVertical = true;
            capture.FlipHorizontal = true;
            capture.Start();
            capture.ImageGrabbed += ProcessFrame;
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            Thread t = new Thread(displayImageThread);          // Kick off a new thread
            t.Start();     
            imageBox1.Image = image;
            if(frameTimes.Count > 0)
            {
                if(frameTimes.Count > 60)
                {                    
                    frameTimes.RemoveAt(0);
                }
                lock (frameTimes)
                {
                    delayCompensation = (int)frameTimes.Average() - currDelay;
                }
                
                if(currDelay > delayCompensation )
                {
                    compDelay = currDelay - delayCompensation;
                    // Debug.WriteLine("Compensating");
                }
                updateLabel("Delay: " + currDelay + "  -   ComDelay: " + compDelay.ToString() + "   -   delayComp: " + delayCompensation);
            
            }
        }
            private void displayImageThread()
            {
                var sw = Stopwatch.StartNew();
                threadCount += 1;
                if(threadCount <= 12) // Skip frame if we're using too many threads
                {
                    //Debug.WriteLine(threadCount);
                    Mat tempImage = capture.QueryFrame();
                    // Thread.Sleep(currDelay);
                    image = tempImage;
                    lock (frameTimes)
                    {
                        frameTimes.Add((int)sw.ElapsedMilliseconds);
                    }                
                }
                Debug.WriteLine(sw.ElapsedMilliseconds);
                threadCount -= 1;
                sw.Stop();
            }

        delegate void updateLabelCallback(string myText);
        private void updateLabel(string myText)
        {        

            if (this.label2.InvokeRequired)
            {
                updateLabelCallback d = new updateLabelCallback(updateLabel);
                this.Invoke(d, new object[] { myText });
            }
            else
            {
                this.label2.Text = myText;
            }
        }
        private void addDelayButton_Click(object sender, EventArgs e)
        {
            if (currDelay < 300)
            {
                currDelay += 10;
            }
            label1.Text = (currDelay).ToString();
        }

        private void removeDelayButton_Click(object sender, EventArgs e)
        {
            if(currDelay > 1)
            {
                currDelay -= 10;
            }
            label1.Text = (currDelay).ToString();
        }
    }
}