using System.Collections;

namespace AdvC_3_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            //LinkedList<int> Numbers = new LinkedList<int>();
            //Numbers.AddFirst(1);
            //Numbers.AddAfter(Numbers.First, 2);
            //Numbers.AddLast(3);
            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Stack
            //Stack<int> Numbers = new Stack<int>();
            //Numbers.Push(1);
            //Numbers.Push(2);
            //Numbers.Push(3);
            //Console.WriteLine(Numbers.Pop());
            //Console.WriteLine(Numbers.Pop());
            //Console.WriteLine(Numbers.Pop());
            //Console.WriteLine(Numbers.TryPop(out int LastNumber));
            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Queue
            //Queue<int> Numbers = new Queue<int>();
            //Numbers.Enqueue(1);
            //Numbers.Enqueue(2);
            //Numbers.Enqueue(3);
            //Console.WriteLine(Numbers.Dequeue());//1
            //Console.WriteLine(Numbers.Dequeue());//2
            //Console.WriteLine(Numbers.Dequeue());//3
            //Console.WriteLine(Numbers.TryDequeue(out int LastNumber));
            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region NonGeneric Collection - HashTable
            //Hashtable Note = new Hashtable();
            //Note.Add("Ahmed", 123);
            //Note.Add("Hamed", 748);
            //Note.Add("Abdelrahman", 234);
            //if (!Note.ContainsKey("Abdelrahman"))
            //    Note.Add("Abdelrahman", 999);
            //foreach (DictionaryEntry person in Note)
            //{
            //    Console.WriteLine($"{person.Key}");
            //}
            #endregion

            #region Generic Collection - Dictionary (HashTable)
            Dictionary<string, int> Note = new Dictionary<string, int>();
            Note.Add("Ahmed", 123);
            Note.Add("Omar", 342);
            Note.Add("Amany", 432);
            if (!Note.ContainsKey("Abdelrahman"))
                Note.Add("Abdelrahman", 999);
            foreach (KeyValuePair<string, int> person in Note)
            {
                Console.WriteLine($"{person.Key} :: {person.Value}");
            }
            #endregion

            #region Generic Collection - SortedDictionary (BST)
            //SortedDictionary<string, int> Note = new SortedDictionary<string, int>();
            //Note.Add("Omar", 444);
            //Note.Add("Ziad", 222);
            //Note.Add("Fady", 111);
            //foreach (var person in Note)
            //{
            //    Console.WriteLine($"{person.Key} :: {person.Value}");
            //}
            #endregion

            #region Generic Collection - SortedList (TwoArray)
            //SortedList<string, int> SortedNote = new SortedList<string, int>();
            //SortedNote.Add("Omar", 444);
            //SortedNote.Add("Ziad", 222);
            //SortedNote.Add("Fady", 111);
            //foreach (var person in SortedNote)
            //{
            //    Console.WriteLine($"{person.Key} :: {person.Value}");
            //}
            #endregion

            #region Generic Collection - HashSet (HashTable)
            //HashSet<int> Numbers = new HashSet<int>();
            //Numbers.Add(1);
            //Numbers.Add(2);
            //Numbers.Add(3);
            //Numbers.Add(1);
            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Generic Collection - SortedSet (BBST)
            //SortedSet<int> Numbers = new SortedSet<int>();
            //Numbers.Add(1);
            //Numbers.Add(2);
            //Numbers.Add(3);
            //Numbers.Add(1);
            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

        }
    }
}
