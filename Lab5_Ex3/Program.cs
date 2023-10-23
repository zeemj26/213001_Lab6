namespace Lab5_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public class WorkItem
        {
            private static int currentID;
            protected int ID { get; set; }
            protected string Title { get; set; }
            protected string Description { get; set; }
            protected TimeSpan jobLength { get; set; }
            public WorkItem() {
                ID = 0;
                Title = "Default title";
                Description = "Default Description ";
                jobLength = new TimeSpan();
            }
            public WorkItem( string Title, string desc, TimeSpan joblen) {
                this.ID = GetNextID();
                this.Title = Title;
                this.Description = desc;
                this.jobLength = joblen;
            }
            static WorkItem()
            {
                currentID= 0;
            }
            protected int GetNextID() { return ++ currentID; }

            public void Update (string title, TimeSpan joblen) 
            { this.Title = title;
                this.jobLength = joblen;
            }
            public override string ToString()
            {
                return String.Format($"{0} {1}", this.ID, this.Title);
            }
        }
    }
}