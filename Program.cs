using GenericTypes.Models;
// queue FiFo - first in first out
/*Queue<int> queue = new Queue<int>();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);



foreach (int item in queue)
{
    Console.WriteLine(item);
}
*/

//*********************************************

//stack LiFo - last in first out

/*Stack<int> ints= new Stack<int>();

ints.Push(33);
ints.Push(12);
ints.Push(87);
ints.Push(61);

ints.Pop();
foreach (var item in ints)
{
    Console.WriteLine(item);
}
*/

//*********************************************

//sortedlist - siralaryir . meselen a-z, reqemleri azdan coxa

//Dictionarylist - ise oldugu kimi saxlayir


SortedList<string, string> sorted = new SortedList<string, string>();

sorted.Add("Ru", "rub");
sorted.Add("tr", "tl");
sorted.Add("aze", "azn");

foreach (var item in sorted)
{
    Console.WriteLine(item.Key + ":" + item.Value);
}