# C#-String-Extensions
String pad left and right by bytes, align (cut &amp; pad) left and right by bytes.

# Language
C#

# How to Use
Download StringExtension.cs file and add it into project, or download StringExtension.dll and add referance to project, and using namespace CustomExtensions.

Four method:
* PadRightBytes
* PadLeftBytes
* AlignRightBytes
* AlignleftBytes

e.g.
```
static void Main(string[] args)
{
    string str = "ABCDE測試";
    int i = 8;
    str = str.AlignRightBytes(i, 'Z');
    Console.WriteLine(str);
    Console.ReadLine();
}
```
Result will be:
`ABCDE測Z`
