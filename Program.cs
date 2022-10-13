// Инициализация и заполнение массива строк
string[] input_array = new string[5];
input_array[0] = "heo";
input_array[1] = "ld";
input_array[2] = "abc";
input_array[3] = "=)";
input_array[4] = "0989";

// Вывод массива
void PrintArray(string[] result_array){
    for (int i = 0; i < result_array.Length; i++){
        Console.Write($"{result_array[i]} ");  
    }
    Console.WriteLine();
}

// Формирование нового массива (длина элемента <= 3)
string[] GetNewArray(string[] in_array){
    string[] new_array = new string[in_array.Length];

    for (int i = 0; i < in_array.Length; i++){
        if(in_array[i].Length <= 3){
            new_array[i] = in_array[i];
        }  
    }

    // !!ЗДЕСЬ ИСПОЛЬЗУЕТСЯ ПРЕОБРАЗОВАНИЕ В КОЛЛЕКЦИЮ!!
    // Исключительно для удаления пустых элементов результирующего массива
    new_array = new_array.Where(x => x != null).ToArray();

    return new_array;
}


string[] a = GetNewArray(input_array);
PrintArray(a);
