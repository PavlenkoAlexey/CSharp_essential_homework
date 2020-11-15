using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    abstract class AbstractHandler
    {
        abstract public void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML file opened");
        }
        public override void Create()
        {
            Console.WriteLine("XML file created");
        }
        public override void Change()
        {
            Console.WriteLine("XML file changed");
        }
        public override void Save()
        {
            Console.WriteLine("XML file saved");
        }
    }
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT file opened");
        }
        public override void Create()
        {
            Console.WriteLine("TXT file created");
        }
        public override void Change()
        {
            Console.WriteLine("TXT file changed");
        }
        public override void Save()
        {
            Console.WriteLine("TXT file saved");
        }
    }
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC file opened");
        }
        public override void Create()
        {
            Console.WriteLine("DOC file created");
        }
        public override void Change()
        {
            Console.WriteLine("DOC file changed");
        }
        public override void Save()
        {
            Console.WriteLine("DOC file saved");
        }
    }
}
