[assembly: SetCulture("en-US")]
namespace LAB02.Tests;

public class SolverTests
{

    // ---------- BLOCK 1 ----------

    [TestCase(29, "29C = 84.2F")]
    [TestCase(0, "0C = 32.0F")]
    [TestCase(-13, "-13C = 8.6F")]
    [TestCase(10, "10C = 50.0F")]
    [TestCase(100, "100C = 212.0F")]
    [TestCase(-40, "-40C = -40.0F")]
    [TestCase(37, "37C = 98.6F")]
    [TestCase(1, "1C = 33.8F")]
    [TestCase(15.5, "15.5C = 59.9F")]
    [TestCase(-1, "-1C = 30.2F")]
    public void Block1Task1Test(double c, string expected)
    {
        var result = Solver.CelsiusToFahrenheit(c);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(180, 75, "Рост: 180 см, Вес: 75 кг, ИМТ = 23.1")]
    [TestCase(170, 60, "Рост: 170 см, Вес: 60 кг, ИМТ = 20.8")]
    [TestCase(160, 50, "Рост: 160 см, Вес: 50 кг, ИМТ = 19.5")]
    [TestCase(190, 100, "Рост: 190 см, Вес: 100 кг, ИМТ = 27.7")]
    [TestCase(150, 45, "Рост: 150 см, Вес: 45 кг, ИМТ = 20.0")]
    [TestCase(200, 100, "Рост: 200 см, Вес: 100 кг, ИМТ = 25.0")]
    [TestCase(165, 70, "Рост: 165 см, Вес: 70 кг, ИМТ = 25.7")]
    [TestCase(155, 40, "Рост: 155 см, Вес: 40 кг, ИМТ = 16.6")]
    [TestCase(175, 90, "Рост: 175 см, Вес: 90 кг, ИМТ = 29.4")]
    [TestCase(180, 50, "Рост: 180 см, Вес: 50 кг, ИМТ = 15.4")]
    public void Block1Task2Test(double h, double w, string expected)
    {
        var result = Solver.CalculateBMI(h, w);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(9000, "9000 рублей = 3061 долларов")]
    [TestCase(4500, "4500 рублей = 1530 долларов")]
    [TestCase(180, "180 рублей = 61 долларов")]
    [TestCase(90, "90 рублей = 30 долларов")]
    [TestCase(0, "0 рублей = 0 долларов")]
    [TestCase(294, "294 рублей = 100 долларов")]
    [TestCase(588, "588 рублей = 200 долларов")]
    [TestCase(147, "147 рублей = 50 долларов")]
    [TestCase(29.4, "29.4 рублей = 10 долларов")]
    [TestCase(2.94, "2.94 рублей = 1 долларов")]
    public void Block1Task3Test(double r, string expected)
    {
        var result = Solver.RublesToDollars(r);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(3665, "3665 секунд = 1 ч 1 мин 5 сек")]
    [TestCase(3600, "3600 секунд = 1 ч 0 мин 0 сек")]
    [TestCase(60, "60 секунд = 0 ч 1 мин 0 сек")]
    [TestCase(59, "59 секунд = 0 ч 0 мин 59 сек")]
    [TestCase(7200, "7200 секунд = 2 ч 0 мин 0 сек")]
    [TestCase(0, "0 секунд = 0 ч 0 мин 0 сек")]
    [TestCase(1, "1 секунд = 0 ч 0 мин 1 сек")]
    [TestCase(3599, "3599 секунд = 0 ч 59 мин 59 сек")]
    [TestCase(86399, "86399 секунд = 23 ч 59 мин 59 сек")]
    [TestCase(86400, "86400 секунд = 24 ч 0 мин 0 сек")]
    public void Block1Task4Test(int s, string expected)
    {
        var result = Solver.ConvertSeconds(s);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(4, 6, 8, "Среднее арифметическое чисел 4, 6 и 8 = 6.00")]
    [TestCase(1, 2, 3, "Среднее арифметическое чисел 1, 2 и 3 = 2.00")]
    [TestCase(10, 20, 40, "Среднее арифметическое чисел 10, 20 и 40 = 23.33")]
    [TestCase(5, 2, 7, "Среднее арифметическое чисел 5, 2 и 7 = 4.67")]
    [TestCase(2, 4, 6, "Среднее арифметическое чисел 2, 4 и 6 = 4.00")]
    [TestCase(0, 0, 0, "Среднее арифметическое чисел 0, 0 и 0 = 0.00")]
    [TestCase(-5, 5, 10, "Среднее арифметическое чисел -5, 5 и 10 = 3.33")]
    [TestCase(-3, -6, -9, "Среднее арифметическое чисел -3, -6 и -9 = -6.00")]
    [TestCase(1.5, 2.5, 3.5, "Среднее арифметическое чисел 1.5, 2.5 и 3.5 = 2.50")]
    [TestCase(100, 200, 300, "Среднее арифметическое чисел 100, 200 и 300 = 200.00")]
    public void Block1Task5Test(double a, double b, double c, string expected)
    {
        var result = Solver.Average(a, b, c);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(1000, 15, "Цена: 1000, скидка: 15%, итоговая цена: 850.00")]
    [TestCase(2000, 10, "Цена: 2000, скидка: 10%, итоговая цена: 1800.00")]
    [TestCase(500, 20, "Цена: 500, скидка: 20%, итоговая цена: 400.00")]
    [TestCase(457, 8.5, "Цена: 457, скидка: 8.5%, итоговая цена: 418.16")]
    [TestCase(300, 0, "Цена: 300, скидка: 0%, итоговая цена: 300.00")]
    [TestCase(100, 50, "Цена: 100, скидка: 50%, итоговая цена: 50.00")]
    [TestCase(1000, 100, "Цена: 1000, скидка: 100%, итоговая цена: 0.00")]
    [TestCase(750, 25, "Цена: 750, скидка: 25%, итоговая цена: 562.50")]
    [TestCase(1200, 5, "Цена: 1200, скидка: 5%, итоговая цена: 1140.00")]
    [TestCase(99.9, 10, "Цена: 99.9, скидка: 10%, итоговая цена: 89.91")]
    public void Block1Task6Test(double p, double d, string expected)
    {
        var result = Solver.CalculateDiscountPrice(p, d);
        Assert.That(result, Is.EqualTo(expected));
    }


