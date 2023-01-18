namespace LinkedList_14
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");
            //UC_1
            SimpleLinkedListUC_1 simple = new SimpleLinkedListUC_1();
            simple.Add(56);
            simple.Add(30);
            simple.Add(70);
            Console.WriteLine("----------------------------------------");
            //UC_2
            AddingLinkedListUC_2 adding = new AddingLinkedListUC_2();
            adding.add(70);
            Console.WriteLine("Inserting 30");
            adding.add(30);
            Console.WriteLine("Inserting 56");
            adding.add(56);
            adding.Display();
            Console.WriteLine("Displaying After Adding");
            Console.WriteLine("----------------------------------------");
            //UC_3
            AppendingUC_3 appending = new AppendingUC_3();
            appending.Append(56);
            appending.Append(30);
            appending.Append(70);
            appending.Display();
        }
    }
}