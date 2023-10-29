namespace part3
{
    public class Program
    {
        static void Main()
        {
            int pro_key = 111, expert_key = 123;
            Console.Write("Enter the license key (Or press enter if it is not there): ");
            int? key = Convert.ToInt32(Console.ReadLine());

            if (key == expert_key)
            {
                ExpertDocumentWorker obj = new ExpertDocumentWorker();
                obj.OpenDocument();
                obj.SaveDocument();
                obj.EditDocument();
            }
            else if (key == pro_key)
            {
                ProDocumentWorker obj = new ProDocumentWorker();
                obj.OpenDocument();
                obj.SaveDocument();
                obj.EditDocument();
            }
            else
            {
                DocumentWorker obj = new DocumentWorker();
                obj.OpenDocument();
                obj.SaveDocument();
                obj.EditDocument();
            }
        }

        public class ExpertDocumentWorker : ProDocumentWorker
        {
            public override void SaveDocument()
            {
                Console.WriteLine("Документ сохранен в новом формате");
            }
        }
        public class ProDocumentWorker : DocumentWorker
        {
            public override void EditDocument()
            {
                Console.WriteLine("Документ отредактирован");
            }
            public override void SaveDocument()
            {
                Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
            }
        }
        public class DocumentWorker
        {
            public void OpenDocument()
            {
                Console.WriteLine("Документ открыт");
            }
            public virtual void EditDocument()
            {
                Console.WriteLine("Редактирование документа доступно в версии Pro");
            }
            public virtual void SaveDocument()
            {
                Console.WriteLine("Сохранение документа доступно в версии Pro");
            }
        }
    }
}
