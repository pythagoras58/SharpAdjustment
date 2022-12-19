// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string name = "Pytha";
Console.WriteLine(name.Length);
foreach(char c in name)
{
    Console.WriteLine(c);
}

// concatenation
string a = "Papa";
string b = "mama";


b = String.Join('.', a);
Console.WriteLine(b);

// Date TIme::
DateTime now= DateTime.Now;
Console.WriteLine(now.ToString());

DateTime today= DateTime.Today;
Console.WriteLine(today.ToString());

// creating files
const string fileName = "file.txt";
using (StreamWriter sw = File.CreateText(fileName))
{
    sw.WriteLine("File created");
}


// check if a file exists
if (File.Exists(fileName))
{
    Console.WriteLine("File Already FOund");
    File.Delete(fileName);
}
else
{
    using(StreamWriter stream = File.CreateText(fileName))
    {
        stream.WriteLine("New File Created");
    }
}