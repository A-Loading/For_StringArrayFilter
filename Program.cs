using System;

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
        
        if (args.Length < 1)
        {
			Console.WriteLine("введите количество элементов масива");
			int number = Convert.ToInt32(Console.ReadLine());
			string[] arr = new string[number];

			for (int i = 0; i < number; i++)
			{
				Console.WriteLine($"введите элемент[{i+1}/{number}] масива");
				arr[i] = Console.ReadLine();
			}
			args = arr;/* тут назначается ссылка
			так как без неё автоклинер удаляет переменную арр вне скобок
			( утечка данных )
			проесходит ошибка (переменная не обявленна)
			*/
		}
		
        PrintArray(args);//дебаг вывод
		Console.WriteLine($"╬	╬	╬	╬	╬	╬	╬");
		
		
	}
	
	
}