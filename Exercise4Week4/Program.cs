using Exercise4Week4;

var myList = new SequenceManager();

myList.SetSorting((a, b) => a.CompareTo(b));
myList.AddFilter(v => v % 2 == 0);

myList.Append(5);
myList.Append(2);
myList.Append(8);
myList.Append(1);
myList.Append(4);

myList.Print();
myList.PrintReverse();