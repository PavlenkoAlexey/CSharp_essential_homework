namespace Task_3
{
    class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book()
        {
            title = new Title();
            author = new Author();
            content = new Content();
        }
        public Book(string title) 
        {
            this.title = new Title
            {
                Content = title
            };
            author = new Author();
            content = new Content();
        }
        public void Show() 
        {
            title.Show();
            author.Show();
            content.Show();
        }
        public string Title
        {
            set => title.Content = value;
        }
        public string Author
        {
            set => author.Content = value;
        }
        public string Content
        {
            set => content.Content1 = value;
        }

    }
}