    // ---------- BLOCK 2 ----------

    [TestCase(1, "Месяц 1 - Зима")]
    [TestCase(4, "Месяц 4 - Весна")]
    [TestCase(7, "Месяц 7 - Лето")]
    [TestCase(10, "Месяц 10 - Осень")]
    [TestCase(-4, "Месяц -4 - Не существует")]
    [TestCase(2, "Месяц 2 - Зима")]
    [TestCase(3, "Месяц 3 - Весна")]
    [TestCase(6, "Месяц 6 - Лето")]
    [TestCase(9, "Месяц 9 - Осень")]
    [TestCase(13, "Месяц 13 - Не существует")]
    public void Block2Task1Test(int m, string expected)
    {
        var result = Solver.GetSeason(m);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(5, 5, 5, "Треугольник со сторонами 5, 5, 5 - равносторонний")]
    [TestCase(5, 5, 3, "Треугольник со сторонами 5, 5, 3 - равнобедренный")]
    [TestCase(3, 4, 5, "Треугольник со сторонами 3, 4, 5 - разносторонний")]
    [TestCase(7, 7, 10, "Треугольник со сторонами 7, 7, 10 - равнобедренный")]
    [TestCase(1, 2, 3, "Треугольник со сторонами 1, 2, 3 - не существует")]
    [TestCase(10, 10, 10, "Треугольник со сторонами 10, 10, 10 - равносторонний")]
    [TestCase(10, 8, 10, "Треугольник со сторонами 10, 8, 10 - равнобедренный")]
    [TestCase(4, 5, 6, "Треугольник со сторонами 4, 5, 6 - разносторонний")]
    [TestCase(2, 2, 5, "Треугольник со сторонами 2, 2, 5 - не существует")]
    [TestCase(7, 10, 5, "Треугольник со сторонами 7, 10, 5 - разносторонний")]
    public void Block2Task2Test(double a, double b, double c, string expected)
    {
        var result = Solver.GetTriangleType(a, b, c);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(3, 4, "Точка (3, 4) находится в I четверти")]
    [TestCase(-3, 4, "Точка (-3, 4) находится в II четверти")]
    [TestCase(-3, -4, "Точка (-3, -4) находится в III четверти")]
    [TestCase(3, -4, "Точка (3, -4) находится в IV четверти")]
    [TestCase(0, 6, "Точка (0, 6) находится на пересечении четвертей")]
    [TestCase(5, 5, "Точка (5, 5) находится в I четверти")]
    [TestCase(-5, 5, "Точка (-5, 5) находится в II четверти")]
    [TestCase(-5, -5, "Точка (-5, -5) находится в III четверти")]
    [TestCase(5, -5, "Точка (5, -5) находится в IV четверти")]
    [TestCase(0, 0, "Точка (0, 0) находится на пересечении четвертей")]
    public void Block2Task3Test(double x, double y, string expected)
    {
        var result = Solver.GetQuadrant(x, y);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(1, "Оценка 1 - Плохо")]
    [TestCase(2, "Оценка 2 - Неудовлетворительно")]
    [TestCase(3, "Оценка 3 - Удовлетворительно")]
    [TestCase(4, "Оценка 4 - Хорошо")]
    [TestCase(5, "Оценка 5 - Отлично")]
    [TestCase(6, "Оценки 6 не бывает")]
    [TestCase(0, "Оценки 0 не бывает")]
    [TestCase(-1, "Оценки -1 не бывает")]
    [TestCase(3, "Оценка 3 - Удовлетворительно")]
    [TestCase(4, "Оценка 4 - Хорошо")]
    public void Block2Task4Test(int g, string expected)
    {
        var result = Solver.GetGradeDescription(g);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(7, "7 час - Утро")]
    [TestCase(13, "13 час - День")]
    [TestCase(20, "20 час - Вечер")]
    [TestCase(2, "2 час - Ночь")]
    [TestCase(26, "26 час - Не существует")]
    [TestCase(6, "6 час - Утро")]
    [TestCase(12, "12 час - День")]
    [TestCase(18, "18 час - Вечер")]
    [TestCase(23, "23 час - Ночь")]
    [TestCase(-1, "-1 час - Не существует")]
    public void Block2Task5Test(int h, string expected)
    {
        var result = Solver.GetTimeOfDay(h);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(9000, "USD", "9000 RUB = 3000.00 USD")]
    [TestCase(10000, "EUR", "10000 RUB = 2857.14 EUR")]
    [TestCase(11000, "GBP", "11000 RUB = 2750.00 GBP")]
    [TestCase(0, "USD", "0 RUB = 0.00 USD")]
    [TestCase(5000, "ABC", "Неизвестная валюта")]
    [TestCase(3000, "USD", "3000 RUB = 1000.00 USD")]
    [TestCase(3500, "EUR", "3500 RUB = 1000.00 EUR")]
    [TestCase(4000, "GBP", "4000 RUB = 1000.00 GBP")]
    [TestCase(450, "usd", "450 RUB = 150.00 USD")]
    [TestCase(100, "", "Неизвестная валюта")]
    public void Block2Task6Test(double r, string cur, string expected)
    {
        var result = Solver.ConvertCurrency(r, cur);
        Assert.That(result, Is.EqualTo(expected));
    }


