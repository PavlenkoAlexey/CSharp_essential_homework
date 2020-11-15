using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] proKeys = { "228", "1337", "1488" };
            string[] expKeys = { "229", "1338", "1489" };
            
       
            Console.WriteLine("Введите ключ");
            string keyEntered = Console.ReadLine();

            bool pro = false, exp = false;

            // Проверка введен ли ключ про-версии
            foreach (string key in proKeys) 
            {
                if (key == keyEntered)
                {
                    pro = true;
                    break;
                }
            }

            // Проверка введен ли ключ эксперт-версии
            foreach (string key in expKeys)
            {
                if (key == keyEntered)
                {
                    exp = true;
                    break;
                }
            }

            //Создание соответствующего объекта с апкастом к DocumentWorker
            DocumentWorker document; 
            if (pro)
            {
                document = new ProDocumentWorker();
            }
            else if (exp)
            {
                document = new ExpertDocumentWorker();
            }
            else
            {
                document = new DocumentWorker();
            }

            document.DoAll(); 

            Console.ReadKey(); // Delay
        }
    }
}
