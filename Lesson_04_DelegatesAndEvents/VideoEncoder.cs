using System;

namespace Lesson_04_DelegatesAndEvents
{
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
}