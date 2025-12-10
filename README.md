# LinkedLists

A custom implementation of a singly linked list data structure in C#. This project was built to understand the fundamentals of linked lists and practice common algorithms and techniques used in data structures.

## Features

### Basic Operations
- **AddFirst(int value)** - Adds a node at the beginning of the list
- **AddLast(int value)** - Adds a node at the end of the list
- **DeleteFirst()** - Removes the first node from the list
- **DeleteLast()** - Removes the last node from the list

### Search & Utility
- **IndexOf(int value)** - Returns the index of the first occurrence of a value, or -1 if not found
- **Contains(int value)** - Checks if a value exists in the list
- **Size()** - Returns the number of nodes in the list
- **Print()** - Displays the list in a readable format: `[10, 20, 30]`
- **ToArray()** - Converts the linked list to an integer array

### Advanced Algorithms
- **reverse()** - Reverses the linked list in-place using an iterative approach
- **getKthFromTheEnd(int k)** - Finds the k-th node from the end using the two-pointer technique
- **printMiddle()** - Prints the middle element(s) using the fast/slow pointer technique (handles both odd and even-length lists)
- **hasLoop()** - Detects if the list contains a cycle using Floyd's Cycle Detection Algorithm

## Usage Example

```csharp
var list = new LinkedLists.LinkedList();

list.AddLast(10);
list.AddLast(20);
list.AddLast(30);
list.Print();  // Output: [10, 20, 30]

list.reverse();
list.Print();  // Output: [30, 20, 10]

Console.WriteLine(list.getKthFromTheEnd(2));  // Output: 20
list.printMiddle();  // Output: 20
```

## Requirements

- .NET 9.0 SDK


## Notes

This implementation uses a singly linked list structure where each node contains a value and a reference to the next node. The list maintains references to both the first and last nodes for efficient insertion operations.

