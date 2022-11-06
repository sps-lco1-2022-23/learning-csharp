# binary-files
Using bitwise operators and Binary file formats.  

## Background 
We've been looking at using the `&`, `|` and `^` operators to perform bitwise operators on integer values (stored in binary, displayed in denary). 

The BMP file format is summarised [here](http://www.fastgraph.com/help/bmp_header_format.html) and in more detail [here](http://www.dragonwins.com/domains/getteched/bmp/bmpfileformat.htm).

## Sample C# 

```csharp
using System;
using System.IO;

namespace BitmapFiles.App
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] logo = File.ReadAllBytes("sps.bmp");
            byte first = logo[0];
            byte second = logo[1];

            char b = 'B';
            char m = 'M';

            int res1 = first ^ (byte)b;
            int res2 = second ^ (byte)m;
        }
    }
}
```

There is also some [example code](https://gist.github.com/spscah/05af83491588b54ebbab9455ef1c1bcb). 


## Tasks 

Using the System.File object (and its ReadAllBytes function) unpack this bitmap file and summarise its header's data.

The code should first validate that it is actually a bitmap. 

This summary should include: dimensions, colour summary and so on. 

## Extension

### 1. Steganography 

[Steganography](https://en.wikipedia.org/wiki/Steganography) is the practice of hiding a message within a larger object. 

Create two functions: the first should take a bitmap (i.e. the name of a file( and a word and, according to optional parameters, rewrite the bitmap file, 'hiding' the word in the outputted file. The other function should take in the name of the written file (and the optional parameters) and return the word that was hidden.

At the primary level, changing a particular byte somewhere in the image to an ascii value of a character would suffice, but it is likely to end up with an obvious flaw in the image.

At a secondary level, you should be able to change individual bits - which would be less visible to the human eye.

### 2. With a JPG 

Do the same but for the attached JPG file.
