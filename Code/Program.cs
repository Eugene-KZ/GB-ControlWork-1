﻿/*
Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо
равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] FillArray()
{
	Console.WriteLine("Введите слова, числа через пробел: ");
	var array = Console.ReadLine().Split(" ");
	return array;
}

string[] FindElementsLen3(string[] array){
	string temp = String.Empty;
	for(int i = 0; i < array.Length; i++){
		if(array[i].Length <= 3){
			temp += " " + array[i];
		} 
	}
	var arrayElLen3 = temp.Split(" ");
	return arrayElLen3;
}

void PrintArray(string[] array){
	for(int i = 0; i<array.Length; i++){
	Console.WriteLine(array[i]);
}
}


string[] array = FillArray();
string[] arrayElLen3 = FindElementsLen3(array);
PrintArray(arrayElLen3);


