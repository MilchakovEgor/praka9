using disp_zadach;

Menu menu = new Menu();

int wind = 0;
int www = 0;
int w2 = 1;
int w3 = 0;

process.menushka(wind, www, w2);
while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    if (w2 == 1)
    {
        if (key.Key == ConsoleKey.Enter)
        {
            wind = 3;
            www = 4;
            process.menushka(wind, www, w2);
        }
        else if (key.Key == ConsoleKey.Backspace)
        {
            wind = 0;
            www = 0;
            Console.Clear();
            process.menushka(wind, www, w2);
        }

    }
    if (www == 0)
    {
        menu.strelki(key);
    }


}