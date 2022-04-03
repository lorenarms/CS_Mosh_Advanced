using System;

namespace Lesson_04_DelegatesAndEvents
{
    class TextService
    {
        public void OnVideoEncoded(object source, EventArgs e)      //matches signature of delegate
        {
            Console.WriteLine("Text has been sent...");
        }
    }
}