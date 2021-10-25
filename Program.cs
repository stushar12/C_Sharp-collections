using System;
using System.Collections;

namespace Generic_Datatypes
{
	class NonGeneric
	{
		public void HashTable()
		{
			var juices = new Hashtable();
			// OR
			//Hashtable juices = new Hashtable();

			string input = "";

			while (input != "end")
			{
				Console.WriteLine("Do you want to continue or end");
				input = Console.ReadLine();

				if (input != "end")
				{
					Console.WriteLine("Enter type of juice");
					string juice = Console.ReadLine();

					if (juices.ContainsKey(juice))
					{
						int count = (int)juices[juice];
						juices[juice] = ++count;
					}
					else
					{
						juices.Add(juice, 1);
					}
				}

			}

			var list = new SortedList();

			foreach (DictionaryEntry str in juices)
			{
				Console.WriteLine(str.Key + ": " + str.Value);
			}


			//foreach (DictionaryEntry str in juices)
			//{
			//	list.Add(str.Key, str.Value);
			//}
			//foreach(DictionaryEntry str in list)
			//{
			//	Console.WriteLine(str.Key + ":" + str.Value);
			//}

			int bill = 0;

			foreach (DictionaryEntry str in juices)
			{
				if ((string)str.Key == "apple")
				{
					bill = bill + (int)str.Value * 20;
				}
				else if ((string)str.Key == "watermelon")
				{
					bill = bill + (int)str.Value * 30;
				}
				else if ((string)str.Key == "mango")
				{
					bill = bill + (int)str.Value * 40;
				}
			}

			Console.WriteLine("Total Bill is: " + bill);
		}


		public void ArrayList()
		{
			var list = new ArrayList();

			for (int i = 0; i < 10; i++)
			{

				list.Add(i);
			}

			for (int i = 0; i < list.Count; i++)
			{
				Console.Write(list[i] + " ");
			}
			list.Reverse();
			list.Sort();
			Console.WriteLine();
			for (int i = 0; i < list.Count; i++)
			{
				Console.Write(list[i] + " ");
			}




		}


		public void SortedList()
		{
			var list = new SortedList();

			list.Add("mango", 1);
			list.Add("apple", 2);
			list.Add("watermelon", 1);

			foreach (DictionaryEntry str in list)
			{
				Console.WriteLine(str.Key + ":" + str.Value);
			}

		}


		public void Stack()
		{
			var stack = new Stack();

			stack.Push("mango");
			stack.Push(1);
			stack.Push(2);
			stack.Push("apple");

			foreach (var item in stack)
			{
				Console.WriteLine(item);
			}
			//Console.WriteLine(stack.Peek());
		}


		public void BitArray()
		{
			var bitArray = new BitArray(5);

			bool val = true;
			for (int i = 0; i < 5; i++)
			{
				bitArray[i] = val;
				val = !val;
			}

			foreach (var item in bitArray)
			{
				Console.WriteLine(item);
			}

		}


		public void Queue()
		{
			var queue = new Queue();
			queue.Enqueue(10);
			queue.Enqueue("Mango");
			queue.Enqueue("20");
			queue.Enqueue(40);


			while (queue.Count != 0)
			{
				Console.WriteLine(queue.Peek());
				queue.Dequeue();
			}
		}
	}

	class Generic
	{

	}

	class Program
	{
		static void Main(string[] args)
		{
			NonGeneric obj = new NonGeneric();
			//obj.HashTable();
			//obj.ArrayList();
			//obj.SortedList();
			//obj.Stack();
			//obj.BitArray();
			//obj.Queue();
		}
	}
}
