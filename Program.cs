using System;
using System.Collections;
using System.Collections.Generic;
using Generic_Datatypes;

namespace Generic_Datatypes
{
	class NonGeneric
	{

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


		public void HashTable()
		{
			var dictionary = new Hashtable();
			// OR
			//Hashtable dictionary = new Hashtable();

			string input = "";

			while (input != "end")
			{
				Console.WriteLine("Do you want to continue or end");
				input = Console.ReadLine();

				if (input != "end")
				{
					Console.WriteLine("Enter type of juice");
					string juice = Console.ReadLine();

					if (dictionary.ContainsKey(juice))
					{
						int count = (int)dictionary[juice];
						dictionary[juice] = ++count;
					}
					else
					{
						dictionary.Add(juice, 1);
					}
				}

			}

			var list = new SortedList();

			foreach (DictionaryEntry item in dictionary)
			{
				Console.WriteLine(item.Key + ": " + item.Value);
			}


			//foreach (DictionaryEntry item in dictionary)
			//{
			//	list.Add(item.Key, item.Value);
			//}
			//foreach(DictionaryEntry item in list)
			//{
			//	Console.WriteLine(item.Key + ":" + item.Value);
			//}

			int bill = 0;

			foreach (DictionaryEntry item in dictionary)
			{
				if ((string)item.Key == "apple")
				{
					bill = bill + (int)item.Value * 20;
				}
				else if ((string)item.Key == "watermelon")
				{
					bill = bill + (int)item.Value * 30;
				}
				else if ((string)item.Key == "mango")
				{
					bill = bill + (int)item.Value * 40;
				}
			}

			Console.WriteLine("Total Bill is: " + bill);
		}


		public void SortedList()
		{
			var list = new SortedList();

			list.Add("mango", 1);
			list.Add("apple", 2);
			list.Add("watermelon", 1);

			foreach (DictionaryEntry item in list)
			{
				Console.WriteLine(item.Key + ":" + item.Value);
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
		public void List()
		{
			var list= new List<int>();
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


		public void Dictionary()
		{
			var dictionary = new Dictionary<string, int>();
			string input = "";

			while (input != "end")
			{
				Console.WriteLine("Do you want to continue or end");
				input = Console.ReadLine();

				if (input != "end")
				{
					Console.WriteLine("Enter type of juice");
					string juice = Console.ReadLine();

					if (dictionary.ContainsKey(juice))
					{
						int count = (int)dictionary[juice];
						dictionary[juice] = ++count;
					}
					else
					{
						dictionary.Add(juice, 1);
					}
				}

			}

			var list = new SortedList<string,int>();

			foreach(var item in dictionary)
			{
				Console.WriteLine(item.Key + ": " + item.Value);
			}


			int bill = 0;

			foreach(var item in dictionary)
			{
				if ((string)item.Key == "apple")
				{
					bill = bill + (int)item.Value * 20;
				}
				else if ((string)item.Key == "watermelon")
				{
					bill = bill + (int)item.Value * 30;
				}
				else if ((string)item.Key == "mango")
				{
					bill = bill + (int)item.Value * 40;
				}
			}

			Console.WriteLine("Total Bill is: " + bill);
		}


		public void SortedList()
		{
			var list = new SortedList<string, int>();
			// OR
			//SortedList<string, int> list = new SortedList<string, int>();

			list.Add("mango", 1);
			list.Add("apple", 2);
			list.Add("watermelon", 1);

			foreach (var item in list)
			{
				Console.WriteLine(item.Key + ":" + item.Value);
			}

		}


		public void Stack()
		{
			var stack = new Stack<int>();

			stack.Push(1);
			stack.Push(2);
			stack.Push(10);
			stack.Push(5);

			foreach (var item in stack)
			{
				Console.WriteLine(item);
			}
			//Console.WriteLine(stack.Peek());
		}


		public void Queue()
		{
			var queue = new Queue<int>();
			queue.Enqueue(10);
			queue.Enqueue(40);
			queue.Enqueue(20);
			queue.Enqueue(30);

			while (queue.Count != 0)
			{
				Console.WriteLine(queue.Peek());
				queue.Dequeue();
			}
		}


		public void Hashset()
		{
			var hashset = new HashSet<int>();
			hashset.Add(10);
			hashset.Add(40);
			hashset.Add(20);
			hashset.Add(10);
			hashset.Add(30);
			hashset.Add(20); 
			hashset.Add(40);
			hashset.Add(50);
			hashset.Add(20);
			hashset.Add(30);

			foreach(var item in hashset)
			{
				Console.WriteLine(item);
			}
		}
	}

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


		Generic obj1 = new Generic();
		//obj1.List();
		//obj1.Dictionary();
		//obj1.SortedList();
		//obj1.Stack();
		//obj1.Queue();
		//obj1.Hashset();

	}
	}
