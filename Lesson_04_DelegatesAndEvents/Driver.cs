using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04_DelegatesAndEvents
{
    class Driver
    {
        static void Main(string[] args)
        {
            var video = new Video();

            var videoEncoder = new VideoEncoder();  //publisher

            var mailService = new MailService();    //subscriber
            var textService = new TextService();    //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;    //add a 'mail service' to the event handler object
            videoEncoder.VideoEncoded += textService.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.ReadKey();

        }
    }
}
