/*Random rd = new Random();

int row = 9;
int[,] triangle = new int[row, row];
const int cellWidth = 3;

void FillTriangle()
{
    for(int i =0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] =
                triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void PrintTriange()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0)
            {
                Console.Write($"{triangle[i, j],cellWidth}");
            }
        }
        Console.WriteLine();
    }
}

void Magic()
{
    int col = cellWidth * row;
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
            //if (triangle[i, j] % 2!= 0) Console.Write($"*");
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}
*/

namespace ConsoleVS
{
    class Programm
    {

        static public void Main(string[] args)
        {
            string[] names = new string[] 
            {"Вася","Петя","Блэки","Винтер","Павло","Матисс","Бизе",
                "Ромео","Оливер","Руфус","Симба","Дина","Феликс","Том",
                "Джерри","Фрикаделькин","Молния","Луна","Диана","Хлоя",
                "Мурмыч","Петти","Паштет","Пеперс","Леопольд","Саймон",
                "Валли","Гудини","Пушок","Намаслиник","Царапин","Масяня",
                "Матильда","Борис","Иосиф","Йорик","Кузьмя","Кузя","Филя",
                "Яша","Кеша","Шон","Барни","Мишель","Грейс","Оллистер","Крейн",
                "Элис","Джессика","Мия","Соломонова","Симова","Клеопарта",
                "Маслинка","Черныш","Уголёк","Веснушка","Залта","Ласточка",
                "Злата","Санни-Родари","Белка","Солька","Тихоня","Цезарь",
                "Пружинка","Зена","Искринка","Тимон","Бро","Кубик","Бусинка",
                "Кыся","Чучиня","Пуля","Сакура","Пуговка","Пряник","Коржик-Рожик",
                "Бублик","Царьмейстер","Фисташка","Куриношкова","Ириска",
                "Тыковка","Паштетинька","Корица","Редиска","Пушнинка","Марсель",
                "Сахара","Орлеан","Леон","Барселонка","Ямаха","Амстел"};

            Random rand = new Random();
            Cats cat = new();

            cat.Add("Петька", "2");
            cat.WriteCatInfoToConsole(1);
            cat.ChangeAge(1, "3");
            cat.WriteCatInfoToConsole(1);

            cat.Add("Rыжikъ", "5");
            cat.WriteCatInfoToConsole(2);
            cat.ChangeName(2,"Рыжик");
            cat.WriteCatInfoToConsole(2);

            cat.Add("Матроскин", "10");
            cat.WriteCatInfoToConsole(3);

            cat.AddRandomCount(names, 10);
            cat.WriteAllCatsToConsole();
        }
    }
}

    //Console.ReadLine();
    //FillTriangle();
    ////PrintTriange();
    //Console.ReadLine();
    //Magic();
    //Console.ReadLine();