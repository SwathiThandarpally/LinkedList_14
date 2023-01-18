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
            Console.WriteLine("----------------------------------------");
            //UC_4
            InsertingBetweenUC_4 inserting = new InsertingBetweenUC_4();
            inserting.Add(56);
            inserting.Add(70);
            inserting.InsertAtParticularPosition(2,30);
            inserting.Display();
            Console.ReadKey();
            Console.WriteLine("----------------------------------------");
            //UC_5
            DeleteFirstValueUC_5 deleteFirst = new DeleteFirstValueUC_5();
            deleteFirst.Add(56);
            deleteFirst.Add(30);
            deleteFirst.Add(70);
            Console.WriteLine("Displaying After Deleting First Value");
            deleteFirst.RemoveFirstNode();
            deleteFirst.Display();
            Console.WriteLine("----------------------------------------");
            //UC_6
            DeleteLastValueUC_6 deleteLast = new DeleteLastValueUC_6();
            deleteLast.Add(56);
            deleteLast.Add(30);
            deleteLast.Add(70);
            Console.WriteLine("Displaying After Deleting Last Value");
            deleteLast.RemovaLastNode();
            deleteLast.Display();
            Console.WriteLine("----------------------------------------");
            //UC_7
            FindNodeUC_7 findNode = new FindNodeUC_7();
            Console.WriteLine("Displaying Finding Node");
            findNode.Add(56);
            findNode.Add(30);
            findNode.Add(70);
            findNode.Search(30);
            findNode.Display();
            Console.WriteLine("----------------------------------------");
            //UC_8
            InsertValueUC_8 insertValue = new InsertValueUC_8();
            insertValue.Add(56);
            insertValue.Add(30);
            insertValue.Add(40);
            insertValue.Add(70);
            insertValue.Display();





        }
    }
}