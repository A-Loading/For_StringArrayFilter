using System;
#nullable disable// магическое заклинание уберающие  warning CS8601
// warning CS8601: Возможно назначение допускающее значение NULL.

class Program
{
	
	static void PrintArray(string[] Array){
		foreach (string arg in Array)
				{
					Console.WriteLine($"[{arg}]");
				}
	}
	
	
    static void Main(string[] args)
    {
        
        if (args.Length < 1)// в аргументах нет ни одного элемента масива
        {
			//задаём количество элементов
			Console.WriteLine("введите количество элементов масива");
			int number = Convert.ToInt32(Console.ReadLine());
			string[] arr = new string[number];
			
			// добавляем элементы в масив
			
			Console.WriteLine($"введите элементы масива");
			for (int i = 0; i < number; i++)
			{
				Console.Write($"[{i+1}/{number}]:	");
				arr[i] = Console.ReadLine();
			}
			
			
			args = arr;/* тут назначается ссылка
			так как без неё автоклинер удаляет переменную арр вне скобок
			( утечка данных )
			проесходит ошибка (переменная не обявленна)
			по крайнемере у меня
			*/
		}
		
        /*/  дебаг вывод
		Console.WriteLine($"╬---╬	>3	╬");
		PrintArray(args);
		Console.WriteLine($"╬---╬		╬");//*/
		
		string[] new_array = new string[args.Length];
		int new_arr_leng = 0;
		
		// добавление элементов в массив
		for(int i = 0; i<args.Length; i++ ){
			
			if ( args[i].Length <= 3 ){
				new_array[new_arr_leng]=args[i];
				new_arr_leng++;//новая длинна +1
			}
			
		}
		
		// изменяем размер масива избавляясь от пустых ячеек
		Array.Resize(ref new_array, new_arr_leng);
		
		// выводим масив
		Console.WriteLine("");
		Console.WriteLine("новый массив");
		PrintArray(new_array);		
	}
	
}