﻿string[] M; 						                        // Пустая строка М 
            Console.WriteLine("Введите массив строк через пробел"); 
string stroka = Console.ReadLine(); 						// Ввод массива строк с клавиатуры
            M = stroka.Split(' ');							// Разделение ввода по символу ' ' (пробел) 
            var result = new string[M .Length];						// Переменной result присваем определяемую 
var realSize = 0;									
            foreach (var value in M )						// Циклическое обращение к элементам массива М
            {
                if (value.Length <= 3)						// Проверка условия длинны строки (элемента массива)
                {
                    result[realSize] = value;						// Элемент добавляется в новую коллекцию
                    realSize++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));		// Вывод полученного результата
            Console.ReadKey(true);