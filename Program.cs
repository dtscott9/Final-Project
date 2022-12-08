using System.Collections;

using module_3;


Console.WriteLine("\n=========== PROBLEM 1===========");
Stack<int> intStack = new Stack<int>();

intStack.Push(1);
intStack.Push(2);
intStack.Push(3);
intStack.Push(4);
intStack.Push(5);
intStack.Push(6);

Stack<int> sumStack = new Stack<int>();

while (intStack.Count > 0) {
    int num1 = intStack.Pop();
    int num2 = intStack.Pop();

    int sum = num1 + num2;

    sumStack.Push(sum);
}

Console.WriteLine(String.Join(",", sumStack.Reverse()));

Console.WriteLine("\n=========== PROBLEM 2 ===========");

string [] words = {"lean", "cat", "lane", "tab", "angel", "angle"};

int anagramCount() {
    int count = 0;
    List<string>newWords = words.ToList();
    HashSet<string>anagrams = new HashSet<string>();
    foreach(string word in newWords) {

        char[] w = word.ToCharArray();
        Array.Sort(w);
        string sortWord = new string(w);
        Console.WriteLine(sortWord);
        anagrams.Add(sortWord);
    }

    
    Console.WriteLine(string.Join(",", anagrams));

    count = newWords.Count - anagrams.Count;


    return count;
}

Console.WriteLine($"Total anagram count: {anagramCount()}");

Console.WriteLine("\n=========== PROBLEM 3 ===========");

BinarySearchTree tree = new BinarySearchTree();

tree.Insert(7);
tree.Insert(5);
tree.Insert(6);
tree.Insert(8);
tree.Insert(9);
tree.Insert(4);
tree.Insert(10);

Console.WriteLine(tree.GetHeight());
