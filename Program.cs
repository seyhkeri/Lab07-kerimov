﻿// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

// for (int i = 6; i < days.Length; i--)
// {
//     Console.WriteLine($"{i}: {days[i]}");
// }

// double[] temps = { -2.5, -0.8, 1.2, 3.5, -1.0, 0.5, -4.2 };

// foreach (double temp in temps) {
//     Console.Write($"{temp} ");
// }

// Console.WriteLine(); 

// int[] prices = { 120, 45, 300, 80, 15, 210 };

// int sum = 0;
// int count = 0;

// foreach (int price in prices) {
//     sum += price;
//     if (price > 100) {
//         count++;
//     }
// }

// double average = (double)sum / prices.Length;

// Console.WriteLine($"Общая сумма цен: {sum}, среднее: {average}, дороже 100: {count}");

// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int min = prices[0];
// int max = prices[0];
// int maxIndex = 0;

// for (int i = 1; i < prices.Length; i++) {
//     if (prices[i] < min) {
//         min = prices[i];
//     }

//     if (prices[i] > max) {
//         max = prices[i];
//         maxIndex = i;
//     }
// }

// Console.WriteLine($"Минимум: {min}, самый дорогой: {maxIndex}");

// int[] balance = { 100, -50, 20, -5, 0, 75 };

// for (int i = 0; i < balance.Length; i++) {
//     if (balance[i] < 0) {
//         balance[i] = 0;
//     }
// }

// foreach (int b in balance) {
//     Console.Write(b + " ");
// }
// Console.WriteLine();

// int[] numbers = new int[5];

// for (int i = 0; i < numbers.Length; i++) {
//     Console.Write($"Введите число {i + 1}: ");
//     numbers[i] = int.Parse(Console.ReadLine());
// }

// Console.Write("обратный порядок: ");
// for (int i = numbers.Length - 1; i >= 0; i--) {
//     Console.Write(numbers[i] + " ");
// }
// Console.WriteLine();

// int evenCount = 0;
// foreach (int n in numbers) {
//     if (n % 2 == 0) {
//         evenCount++;
//     }
// }

// Console.WriteLine($"количество чётных чисел: {evenCount}");

// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// Console.Write("Введите имя: ");
// string search = Console.ReadLine();
// int index = -1;

// for (int i = 0; i < names.Length; i++) {
//     if (names[i].Equals(search, StringComparison.OrdinalIgnoreCase)) {
//         index = i;
//         break;
//     }
// }

// if (index != -1) {
//     Console.WriteLine($"имя найдено, индекс в массиве: {index}");
// } else {
//     Console.WriteLine("не найдено");
// }

int[] grades = { 5, 4, 3, 5, 2, 4, 5, 4 };
int sum = 0;
int max = grades[0];
int min = grades[0];
int twocount = 0;
int fivecount = 0;

Console.Write("все оценки: ");
foreach (int grade in grades) {
    Console.Write(grade + " ");

    sum += grade;

    if (grade > max) max = grade;
    if (grade < min) min = grade;

    if (grade == 2) twocount++;
    if (grade == 5) fivecount++;
}
Console.WriteLine();

double average = (double)sum / grades.Length;
Console.WriteLine($"средняя оценка: {average:F2}");

Console.WriteLine($"наибольшая оценка: {max}");
Console.WriteLine($"наименьшая оценка: {min}");

Console.WriteLine($"количество двоек: {twocount}");
Console.WriteLine($"количество пятерок: {fivecount}");

if (average >= 4.5) {
    Console.WriteLine("отличник");
} else if (average >= 3.5) {
    Console.WriteLine("хорошист");
} else {
    Console.WriteLine("есть над чем поработать");
}

// int[] arr = { 1, 2, 3, 4, 5, 6 };

// for (int i = 0; i < arr.Length / 2; i++)
// {

//     int j = arr.Length - 1 - i;

//     int temp = arr[i];
//     arr[i] = arr[j];
//     arr[j] = temp;
// }

// foreach (int num in arr)
// {
//     Console.Write(num + " ");
// }

// Console.WriteLine();