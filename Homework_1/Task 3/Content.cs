using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Content
    {
        private string content;
        public string Content1
        {
            get => content ?? "content is empty";
            set => content = value;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content1);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
