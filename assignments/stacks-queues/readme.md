# Stacks and Queues

## Implementation

Using a List<T> and some additional variables, implement a Stack and a Queue in C#. For the sake of these exercises, keep an explicit track - i.e. the stack should have a pointer indicated where the next poppable value is, using List.Add to add a new item if necessary, incrementing a counter to keep track of the index (yes, I know this could be List.Length). 

For a queue, the queue should add to the end, dequeue should remove from the front - don't actually delete though, that's ``expensive''.
  
Then answer the following questions: 
  
1.  A letter means push and an asterisk means pop in the following sequence. Using your *stack* give the sequence of values returned by the pop operations when this sequence of operations is performed on an initially empty (LIFO) stack: `E A S * Y * Q U E * * * S T * * * I O * N * * *`
1.  Ensure the stack program from the previous question issues a warning and exits if the program attempts to pop an empty stack.
1.  A letter means push and an asterisk means pop in the following sequence. Using your *queue* give the sequence of values returned by the pop operations when this sequence of  operations is performed on an initially empty (FIFO) queue: `E A S * Y * Q U E * * * S T * * * I O * N * * *`
1.  Ensure the queue function from the previous question issues a warning and exits if the program attempts to pop an empty stack.
1. Suppose that an mixed sequence of push and pop operations are performed. The pushes push the integers 0 through 9 ***in order***; the pops print out the return value. Which of the following sequences could not occur?
    - 4 3 2 1 0 9 8 7 6 5
    - 4 6 8 7 5 3 2 9 0 1 
    - 2 5 6 7 4 8 9 3 1 0
    - 4 3 2 1 0 5 6 7 8 9  
1. Use a stack to take in a collection of string and then to print these out in reverse order. 
1. Write a program that reads in a positive integer and prints the binary representation of that integer.  Hint: division by 2.
  
  
## Graph Search Uses

***Warning***: definite extension stuff ... 
  
Often we're searching a space, in this context children means all the states from which you can move one state to the next. E.g. other squares on a chessboard, co-ordinates on a Cartesian grid, permutations of a selection of cards, etc.
  
### Breadth-First / Shortest Path

Needs a FIFO: using a queue, add all the children to the back of the queue. This means that all the paths of specific length are exhausted first, before queues of the next length. 

### Depth-First / Existential Proof

Needs a LIFO: using a stack, add all the children to the head item to the head of the list so as to dive deep first, then backtrack. 

## Extension Stack/Queue Questions

1. In the game of chess a knight can move between any two squares on the both. Use a queue to find the shortest path for a knight between two given squares. 
1. Use a queue to generate all possible binary numbers as strings. 
1. Implement a circular queue of size _n_, using integer variables to represent the front and the back. Insert more than _n_ variables and ensure that the appropriate, i.e. oldest, values are replaced. 
1. Consider a 2d array of integers, where the values represent different colour, consider how a queue might be used to 'flood fill' an area of the grid, i.e. starting from a given location with a target colour, all neighouring cells should be coloured the same colour. 
1. Given a mathematical statement using parantheses, use a stack to check if the pairs balance.  
1. Implement a postfix calculator using a stack. 
1. [Q3](https://olympiad.org.uk/papers/2018/bio/bio18-exam.pdf) on the 2018 BIO paper (``Serial Numbers'') is a classic Queue problem (albeit with a twist). 
