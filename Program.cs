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

// string text = Console.ReadLine();

// int totalChars = text.Length; 
// int spacesCount = 0;
// int vowelsCount = 0;
// string vowels = "аеёиоуыэюя"; 


// foreach (char c in text){
//     if (c == ' '){
//         spacesCount++;
//     }
    
   
//     if (vowels.Contains(char.ToLower(c))){
//         vowelsCount++;
//     }
// }

// Console.WriteLine($"Количество символов: {totalChars}");
// Console.WriteLine($"Количество пробелов: {spacesCount}");
// Console.WriteLine($"Количество гласных букв: {vowelsCount}");


// Console.WriteLine(); 




// string word = Console.ReadLine();

// string reversed = "";


// for (int i = word.Length - 1; i >= 0; i--){

//     reversed += word[i];
// }

// Console.WriteLine($"Слово задом наперёд: {reversed}");
// if (word.ToLower() == reversed.ToLower()){
//     Console.WriteLine("Слово является палиндромом.");
// }
// else{
//     Console.WriteLine("Слово НЕ является палиндромом.");
// }




string email = Console.ReadLine();


bool hasSpaces = false;
int atCount = 0;


foreach (char c in email){
    if (c == ' '){
        hasSpaces = true;
    }
    if (c == '@'){
        atCount++;
    }
}


if (email.Length < 5){
    Console.WriteLine("Адрес некорректен: Длина должна быть не меньше 5 символов.");
}
else if (atCount != 1){
    Console.WriteLine("Адрес некорректен: Должен быть ровно один символ @.");
}
else if (email.StartsWith("@") || email.EndsWith("@")) {
    Console.WriteLine("Адрес некорректен: Адрес не должен начинаться или заканчиваться на @.");
}
else if (hasSpaces) {
    Console.WriteLine("Адрес некорректен: В адресе не должно быть пробелов.");
}

else if (!email.EndsWith(".ru", StringComparison.OrdinalIgnoreCase) && 
         !email.EndsWith(".com", StringComparison.OrdinalIgnoreCase)){
    Console.WriteLine("Адрес некорректен: Адрес должен заканчиваться на .ru или .com.");
}
else{
    Console.WriteLine("Адрес корректен");
    Console.WriteLine(email.ToLower());
}