    // ---------- BLOCK 3 ----------

    [TestCase(58324, "Число: 58324, минимальная цифра: 2, максимальная цифра: 8")]
    [TestCase(111, "Число: 111, минимальная цифра: 1, максимальная цифра: 1")]
    [TestCase(9876, "Число: 9876, минимальная цифра: 6, максимальная цифра: 9")]
    [TestCase(-305, "Число: -305, минимальная цифра: 0, максимальная цифра: 5")]
    [TestCase(9, "Число: 9, минимальная цифра: 9, максимальная цифра: 9")]
    [TestCase(0, "Число: 0, минимальная цифра: 0, максимальная цифра: 0")]
    [TestCase(999, "Число: 999, минимальная цифра: 9, максимальная цифра: 9")]
    [TestCase(10203, "Число: 10203, минимальная цифра: 0, максимальная цифра: 3")]
    [TestCase(-86420, "Число: -86420, минимальная цифра: 0, максимальная цифра: 8")]
    [TestCase(5, "Число: 5, минимальная цифра: 5, максимальная цифра: 5")]
    public void Block3Task1Test(int n, string expected)
    {
        var result = Solver.GetMinMaxDigit(n);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(12345, "Перевёрнутое число: 54321")]
    [TestCase(100, "Перевёрнутое число: 1")]
    [TestCase(-987, "Перевёрнутое число: -789")]
    [TestCase(1010, "Перевёрнутое число: 101")]
    [TestCase(1, "Перевёрнутое число: 1")]
    [TestCase(0, "Перевёрнутое число: 0")]
    [TestCase(10, "Перевёрнутое число: 1")]
    [TestCase(-2000, "Перевёрнутое число: -2")]
    [TestCase(909, "Перевёрнутое число: 909")]
    [TestCase(12030, "Перевёрнутое число: 3021")]
    public void Block3Task2Test(int n, string expected)
    {
        var result = Solver.ReverseNumber(n);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(1, "Сумма Первых 1 чисел Фибоначчи = 0")]
    [TestCase(2, "Сумма Первых 2 чисел Фибоначчи = 1")]
    [TestCase(0, "Невозможно вычислить сумму")]
    [TestCase(-2, "Невозможно вычислить сумму")]
    [TestCase(7, "Сумма Первых 7 чисел Фибоначчи = 20")]
    [TestCase(3, "Сумма Первых 3 чисел Фибоначчи = 2")]
    [TestCase(4, "Сумма Первых 4 чисел Фибоначчи = 4")]
    [TestCase(5, "Сумма Первых 5 чисел Фибоначчи = 7")]
    [TestCase(6, "Сумма Первых 6 чисел Фибоначчи = 12")]
    [TestCase(10, "Сумма Первых 10 чисел Фибоначчи = 88")]
    public void Block3Task3Test(int n, string expected)
    {
        var result = Solver.FibonacciSum(n);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(10, 20, "Максимальное нечётное число в диапазоне [10, 20] = 19")]
    [TestCase(1, 9, "Максимальное нечётное число в диапазоне [1, 9] = 9")]
    [TestCase(8, 4, "Максимальное нечётное число в диапазоне [4, 8] = 7")]
    [TestCase(2, 2, "Нечётных чисел нет")]
    [TestCase(15, 15, "Максимальное нечётное число в диапазоне [15, 15] = 15")]
    [TestCase(0, 1, "Максимальное нечётное число в диапазоне [0, 1] = 1")]
    [TestCase(-5, 5, "Максимальное нечётное число в диапазоне [-5, 5] = 5")]
    [TestCase(4, 4, "Нечётных чисел нет")]
    [TestCase(9, 1, "Максимальное нечётное число в диапазоне [1, 9] = 9")]
    [TestCase(-3, -1, "Максимальное нечётное число в диапазоне [-3, -1] = -1")]
    public void Block3Task4Test(int a, int b, string expected)
    {
        var result = Solver.MaxOdd(a, b);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(new int[] { 3, 5, 7, 9 }, "Среднее значение массива = 6.00")]
    [TestCase(new int[] { 1, 2, 3, 4 }, "Среднее значение массива = 2.50")]
    [TestCase(new int[] { 10, 20, 40 }, "Среднее значение массива = 23.33")]
    [TestCase(new int[] { 5, 5, 5 }, "Среднее значение массива = 5.00")]
    [TestCase(new int[] { 2, 4 }, "Среднее значение массива = 3.00")]
    [TestCase(new int[] { 0, 0, 0 }, "Среднее значение массива = 0.00")]
    [TestCase(new int[] { -5, -10, -15 }, "Среднее значение массива = -10.00")]
    [TestCase(new int[] { 100, 200 }, "Среднее значение массива = 150.00")]
    [TestCase(new int[] { 1 }, "Среднее значение массива = 1.00")]
    [TestCase(new int[] { }, "Среднее значение массива = 0.00")]
    public void Block3Task5Test(int[] array, string expected)
    {
        var result = Solver.AverageArray(array);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(-9, 3, 5, "Прогрессия: -9 -6 -3 0 3, сумма = -15")]
    [TestCase(1, 1, 5, "Прогрессия: 1 2 3 4 5, сумма = 15")]
    [TestCase(5, 5, 4, "Прогрессия: 5 10 15 20, сумма = 50")]
    [TestCase(10, 0, 3, "Невозможно собрать прогрессию")]
    [TestCase(3, 3, -3, "Невозможно собрать прогрессию")]
    [TestCase(0, 2, 5, "Прогрессия: 0 2 4 6 8, сумма = 20")]
    [TestCase(-5, 5, 3, "Прогрессия: -5 0 5, сумма = 0")]
    [TestCase(10, -2, 5, "Прогрессия: 10 8 6 4 2, сумма = 30")]
    [TestCase(1, 2, 1, "Прогрессия: 1, сумма = 1")]
    [TestCase(5, 5, 0, "Невозможно собрать прогрессию")]
    public void Block3Task6Test(int first, int step, int n, string expected)
    {
        var result = Solver.ArithmeticProgression(first, step, n);
        Assert.That(result, Is.EqualTo(expected));
    }


