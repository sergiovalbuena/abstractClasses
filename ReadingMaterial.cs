using System;

// Interface
interface IPrintable
{
    void availability(); 
}


class Book : IPrintable
{
    public void availability()
    {
        Console.WriteLine("๐  available as a Hard Copy");
    }
}
class Magazine : IPrintable
{
    public void availability()
    {
        Console.WriteLine("๐งพ Not available as a Hard Copy");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book myBook = new Book();  // Create a object
        myBook.availability();
        Magazine myMag = new Magazine();
        myMag.availability();
        
    }
}