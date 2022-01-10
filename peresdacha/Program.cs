using System;

public class zach1
{
    const string alfavit = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

    private string zxc(string text, int k)
    {
        var fullAlfavit = alfavit.ToLower();
        var letterQty = fullAlfavit.Length;
        var retVal = "";
        for (int i = 0; i < text.Length; i++)
        {
            var c = text[i];
            var index = fullAlfavit.IndexOf(c);
            if (index < 0)
            {
                retVal += c.ToString();
            }
            else
            {
                var codeIndex = (letterQty + index + k) % letterQty;
                retVal += fullAlfavit[codeIndex];
            }
        }

        return retVal;
    }

    public string Zashifrovka(string plainMessage, int key)
        => zxc(plainMessage, key);
    public string Rashifrovka(string shfrMessage, int key)
        => zxc(shfrMessage, -key);
}

class Program
{
    static void Main(string[] args)
    {
        var shfr = new zach1();
        Console.Write("Введите текст: ");
        var message = Console.ReadLine();
        Console.Write("Введите ключ: ");
        var Key = Convert.ToInt32(Console.ReadLine());
        var shfrText = shfr.Zashifrovka(message, Key);
        Console.WriteLine("Зашифрованное сообщение: {0}", shfrText);
        Console.WriteLine("Расшифрованное сообщение: {0}", shfr.Rashifrovka(shfrText, Key));
        Console.ReadKey();
    }
}