    // ---------- BLOCK 4 ----------

    [TestCase(new int[] { 4, 9, 2, 7, 5 }, 6, "Количество Элементов Больших 6 = 2")]
    [TestCase(new int[] { 1, 2, 3, 4 }, 2, "Количество Элементов Больших 2 = 2")]
    [TestCase(new int[] { 10, 20, 30 }, 15, "Количество Элементов Больших 15 = 2")]
    [TestCase(new int[] { 5, 5, 5 }, 4, "Количество Элементов Больших 4 = 3")]
    [TestCase(new int[] { 1, 1, 1 }, 5, "Количество Элементов Больших 5 = 0")]
    [TestCase(new int[] { 0, 1, 2, 3 }, 1, "Количество Элементов Больших 1 = 2")]
    [TestCase(new int[] { -1, -2, -3 }, -2, "Количество Элементов Больших -2 = 1")]
    [TestCase(new int[] { 100, 200, 300 }, 50, "Количество Элементов Больших 50 = 3")]
    [TestCase(new int[] { 5, 5, 5 }, 5, "Количество Элементов Больших 5 = 0")]
    [TestCase(new int[] { 9, 8, 7 }, 6, "Количество Элементов Больших 6 = 3")]
    public void Block4Task1Test(int[] array, int filter, string expected)
    {
        var result = Solver.SumOfGreaterThen(array, filter);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(new int[] { 4, 9, 2, 7, 5 }, "Второй по величине элемент: 7 (индекс 3)")]
    [TestCase(new int[] { 1, 2, 3, 4 }, "Второй по величине элемент: 3 (индекс 2)")]
    [TestCase(new int[] { 10 }, "В массиве должно находиться минимум 2 элемента")]
    [TestCase(new int[] { 5, 1, 3, 4 }, "Второй по величине элемент: 4 (индекс 3)")]
    [TestCase(new int[] { }, "В массиве должно находиться минимум 2 элемента")]
    [TestCase(new int[] { 9, 8 }, "Второй по величине элемент: 8 (индекс 1)")]
    [TestCase(new int[] { 5, 5, 5, 5 }, "Второй по величине элемент: 5 (индекс 1)")]
    [TestCase(new int[] { 100, 50, 25 }, "Второй по величине элемент: 50 (индекс 1)")]
    [TestCase(new int[] { -1, -2, -3 }, "Второй по величине элемент: -2 (индекс 1)")]
    [TestCase(new int[] { 2, 3 }, "Второй по величине элемент: 2 (индекс 0)")]
    public void Block4Task2Test(int[] array, string expected)
    {
        var result = Solver.SecondLargest(array);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(new int[] { 2, 8, 4, 9, 1 }, "Обратный массив: 1 9 4 8 2")]
    [TestCase(new int[] { 1, 2, 3 }, "Обратный массив: 3 2 1")]
    [TestCase(new int[] { 5, 4, 3, 2, 1 }, "Обратный массив: 1 2 3 4 5")]
    [TestCase(new int[] { 7 }, "Обратный массив: 7")]
    [TestCase(new int[] { }, "Массив не может быть пустым")]
    [TestCase(new int[] { 0 }, "Обратный массив: 0")]
    [TestCase(new int[] { -1, -2, -3 }, "Обратный массив: -3 -2 -1")]
    [TestCase(new int[] { 10, 20 }, "Обратный массив: 20 10")]
    [TestCase(new int[] { 1, 1, 1 }, "Обратный массив: 1 1 1")]
    [TestCase(new int[] { 100, 200, 300 }, "Обратный массив: 300 200 100")]
    public void Block4Task3Test(int[] array, string expected)
    {
        var result = Solver.ReverseArray(array);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCaseSource(nameof(SumEvenMatrixCases))]
    public void Block4Task4Test(int[,] matrix, string expected)
    {
        var result = Solver.SumEvenInMatrix(matrix);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(new int[] { 5, -3, 7, -8, 12, -1 }, "Положительные: 5 7 12. Отрицательные: -3 -8 -1")]
    [TestCase(new int[] { 1, 2, 3 }, "Положительные: 1 2 3. Отрицательные: ")]
    [TestCase(new int[] { -1, -2, -3 }, "Положительные: . Отрицательные: -1 -2 -3")]
    [TestCase(new int[] { 10, -5 }, "Положительные: 10. Отрицательные: -5")]
    [TestCase(new int[] { }, "Массив не может быть пустым")]
    [TestCase(new int[] { 1, -1 }, "Положительные: 1. Отрицательные: -1")]
    [TestCase(new int[] { 0, 1, -1 }, "Положительные: 1. Отрицательные: -1")]
    [TestCase(new int[] { 10, 20, 30 }, "Положительные: 10 20 30. Отрицательные: ")]
    [TestCase(new int[] { -5, -10 }, "Положительные: . Отрицательные: -5 -10")]
    [TestCase(new int[] { 5 }, "Положительные: 5. Отрицательные: ")]
    public void Block4Task5Test(int[] array, string expected)
    {
        var result = Solver.SplitArray(array);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCaseSource(nameof(MatrixDiagonalCases))]
    public void Block4Task6Test(int[,] matrix, string expected)
    {
        var result = Solver.MatrixDiagonalMax(matrix);
        Assert.That(result, Is.EqualTo(expected));
    }

