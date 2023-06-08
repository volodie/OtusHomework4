namespace OtusHomeWork4
{
    public class StackClass
    {
        int _size; // текущий размер стека
        List<string>? _data; // данные стека
        public StackClass(params string[] strings)
        {
            int tLength = strings.Length;
            _data = new List<string>(tLength);
            for (int i = 0; i < strings.Length; i++)
            {
                _data.Add(strings[i]);
            }
            _size = _data.Count;
        }
        // метод для получения размера стека
        public int Size()
        {
            return _size;
        }
        // добавление нового элемента
        public void Add(string item)
        {
            _data.Add(item);
            _size++;
        }
        // чтение главного элемента стека без удаления
        public string? Top()
        {
            // если данных нет, возвращаем null
            if (IsEmpty)
            {
                return null;
            }

            return _data[_size - 1];
        }
        // извлечение элемента
        public string? Pop()
        {
            var item = Top();
            if (item == null)
            {
                throw new Exception("Stack is empty");
            }
            else
            {
                _data.Remove(item);
                _size--;
                return item;
            }
        }
        public bool IsEmpty
        {
            get { return Size() == 0; }
        }
        public void Print()
        {
            foreach (var item in _data)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static StackClass Concat(params StackClass[] objs)
        {
            StackClass stacktemp1 = objs[0];
            int sizeStack = stacktemp1.Size();
            StackClass stacktemp = new StackClass() ;
            for (int i = 0; i < sizeStack; i++)
            {
                stacktemp.Add(stacktemp1.Pop());
            }

            for (int i = 1; i < objs.Length; i++)
            {
                stacktemp.Merge(objs[i]);
            }
            return stacktemp;
        }
    }
}