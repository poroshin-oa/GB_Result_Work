# GB_Result_Work

Итоговая проверочная работа вводного курса GeekBrains

Принцип работы:

Исходный массив вводится в начале программы.

Два метода: 
PrintArray --> ничего не возвращает, на вход принимает одномерный массив типа string, результатом работы является вывод массива в консоль.
Принцип работы - простой цикл.

GetNewArray --> основной метод, на вход принимает одномерный массив типа string, возвращает массив типа string с элементами, длина которых меньше или равна 3 символам.
Принцип работы:
1. Цикл с условием в теле цикла выбирает из исходного массива и записывает в новый элеметы с длиной меньше или равные 3 символам.
2. Преобразование в коллекцию с последующим удалением пустых строк (т.к. результирующий массив может быть меньше исходного) и преобразованием обратно в массив.