# Unit 2: Sets

Say you are an intern at a company that has a website for online shopping. You are given a record of every single purchase made in the Rexburg ID area, and your task is to extract customer data and make a list of each customer. Ideally, you should be able to just take the customer data off of each order and put that into a list, but the problem is you will have duplicates as some customers have multiple orders to their name. 

Instead of using a list or a stack to store this data, you could use a set. Sets are a type of data structure that do not allow duplicates. Unlike stacks, sets do not order their elements in a specific order such as FIFO or LIFO.

# Set Operators

Sets are similar to stacks in that you can add and remove from them. However, you are not tied to taking or adding to the back of a set. When you add to a set the value will be added to the end of the set, however you can remove a value from any index in a set. If you want to check to see if a set contains a certain value by using the constains method. 

| Operator |                Description                | Code              | Performance |
|----------|:-----------------------------------------:|-------------------|-------------|
| Add      | Will add a new value to the set           | set.Add(value)    | O(1)        |
| Remove   | Will remove a specified value from a set  | set.Remove(value) | O(1)        |
| Count    | Will return the number of values in a set | set.Count         | O(1)        |

Two other operators include include intersection and union, but these operators are used when comparing to sets. Intersection will return whichever values the two sets have in common, and union will combine the two sets but without any duplicates. Below is an example of what this may look like:

```csharp 
//This is how you create a set
var set = new HashSet<int>(){1, 2, 3, 4, 5};
var set1 = new HashSet<int>(){5, 6, 7, 8, 9};

//Use intersection to get the value the sets share
//Make sure to convert it back to a hash set
var intersection = set.Intersect(set1).ToHashSet(); //This will return 5

//Use Union to unite the two sets without duplicates
var unite = set.Union(set1).ToHashSet();
//This will return {1, 2, 3, 4, 5, 6, 7, 8, 9}
```

# Example

In some cases when you are given lists or arrays, you may need to filter out any duplicates that may be present so that the data is accuarate. In these cases, you can actually convert a list or array to a hashset to achieve the desired result. 

```csharp
string [] states = {"Idaho", "Arizona", "California", "Idaho"}; //Idaho appears twice

var statesFinal = new HashSet<string>(states);
//When printed to the console, this will display all of the states without any duplicates
```
# Problem to Solve

Given an array of strings, find all of the anagrams and return an int that represents the anagram count.

[Solution](Program.cs)


[Back to Welcome Page](welcome.md)
