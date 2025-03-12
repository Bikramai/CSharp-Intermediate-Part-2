using System;

namespace AccessModifiers
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; } // Fixed the type declaration

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }
}
