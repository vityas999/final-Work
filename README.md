# Итоговая контрольная работа по основному блоку
## `Задача`:
*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

## `Примеры`:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

# Описание алгоритма решения
Создаем непосредственно логический метод программы *`ArrayWithIF(string[]array1, string[] array2)`*. Суть такова: в ходе логических операций, отработанных на двух ранее созданных массивах *`array1`* и *`array2`* в методе *`main()`* образуется новый результирующий массив *`resultArray`*, который с помощью выхода данного массива в методе *`main()`* присваивается к массиву *`result`* в методе *`main()`*.

