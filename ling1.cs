using System;
class x{
	static void Main(){

	ConsoleKeyInfo resposta;
	string b1="using System;\nclass x{\nstatic void Main(){\n\n";
	string b2="\n}\n}";
	string e="\n";

	Console.Write("1 ");
	string t1=Console.ReadLine();
	t1=t1.Replace("esl:", "Console.WriteLine(").Replace("|*", ");").Replace("es:", "Console.Write(").Replace("se", "if").Replace("frase", "string");
	resposta=Console.ReadKey();
	if(resposta.Key == ConsoleKey.LeftArrow)
	{
		Console.Clear();
		Console.WriteLine(b1 + t1 + b2);
	}

	Console.Write("2 ");
	string t2=Console.ReadLine();
	t2=t2.Replace("esl:", "Console.WriteLine(").Replace(";", ");");
	resposta=Console.ReadKey();
	if(resposta.Key == ConsoleKey.LeftArrow)
	{
		Console.Clear();
		Console.WriteLine(b1 + t1 + e + t2 + b2);
	}

	Console.Write("3 ");
	string t3=Console.ReadLine();
	t3=t3.Replace("esl:", "Console.WriteLine(").Replace(";", ");");
	resposta=Console.ReadKey();

	if(resposta.Key == ConsoleKey.LeftArrow)
	{

		Console.Clear();
		Console.WriteLine(b1 + t1 + e + t2 + e + t3 + e + b2);
	}

	Console.Write("4 ");
	string t4=Console.ReadLine();
	t4=t4.Replace("esl:", "Console.WriteLine(").Replace(";", ");");
	resposta=Console.ReadKey();

	if(resposta.Key == ConsoleKey.LeftArrow)
	{

		Console.Clear();
		Console.WriteLine(b1 + t1 + e + t2 + e + t3 + e + t4 + e + b2);
	}

	Console.Write("5 ");
	string t5=Console.ReadLine();
	t5=t5.Replace("esl:", "Console.WriteLine(").Replace(";", ");");
	resposta=Console.ReadKey();
	if(resposta.Key == ConsoleKey.LeftArrow)
	{

		Console.Clear();
		Console.WriteLine(b1 + t1 + e + t2 + e + t3 + e + t4 + e + t5 + e + b2);
	}

        }
}