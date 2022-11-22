using System.Collections;

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


