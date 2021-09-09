using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04_DelegatesAndEvents
{
    class Video
    {
        public Video()
        {

        }
    }
    class VideoEncoder
    {
        public delegate void VideoEncoderEventHandler(object source, EventArgs args);   //signature event methods

        public event VideoEncoderEventHandler VideoEncoded;     //name of the event handler object

        public void Encode(Video video)
        {
            Console.WriteLine("Video is encoded...");

            OnVideoEncoded();       //calls the event 
        }
        protected virtual void OnVideoEncoded()     //match the methods that will be called
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);        //send event handler to methods
            }
        }

    }

    class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)      //matches signature of delegate
        {
            Console.WriteLine("Mail has been sent...");
        }
    }

    class TextService
    {
        public void OnVideoEncoded(object source, EventArgs e)      //matches signature of delegate
        {
            Console.WriteLine("Text has been sent...");
        }
    }

    

    class Driver
    {
        static void Main(string[] args)
        {
            var video = new Video();
            var videoEncoder = new VideoEncoder();  //publisher
            var mailService = new MailService();    //subscriber
            var textService = new TextService();    //another subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;    //add a 'mail service' to the even handler object
            videoEncoder.VideoEncoded += textService.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.ReadKey();

        }
    }
}
