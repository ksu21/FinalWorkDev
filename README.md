# FinalWorkDev
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

# Программа для фильтрации строк по длине в массиве



1. **Ввод исходного массива строк:** через Console.WriteLine
2. **Определяем количество строк в исходном массиве:**  int length = inputArray.Length
3. **Считаем количество строк, длина которых меньше или равна 3 символам:** через функцию foreach
4. **Создаем новый массив с нужной длиной "count":** string[] resultArray = new string[count];
5. **Заполняем новый массив:** через функцию foreach
6. **Вывод результата:** через Console.WriteLine


