// See https://aka.ms/new-console-template for more information
using System.Collections;

ArrayList al = new ArrayList();

Console.WriteLine("Adding some numbers:");
al.Add(45);
al.Add(78);
al.Add(33);
al.Add(56);
al.Add(12);
al.Add(23);
al.Add(9);

Console.WriteLine("Capacity: {0} ", al.Capacity);
Console.WriteLine("Count: {0}", al.Count);

Console.Write("Content: ");
foreach (int i in al)
{
    Console.Write(i + " ");
}

Console.WriteLine();
Console.Write("Sorted Content: ");
al.Sort();
foreach (int i in al)
{
    Console.Write(i + " ");
}
Console.WriteLine();
Console.ReadKey();

//Hashtable
Hashtable ht = new Hashtable();

ht.Add("001", "Zara Ali");
ht.Add("002", "Abida Rehman");
ht.Add("003", "Joe Holzner");
ht.Add("004", "Mausam Benazir Nur");
ht.Add("005", "M. Amlan");
ht.Add("006", "M. Arif");
ht.Add("007", "Ritesh Saikia");

if (ht.ContainsValue("Nuha Ali"))
{
    Console.WriteLine("This student name is already in the list");
}
else
{
    ht.Add("008", "Nuha Ali");
}

// Get a collection of the keys.
ICollection key = ht.Keys;

foreach (string k in key)
{
    Console.WriteLine(k + ": " + ht[k]);
}
Console.ReadKey();

//SortedList
SortedList sl = new SortedList();

sl.Add("001", "Zara Ali");
sl.Add("002", "Abida Rehman");
sl.Add("003", "Joe Holzner");
sl.Add("004", "Mausam Benazir Nur");
sl.Add("005", "M. Amlan");
sl.Add("006", "M. Arif");
sl.Add("007", "Ritesh Saikia");

if (sl.ContainsValue("Nuha Ali"))
{
    Console.WriteLine("This student name is already in the list");
}
else
{
    sl.Add("008", "Nuha Ali");
}

// get a collection of the keys. 
ICollection key1 = sl.Keys;

foreach (string k in key1)
{
    Console.WriteLine(k + ": " + sl[k]);
}
Console.ReadKey();

//Stack
Stack st = new Stack();

st.Push('A');
st.Push('M');
st.Push('G');
st.Push('W');

Console.WriteLine("Current stack: ");
foreach (char c in st)
{
    Console.Write(c + " ");
}
Console.WriteLine();

st.Push('V');
st.Push('H');
Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
Console.WriteLine("Current stack: ");

foreach (char c in st)
{
    Console.Write(c + " ");
}

Console.WriteLine();

Console.WriteLine("Removing values ");
st.Pop();
st.Pop();
st.Pop();

Console.WriteLine("Current stack: ");
foreach (char c in st)
{
    Console.Write(c + " ");
}
Console.ReadKey();

//Queue
Queue q = new Queue();

q.Enqueue('A');
q.Enqueue('M');
q.Enqueue('G');
q.Enqueue('W');

Console.WriteLine("Current queue: ");
foreach (char c in q) Console.Write(c + " ");

Console.WriteLine();
q.Enqueue('V');
q.Enqueue('H');
Console.WriteLine("Current queue: ");
foreach (char c in q) Console.Write(c + " ");

Console.WriteLine();
Console.WriteLine("Removing some values ");
char ch = (char)q.Dequeue();
Console.WriteLine("The removed value: {0}", ch);
ch = (char)q.Dequeue();
Console.WriteLine("The removed value: {0}", ch);

Console.ReadKey();

//BitArray
//creating two  bit arrays of size 8
BitArray ba1 = new BitArray(8);
BitArray ba2 = new BitArray(8);

byte[] a = { 60 };
byte[] b = { 13 };

//storing the values 60, and 13 into the bit arrays
ba1 = new BitArray(a);
ba2 = new BitArray(b);

//content of ba1
Console.WriteLine("Bit array ba1: 60");

for (int i = 0; i < ba1.Count; i++)
{
    Console.Write("{0, -6} ", ba1[i]);
}
Console.WriteLine();

//content of ba2
Console.WriteLine("Bit array ba2: 13");

for (int i = 0; i < ba2.Count; i++)
{
    Console.Write("{0, -6} ", ba2[i]);
}
Console.WriteLine();
BitArray ba3 = new BitArray(8);
ba3 = ba1.And(ba2);

//content of ba3
Console.WriteLine("Bit array ba3 after AND operation: 12");

for (int i = 0; i < ba3.Count; i++)
{
    Console.Write("{0, -6} ", ba3[i]);
}
Console.WriteLine();
ba3 = ba1.Or(ba2);

//content of ba3
Console.WriteLine("Bit array ba3 after OR operation: 61");

for (int i = 0; i < ba3.Count; i++)
{
    Console.Write("{0, -6} ", ba3[i]);
}
Console.WriteLine();

Console.ReadKey();