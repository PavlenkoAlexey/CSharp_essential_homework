using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task
{
    abstract class PartOfDocument
    {
        protected string content;
        public string Content
        {
            get => content ?? "Nothing here...";
            set => content = value;
        }
        public abstract void Show();
    }

    class Title : PartOfDocument
    {
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;    
        }
    }
    class Body : PartOfDocument
    {
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    class Footer : PartOfDocument
    {
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}


