# Unit 1: Stacks

Imagiane that you are washing dirty plates that have been left in the sink. You wash one plate, and then set it to the side. After you wash each subsequent plate, you put it on top of the previously washed one. Pretty soon, you have a stack of clean plates.

In programming, we use a data structure called a stack to store data the same way we would those plates, one on top of the next.

## Stack Operators

Going back to our clean plates example, everytime we wash a new plate and add it to the stack, it's added to the top, in programming we refer to the top of the stack as the back. If we wanted to take a plate off the stack, it wouldn't make much sense to take it from the bottom as the whole stack would collapse. We would still take it from the top. The bottom of a stack is known as the front of the stack in programming. To help us remember how stacks work, we can use the acronym "LIFO" or last in first out.

The main operators we use for stacks are Push and Pop. Push will add an item to the back of the stack, and Pop will take away an item from the back. Take a look at this diagram to help get a better idea of how it works.

![stack-diagram-1](images/Stack%20Diagram-1.png)

And here is an example of what the code might look like to create a stack:

```csharp
  //creating a stack
  Stack<int> stack = new Stack<int>();

  //adding to the top or back of the stack
  stack.Push(1);
  stack.Push(2);
  stack.Push(3);
  stack.Push(4);
  stack.Push(5);
  //The stack is now {1, 2, 3, 4, 5}

  //taking off the most recent item
  stack.Pop();
  //The stack is now back to {1, 2, 3, 4}
```

| **Operator** |                 **Description**                 | **Code**          |
| ------------ | :---------------------------------------------: | ----------------- |
| Push         | Will add a new item to the back or top of stack | stack.Push(value) |
| Pop          | Will remove the item from the back of the stack | stack.Pop()       |
| Peek         |  Will return the item at the top of the stack   | stack.Peek()      |

## Example

Say you are at a doctors office and are signing the new patient paper. As you finish a page, you move it to the side in its own stack. After you've finished each page, you now have a new stack where each page is signed, but the stack is in reverse order from how it started. How would this look in code form?

```csharp
using System.Collections;
//example problem

//We need to first create the original stack
Stack<string> paperWork = new Stack<string>();

paperWork.Push("doc1");
paperWork.Push("doc2");
paperWork.Push("doc3");
paperWork.Push("doc4");
paperWork.Push("doc5");

//Then we need to create a new stack for the reverse order
Stack<string> newPaperStack = new Stack<string>();

Console.WriteLine(String.Join(",", paperWork));
//Lets take of the item at the back of the stack and add it to the new
//stack using a loop

while (paperWork.Count > 0) {
    string document = paperWork.Pop();

    newPaperStack.Push(document);
}
```

## Problem to Solve
Given a stack of integers, take the top two items of a stack and add them together. Add the sum of those two numbers to a new stack. Do this until there is nothing left in the original stack. 

[Solution to Problem](Program.cs)

[Back to Welcome Page](welcome.md)
