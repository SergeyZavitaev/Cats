public class Cats
    {

    List<List<string>> cats = new List<List<string>>();
    //string[,] cats = new string[,] { { "TheFirstCat", "1" } };
    int count = 0;
    Random rand = new Random();

    //�������� ����� � �����
    public void Add(string name, string age)
    {
        //Array.Resize(ref cats, count + 1);
        cats.Add(new List<string>(2));
        cats[count] = new List<string>() { name, age };
        count++;
    }
    public void AddRandomCount( string[] names, int RandomCount=1)
    {
        for (int i=0;i < RandomCount; i++)
        {
            Add(names[rand.Next(1, names.Length)], rand.Next(1, 18).ToString()); //word
        }
    }


    //��������������
    public void ChangeName(int index, string NewName)
    {
        cats[index-1][0] = NewName;
    }
    public void ChangeAge(int index, string NewAge)
    {
        cats[index-1][1] = NewAge;
    }

    //��������� ������
    public string GetName(int index)
    {
        return cats[index - 1][0];
    }
    public string GetAge(int index)
    {
        return cats[index-1][1];
    }
    public int GetCount()
    {
        return count;
    }

    //������ � ��������
    public void WriteAllCatsToConsole()
    {
        for (int i = 1; i < GetCount()+1; i++)
        {
            Console.Write($"{i} - ���: {GetName(i)}, �������: {GetAge(i)}");
            Console.WriteLine("");
        }
    }
    public void WriteCatInfoToConsole(int index)
    {
        Console.Write($"���: {GetName(index)}, �������: {GetAge(index)}");
        Console.WriteLine("");
    }
}

        //�������� ����� �� ������ ����
        /*// ������� ������ ����, ������� �� ����� ������������.
        char[] letters = "����������������������������".ToCharArray();
        // �������� �����.
        string word = "";
        for (int j = 1; j <= rand.Next(2, 8); j++) //(int j = 1; j <= num_letters; j++)
        {
            // ����� ���������� ����� �� 0 �� 25
            // ��� ������ ����� �� ������� ����.
            int letter_num = rand.Next(0, letters.Length - 1);

            // �������� ������.
            word += letters[letter_num];
        }
        Console.WriteLine(word);*/