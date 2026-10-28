// string word = "привет";

// Console.WriteLine(word.Length);
// Console.WriteLine(word[0]);

// foreach (char c in word){
//     Console.WriteLine(c);
// }


// string word = "ананас";
// int count = 0;
// foreach (char c in word){
//     if (char.ToLower(c) == 'а'){
//         count++;
//     }
// }

// Console.WriteLine($"Буква 'а' встречается {count} раз(а).");


// string fileName = Console.ReadLine();


// if (fileName.EndsWith(".cs", StringComparison.OrdinalIgnoreCase)){
//     Console.WriteLine("Это файл C#");
// }
// else if (fileName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) || 
//          fileName.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase)){
//     Console.WriteLine("Это изображение");
// }
// else{
//     Console.WriteLine("Неизвестный тип");
// }


// if (fileName.StartsWith("Lab", StringComparison.Ordinal)){
//     Console.WriteLine("Это лабораторная работа");
// }

// if (fileName.Contains("test", StringComparison.OrdinalIgnoreCase)){
//     Console.WriteLine("Тестовый файл");
// }


// string phrase = Console.ReadLine();
// Console.WriteLine(phrase.ToUpper());
// string underscores = phrase.Replace(" ", "_");
// Console.WriteLine(underscores);

// if (phrase.ToLower().Contains("стоп")){
//     Console.WriteLine("Стоп-слово найдено!");
// }

// string date = Console.ReadLine();
// string year = date.Substring(0, 4);
// string month = date.Substring(5, 2);
// string day = date.Substring(8, 2);
// Console.WriteLine($"Дата: {day}.{month}.{year}");
// Console.WriteLine(); 
// Console.Write("Введите 11 цифр телефона (например, 89161234567): ");
// string phone = Console.ReadLine();
// string code = phone.Substring(1, 3);      
// string part1 = phone.Substring(4, 3);     
// string part2 = phone.Substring(7, 2);     
// string part3 = phone.Substring(9, 2);    
// Console.WriteLine($"Телефон: +7 ({code}) {part1}-{part2}-{part3}");

