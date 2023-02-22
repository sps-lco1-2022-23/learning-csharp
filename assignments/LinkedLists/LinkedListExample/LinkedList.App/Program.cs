using System.Diagnostics;
using LinkedList.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        TestEmpty();
        TestCount();
        TestSum();
        TestToStringExplicit();

        Console.WriteLine("non tail");

        TestTEmpty();
        TestTCount();
        TestTSum();
        TestTToStringExplicit();

        Console.WriteLine("tail"); 


        Console.WriteLine("all tests passed");
    }

    public static void TestEmpty()
    {
        IntegerLinkedList ill = new IntegerLinkedList();
        Debug.Assert(0 == ill.Count);
    }

    public static void TestCount()
    {
        var ill = new IntegerLinkedList(5);
        ill.Append(7);
        ill.Append(9);
        Debug.Assert(3 == ill.Count);
    }

    public static void TestSum()
    {
        var ill = new IntegerLinkedList(5);
        ill.Append(7);
        ill.Append(9);
        Debug.Assert(21 == ill.Sum);
    }

    public static void TestToStringExplicit()
    {
        var ill = new IntegerLinkedList(5);
        ill.Append(7);
        ill.Append(9);
        Debug.Assert("{5, 7, 9}" == ill.ToString());
    }

        public static void TestTEmpty()
    {
        IntegerLinkedListWithTail ill = new IntegerLinkedListWithTail();
        Debug.Assert(0 == ill.Count);
    }

    public static void TestTCount()
    {
        var ill = new IntegerLinkedListWithTail(5);
        ill.Append(7);
        ill.Append(9);
        Debug.Assert(3 == ill.Count);
    }

    public static void TestTSum()
    {
        var ill = new IntegerLinkedListWithTail(5);
        ill.Append(7);
        ill.Append(9);
        Debug.Assert(21 == ill.Sum);
    }

    public static void TestTToStringExplicit()
    {
        var ill = new IntegerLinkedListWithTail(5);
        ill.Append(7);
        ill.Append(9);
        Debug.Assert("{5, 7, 9}" == ill.ToString());
    }
}