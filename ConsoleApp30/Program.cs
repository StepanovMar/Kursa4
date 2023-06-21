using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Создание расширяемой хеш-таблицы
        var table = new Dictionary<int, string>();

        // Добавление элементов в таблицу
        table.Add(1, "Яблоко");
        table.Add(2, "Банан");
        table.Add(3, "Вишня");

        // Поиск элемента в таблице
        int key = 3; // Сюда вписываем ключ 1,2,3 в зависимости, какая таблица нужна
        if (table.TryGetValue(key, out string value))
        {
            Console.WriteLine($"Элемент с ключом {key} найден: {value}");
        }
        else
        {
            Console.WriteLine($"Элемент с ключом {key} не найден");
        }

        Console.ReadKey();
    }
}