    static object[] SumEvenMatrixCases =
    {
        new object[] { new int[,] {{2,9,4},{8,1,3}}, "Сумма четных элементов = 14"},
        new object[] { new int[,] {{1,3},{5,7}}, "Сумма четных элементов = 0"},
        new object[] { new int[,] {{2,2},{2,2}}, "Сумма четных элементов = 8"},
        new object[] { new int[,] {{10,11},{12,13}}, "Сумма четных элементов = 22"},
        new object[] { new int[,] {{4}}, "Сумма четных элементов = 4"},
        new object[] { new int[,] {{0,2},{4,6}}, "Сумма четных элементов = 12"},
        new object[] { new int[,] {{1,2,3},{4,5,6}}, "Сумма четных элементов = 12"},
        new object[] { new int[,] {{7,9},{11,13}}, "Сумма четных элементов = 0"},
        new object[] { new int[,] {{2}}, "Сумма четных элементов = 2"},
        new object[] { new int[,] {{-2,-4},{6,8}}, "Сумма четных элементов = 8"}
    };

    static object[] MatrixDiagonalCases =
    {
        new object[] { new int[,] {{2,9,4},{8,1,3},{-2,4,6}}, "Максимальный элемент главной диагонали = 6"},
        new object[] { new int[,] {{2,9,4},{8,1,3}}, "Максимальный элемент главной диагонали = 0"},
        new object[] { new int[,] {{5,2},{3,7}}, "Максимальный элемент главной диагонали = 7"},
        new object[] { new int[,] {{1}}, "Максимальный элемент главной диагонали = 1"},
        new object[] { new int[,] {{10,0,0},{0,20,0},{0,0,5}}, "Максимальный элемент главной диагонали = 20"},
        new object[] { new int[,] {{5,1},{2,3}}, "Максимальный элемент главной диагонали = 5"},
        new object[] { new int[,] {{-1,0},{0,-5}}, "Максимальный элемент главной диагонали = -1"},
        new object[] { new int[,] {{7}}, "Максимальный элемент главной диагонали = 7"},
        new object[] { new int[,] {{2,3,4},{5,6,7},{8,9,10}}, "Максимальный элемент главной диагонали = 10"},
        new object[] { new int[,] {{1,2,3}}, "Максимальный элемент главной диагонали = 0"}
    };
}
