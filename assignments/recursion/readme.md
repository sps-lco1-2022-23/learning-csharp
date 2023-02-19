# Recursion

Using your notes (and the [slides](https://docs.google.com/presentation/d/12YeS_P_tVBnPn0KBtXZNWujoCCnGuY1Vlc-CZGv4Iao/edit?usp=sharing)) please attempt the tasks below.

Yes, I know that most can be done easily iteratively, perhaps with built-in functions, but that's not the point: **ALL** your functions should be recursive, _neither_ iterative _nor_ using built-in functions. 

## Questions

1. Compute the Factorial of a number `N`. `Fact(N) = N * (N - 1) * ... * 1`
1. Write a function for `multiply(a, b)`, where `a` and `b` are both positive integers, but you can only use the `+` or `-` operators.
4. Raise a double to an integer power: write a recursive function that allows raising to a negative integer power as well.
1. Amend the example to sum the first `-n` negative numbers as well as positive numbers, e.g. `SumToN(-3)` returns `-6`.
5. Find Greatest Common Divisor (GCD) of 2 numbers using recursion (hint: Euclid).
5. Write a recursive function to reverse a string. 
	1. Write a recursive function to reverse the words in a string, i.e., "cat is running" becomes "running is cat".
1. Check if a string is a palindrome 
2. For a given string return a list of all unique permutations. 
  1. do the same for any list 
7. **Medium hard** A word is considered *elfish* if it contains the letters: e, l, and f in it, in any order. For example, we would say that the following words are *elfih*: whiteleaf, tasteful, unfriendly,
and waffles, because they each contain those letters.
	- Write a predicate function (i.e. one that returns a Boolean) called `isElfish` that, given a word, tells us if that word is elfish or not.
	- Write a more generalised predicate function called `isXish` that, given two words, returns true if all the letters of the first word are contained in the second.
1. **Hard** Coin game: Alice and Bob are playing a game using a bunch of coins. The players pick several coins out of the bunch in turn. Each time a player is allowed to pick 1, 2 or 4 coins, and the player that gets the last coin is the winner. Assume that both players are very smart and he/she will try his/her best to work out a strategy to win the game. For example, if there are 2 coins and Alice is the first player to pick, she will definitely pick 2 coins and win. If there are 3 coins and Alice is still the first player
to pick, no matter she picks 1 or 2 coins, Bob will get the last coin and win the game. Given the number of coins and the order of players (which means the first and the second players to pick the
coins), you are required to write a function to calculate the winner of the game, and calculate how many diffierent strategies there are for he/she to win the game. You should use recursion to solve the problem, and the parameters are given to the function. ***You can assume that there are no more than 30 coins.*** 

You might use a `ValueTuple<string, int>` or `(string, int)' as the return type for this last question. 

Here are some sample calls to the function: 

```bash
pickcoin 1 alice bob
alice 1
pickcoin 2 bob alice
bob 1
pickcoin 3 alice bob
bob 2
pickcoin 10 alice bob
alice 22
pickcoin 25 alice bob
alice 3344
pickcoin 30 alice bob
bob 18272
```
