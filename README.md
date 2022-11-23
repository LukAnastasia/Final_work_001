# Итоговая проверочная работа.

## Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

Примеры:

- ["hello", "2", "world", ":-)"]

- ["1234","1567","-2","computer since"]

- ["Russia","Denmark","Kazan"]

## Алгоритм решения:

1. Делаем перебор значений из исходного массива
2. Проверяем каждое значение из массива на соответствие условию: длина строки меньше или равна трем
3. Если строка удовлетворяет условию кладем значение в новый массив
4. Повторяем пункты 2 и 3 до тех пор пока не достигнем конца исходного массива
5. Возвращаем новый заполненый массив как результат

## Блок схема 
![](%D0%91%D0%BB%D0%BE%D0%BA-%D1%81%D1%85%D0%B5%D0%BC%D0%B0.jpg)

## Программа:

### Для запуска программы перейдите в папку Final_result_001.

### *Далее по очереди введите примеры:*

- ["hello", "2", "world", ":-)"]

- ["1234","1567","-2","computer since"]

- ["Russia","Denmark","Kazan"]

и запустите через терминал команду:

**dotnet run** 

