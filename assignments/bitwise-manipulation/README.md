# bitwise-manipulation

In C# we are used to using `&&` as a logical-AND. `||` as a logical-OR and `!` as a logical-NOT. These are used to combine Boolean values together in the normal way. 

We can use the single variants to perform *bitwise* operations, these operate on integers and will return the result of the operation on each related pair of bits, working from the least significant bits rightward, zero-padding where required.

Thus `7&5` would be 111 AND 101 which would result in 101, so 5. 

The `^` operator is the bitwise-XOR. 

Shifting is done with `<<` and `>>`, thus `7 << 2` would result in `11100`, so 28. Right shifting drops all the required bits, in effect ignoring any remainder. 

As with other operators, we can combine with the `=` symbol - thus ` x |= 1` is equivalent to `x = x | 1`.

These operations are summarised on [MSDN](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators).

## Tasks

These are on the Google doc (linked [here](https://docs.google.com/document/d/1DtPlooby54FZ0m4JfMGmsofFINrgJku2VUjyhd4mfeM/edit?usp=sharing) and on the Google Classroom). 
