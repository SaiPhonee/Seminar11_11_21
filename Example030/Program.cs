﻿// 30. Показать кубы чисел, заканчивающихся на четную цифру

int n = 14;
for (int i = 1; i <= n; i++)
{
    int result = i * i * i;
    if (result % 2 == 0)
    {
        Console.WriteLine(result);
    }
}