using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cezarcode
{
    class cezar
    {
        static void Main(string[] args)
        {
            int key = 1;            //количество сдвигов
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя" + "0123456789" + " " + ".,!?@#$%^&*()+-/[]:;=_";//работаю с русским алфавитом
            int numberwords = alphabet.Length; //количество знаков в алфавите
            Console.WriteLine("1 -> Зашифровать предложение \n2 -> Расшифровать предложение \n0 -> Выйти");
            int menu = Convert.ToInt32(Console.ReadLine());
            if (menu != 0)
            {
                Console.WriteLine("Введите предложение: ");
                String text = Console.ReadLine();
                char[] word = text.ToCharArray();
                Console.WriteLine("Введите шаг: ");
                key = Convert.ToInt32(Console.ReadLine());
                text = text.ToLower();
                String result = "";
                switch (menu)
                {
                    case 1:
                        for (int i = 0; i < text.Length; i++)//цикл перебора букв шифруемого слова
                        {
                            for (int j = 0; j < alphabet.Length; j++)//цикл сравнения каждой бкувы с алфавитом
                            {
                                if (word[i] == ' ' | word[i] == ',' | word[i] == '.' | word[i] == '!' | word[i] == '?' | word[i] == '@' | word[i] == '#' | word[i] == '$' | word[i] == '%' | word[i] == '^' | word[i] == '&' | word[i] == '*' | word[i] == '(' | word[i] == ')' | word[i] == '+' | word[i] == '-' | word[i] == '/' | word[i] == '[' | word[i] == ']' | word[i] == ':' | word[i] == ';' | word[i] == '=' | word[i] == '_')
                                {
                                    if (text[i] == alphabet[j]) // в случае совпадения создаем темп, где храню номер буквы со сдвигом
                                    {
                                        int temp = j;//номер буквы+сдвиг в темп
                                        while (temp >= numberwords)//чтобы темп не уходил за рамки алфавита
                                            temp -= numberwords;

                                        result = result + alphabet[temp];//заношу зашифрованную букву в переменную для ее хранения
                                    }
                                }
                                else
                                    if (word[i] == '0' | word[i] == '1' | word[i] == '2' | word[i] == '3' | word[i] == '4' | word[i] == '5' | word[i] == '6' | word[i] == '7' | word[i] == '8' | word[i] == '9')
                                    {
                                        if (text[i] == alphabet[j]) // в случае совпадения создаем темп, где храню номер буквы со сдвигом
                                        {
                                            int temp = j + key;//номер буквы+сдвиг в темп
                                            while (temp <= 32 || temp >= 43)//чтобы темп не уходил за рамки алфавита
                                                temp -= 10;

                                            result = result + alphabet[temp];//заношу зашифрованную букву в переменную для ее хранения
                                        }
                                    }
                                else
                                {
                                    if (text[i] == alphabet[j]) // в случае совпадения создаем темп, где храню номер буквы со сдвигом
                                    {
                                        int temp = j + key;//номер буквы+сдвиг в темп
                                        while (temp >= 33)//чтобы темп не уходил за рамки алфавита
                                            temp -= 33;

                                        result = result + alphabet[temp];//заношу зашифрованную букву в переменную для ее хранения
                                    }
                                }
                            }
                        }
                        Console.WriteLine("Зашифрованное предложение:" + result);
                        Console.ReadLine();
                        break;
                    case 2:
                        for (int i = 0; i < text.Length; i++)//цикл перебора букв шифруемого слова
                        {
                            for (int j = 0; j < alphabet.Length; j++)//цикл сравнения каждой бкувы с алфавитом
                            {
                                if (word[i] == ' ' | word[i] == ',' | word[i] == '.' | word[i] == '!' | word[i] == '?' | word[i] == '@' | word[i] == '#' | word[i] == '$' | word[i] == '%' | word[i] == '^' | word[i] == '&' | word[i] == '*' | word[i] == '(' | word[i] == ')' | word[i] == '+' | word[i] == '-' | word[i] == '/' | word[i] == '[' | word[i] == ']' | word[i] == ':' | word[i] == ';' | word[i] == '=' | word[i] == '_')
                                {
                                    if (text[i] == alphabet[j]) // в случае совпадения создаем темп, где храню номер буквы со сдвигом
                                    {
                                        int temp = j;//номер буквы+сдвиг в темп
                                        while (temp >= numberwords)//чтобы темп не уходил за рамки алфавита
                                            temp -= numberwords;

                                        result = result + alphabet[temp];//заношу зашифрованную букву в переменную для ее хранения
                                    }
                                }
                                else
                                    if (word[i] == '0' | word[i] == '1' | word[i] == '2' | word[i] == '3' | word[i] == '4' | word[i] == '5' | word[i] == '6' | word[i] == '7' | word[i] == '8' | word[i] == '9')
                                {
                                    if (text[i] == alphabet[j]) // в случае совпадения создаем темп, где храню номер буквы со сдвигом
                                    {
                                        int temp = j - key;//номер буквы+сдвиг в темп
                                        while (temp <= 32 || temp >= 43)//чтобы темп не уходил за рамки алфавита
                                            temp += 10;

                                        result = result + alphabet[temp];//заношу зашифрованную букву в переменную для ее хранения
                                    }
                                }
                                else
                                {
                                    if (text[i] == alphabet[j]) // в случае совпадения создаем темп, где храню номер буквы со сдвигом
                                    {
                                        int temp = j - key;//номер буквы+сдвиг в темп
                                        while (temp < 0 || temp >= 33)//чтобы темп не уходил за рамки алфавита
                                            temp += 33;

                                        result = result + alphabet[temp];//заношу зашифрованную букву в переменную для ее хранения
                                    }
                                }
                            }
                        }
                        Console.WriteLine("Расшифрованное предложение:" + result);
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}