using System;

namespace Lesson_04_DelegatesAndEvents
{
    class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)      //matches signature of delegate
        {
            Console.WriteLine("Mail has been sent...");
        }
    }
}