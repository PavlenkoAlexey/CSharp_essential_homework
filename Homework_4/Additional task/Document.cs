using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task
{
    class Document
    {
        readonly Title title;
        readonly Body body;
        readonly Footer footer;

        public Document(Title title, Body body, Footer footer)
        {
            this.title = title;
            this.body = body;
            this.footer = footer;
        }

        public void Show()
        {
            title.Show();
            body.Show();
            footer.Show();
        }

    }
}
