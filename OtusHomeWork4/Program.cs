
using OtusHomeWork4;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Стэк состоит из элементов: ");
        var s = new StackClass("a", "b", "c");
        PrintStack(s);
        Console.WriteLine($"size = {s.Size()}, Top = '{s.Top()}'");
        try
        {
            var deleted = s.Pop();
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size()}");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
        PrintStack(s);
        Console.WriteLine($"Добавляю элемент в стэк.");
        s.Add("d");
        PrintStack(s);
        Console.WriteLine($"size = {s.Size()}, Top = '{s.Top()}'");
        try
        {
            var deleted = s.Pop();
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size()}");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
        PrintStack(s);
        try
        {
            var deleted = s.Pop();
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size()}");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
        PrintStack(s);
        try
        {
            var deleted = s.Pop();
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size()}");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
        PrintStack(s);
        Console.WriteLine($"size = {s.Size()}, Top = {(s.Top() == null ? "null" : s.Top())}");
        try
        {
            var deleted = s.Pop();
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size()}");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
        PrintStack(s);

        Console.WriteLine("Использование класса расширения: ");
        var snew = new StackClass("a", "b", "c");
        snew.Merge(new StackClass("1", "2", "3"));
        PrintStack(snew);
        static void PrintStack(StackClass s)
        {
            s.Print();
            Console.WriteLine();
        }
    }
}

