
// {
//     int number;
//     {
//         number = 4561234;
//     }
//     {
//         Console.WriteLine($"{number}");
//     }
//     string my_name;
//     {
//         my_name = "Bob";
//     }
//     {
//         Console.WriteLine($"{my_name}");
//     }
//     const string NAME = "Tom";
//     {
//         Console.WriteLine($"{NAME}");
//     }
//     {
//         Console.WriteLine($"{my_name}"+","+$"{NAME}");
//     }
// }
// ПРИКОЛЫ С ВЫВЕДЕНИЕМ ВСКОГО 

// {
// Console.WriteLine(true);
// Console.WriteLine(false);
// }

// {
//     Console.WriteLine(0b100011010011001); 
//     Console.WriteLine(0xF1);
// }

// {
//     string name;
//     {
//         name = "Bob";
//     }
//     {
//         Console.WriteLine($"{name}");
//     }
//     string name_2;
//     {
//         name_2 = "Tom";
//     }
//     {
//         Console.WriteLine($"{name}\n{name_2}");
//     }
//     {
//         Console.WriteLine('\x23');
//     }
//     {
//         Console.WriteLine("Компания \"Чук И КОК\"");
//     }
// }

// И ЭТО ТОЖЕ

// {
//     char a;
//     {
//         a = 'A';
//     }
//     {
//         Console.WriteLine($"{a}");
//     }
//     char b;
//     {
//         b = '\x5A';
//     }
//     {
//         Console.WriteLine($"{b}");
//     }
// }

// НАГЛЯДНЫЙ ПРИМЕР ПОДОБИЯ f строк(этот $) из питона

// string name = "Tom";
// int age = 33;
// bool isEmplooyed = false;
// double weight = 78.31;

// РАЗЛИЧНЫЕ ТИПЫ ДАННЫХ

// {
//     Console.WriteLine($"Имя:{name}");
//     Console.WriteLine($"Возраст:{age}");
//     Console.WriteLine($"Работает:{isEmplooyed}");
//     Console.WriteLine($"Вес:{weight}");
// }

// string name = "Mike";
// int age = 33;
// double height = 1.7;
// Console.WriteLine($"Имя: {name}, Возраст: {age}, Рост: {height}м.");

// Console.Write("Введите своё имя:");
// string? name = Console.ReadLine();
// Console.Write("Введите свой возраст:");
// string? age = Console.ReadLine();
// Console.Write("Введите ваш рост:");
// string? height = Console.ReadLine();
// Console.WriteLine("Введите ваш вес:");
// string? weight = Console.ReadLine();
// Console.WriteLine($"Привет {name}!");
// Console.WriteLine($"Твой возраст:{age}");
// Console.WriteLine($"Твой рост: {height} метров");
// Console.WriteLine($"Твой вес: {weight} кг");

// ПЕРВАЯ МАЛЕНЬКАЯ ПРОГРАММКА

// Console.Write("Введите имя: ");
// string? name = Console.ReadLine();
// Console.Write("Введите возраст: ");
// int age = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите рост: ");
// double height = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите размер зарплаты: ");
// decimal salary = Convert.ToDecimal(Console.ReadLine());
// Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height}м Зарплата: {salary}$");


// АРИФМЕТИЧЕСКИЕ ОПЕРАЦИИ
// int a = 10;
// int b = 5 + a;
// int a = 25;
// int b = a / 5;
// int a = 25;
// int b = 5;
// int c = a / b;

// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);

// int a = 10; 
// int b = 5;
// int c = 10;
// bool z = a>b;
// bool d = c<=a;
// Console.WriteLine(z);
// Console.WriteLine(d);

// ЦИКЛ IF| ELSE IF| ELSE
// int a = 10;
// int b = 10;
// if(a>b)
// {
//     Console.WriteLine($"Число {a} больше чем {b}");
// }
// else
// {
//     Console.WriteLine($"Число {b} больше чем {a}");
// }

// Console.Write("Введите число:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(b);

// if(a>b)
// {
//     Console.WriteLine($"Число {a} больше чем число {b}");
// }
// else if (a<b)
// {
//     Console.WriteLine($"Число {a} меньше чем число {b}");
// }


// Console.Write("Введите своё имя:");
// string? name = Console.ReadLine();
// if (name == "Alex")
// {
//     Console.WriteLine("Вас зовут Alex");
// }
// else if (name == "Bob")
// {
//     Console.WriteLine("Вас зовут Bob");
// }
// else if (name == "Ilya")
// {
//     Console.WriteLine("Вас зовут Илья");
// }
// else if (name == "Milya")
// {
//     Console.WriteLine("Вас зовут Milya");
// }
// else
// {
//     Console.WriteLine("ЭТО КАКАЯ-ТО ХУЙНЯ!");
// }



// Console.Write("Введите число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1==num2)
// {
//     Console.WriteLine($"Число {num1} равно {num2}.");
// }

// else if (num1>num2)
// {
//     Console.WriteLine($"Число {num1} больше чем {num2}.");
// }

// else if (num1<num2)
// {
//     Console.WriteLine($"Число {num1} меньше {num2}.");
// }

// else
// {
//     Console.WriteLine("Ты как это вызвал?");
// }


// Console.Write("Введите число в диапазоне от 6 до 9:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (5<num1 && num1<10)
// {
//     Console.WriteLine("Число больше 5 и меньше 10");
// }
// else if (num1<5)
// {
//     Console.WriteLine($"Число {num1} меньше 5");
// }
// else
// {
//     Console.WriteLine("Неизвестное число");
// }


// Console.Write("Введите число 5 или число 10:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 == 5 | num1 == 10)
// {
//     Console.WriteLine($"Число  либо равно 5, либо равно 10");
// }
// else if (num1<5)
// {
//     Console.WriteLine($"Число меньше 5");
// }
// else if (num1>10)
// {
//     Console.WriteLine($"Число больше 10");
// }

// for(int i = 1; i<5; i++)
// {
//     Console.WriteLine(i);
// }
// for(int i = 2,j = 3; i<100;i++,j++)
// {
//     Console.WriteLine($"{i*j}");
// }   

// var i = 4;
// var p = 3;
// for (Console.WriteLine("Начало выполнения цикла"); i<100;Console.WriteLine($"i={i*p}"))
// {
//     i++;
// }


// ЦИКЛ DO|WHILE
// int i = 6;
// do
// {
//     Console.WriteLine(i*5);
//     i++;
// }
// while(i<100);

// ЦИКЛ WHILE
// int o = 10;
// int a = 10;
// while (o<1000)
// {
// o++;
// a++;
// Console.WriteLine(o*a);     
// }

// ЦИКЛ FOREACH
// foreach (var a in "Tom_1234567890101010101")
// {
//     Console.WriteLine(a);    
// }


//ОПЕРАТОРЫ BREAK|CONTINUE
// for (int i = 0; i < 100; i++)
// {
//     if(i==81)
//     break;
//     Console.WriteLine(i);    
// }


// for (int i = 0; i < 100; i++)
// {
//     if(i==81)
//     continue;
//     Console.WriteLine(i);
// }


// МАССИВЫ

// int[] nums = new int[4];
// int[] nums = new int[5] {1,2,3,4,5};
// foreach (var i in nums)
// {
//  Console.WriteLine(i);   
// }

// string[] people = {"Tom","Bob","Mike","Richard"};
// Console.WriteLine(people[2]);
// {
//     foreach (var i in people)
//     {
//         Console.WriteLine($"\n{i}");
//     }
// }
// ПОЛУЧЕНИЕ ЭЛЕМЕНТА МАССИВА В ПЕРЕМЕННУЮ
// var i = people[1];
// Console.WriteLine(i);
// people[0] = "ABOBA";
// Console.WriteLine(people[0]); 
// {
//     foreach (var i in people)
//     {
//         Console.WriteLine($"\n{i}");
//     }
// }
// Console.WriteLine(people.Length);


// Console.WriteLine("Hello World!");

// Console.Write("Введите своё имя!:");
// string? name = Console.ReadLine();
// Console.Write("Введите свой возраст:");
// int age = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Привет {name}");
// Console.WriteLine($"Твой возраст: {age}");

///////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////

// Console.Write("Введите чискло в диапазоне от 6 и до 9:");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num > 5 && num < 10)
// {
//     Console.WriteLine("Число больше 5 и меньше 10 одновременно");
// }
// else
// {
//     Console.WriteLine("Неизвестное число");
// }
//////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////

// Console.Write("Введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1==num2)
// {
//     Console.WriteLine($"Числа {num1} и {num2} равны");
// }
// else if(num1>num2)
// {
//     Console.WriteLine($"Число {num1} больше чем число {num2}");
// }
// else if(num1<num2)
// {
//     Console.WriteLine($"Число {num2} больше чем число {num1}");
// }
///////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////
// Console.Write("Введите число 5 или 10:");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num==5 || num == 10)
// {
//     Console.WriteLine("Число равно либо 5 либо 10");
// }
// else
// {
//     Console.WriteLine("Неизвестное число");
// }
///////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////

// Console.WriteLine("Введите сумму вклада:");
// double vkl = Convert.ToDouble(Console.ReadLine());
// if (vkl<=100)
// {
//     vkl+= vkl*0.05;
// }
// else if (vkl<=200)
// {
//     vkl += vkl*0.07;
// }
// else
// {
//     vkl += vkl*0.1;
// }
// Console.WriteLine($"Сумма вклада после начисления процентов: {vkl}");
// Console.ReadKey();

//////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////


// Console.WriteLine("Введите сумму вклада:");
// double vkl = Convert.ToDouble(Console.ReadLine());
// double bonus = 0;
// if (vkl<=100)
// {
//     bonus = 0.05;
// }
// else if (vkl<=200)
// {
//     bonus = 0.07;
// }
// else
// {
//     bonus = 0.1;
// }

// vkl += vkl*bonus + 15;
// Console.WriteLine($"Сумма вклада после начисления процентов: {vkl}");
// Console.ReadKey();
/////////////////////////////////////////////////////////
////////////////////////////////////////////////////////
// Console.WriteLine("Выбереите одну из арифметических операций: 1.Сложение,2.Вычитание,3.Умножение:");
// int op = Convert.ToInt32(Console.ReadLine());
// switch(op)
// {
//     case 1:
//     Console.WriteLine("Сложение");
//     break;
//     case 2:
//     Console.WriteLine("Вычтание");
//     break;
//     case 3:
//     Console.WriteLine("Умножение");
//     break;
// }
/////////////////////////////////////////////////////////
////////////////////////////////////////////////////////

// Console.WriteLine("Выберите одну из арифметических операций: 1.Сложение, 2.Вычитание, 3.Умножение:");
// int op = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// switch(op)
// {
//     case 1:
//     num1 = num1 + num2;
//     Console.WriteLine($"Результат операции:{num1}");
//     break;
//     case 2:
//     num1 = num1 - num2;
//     Console.WriteLine($"Результат операции:{num1}");
//     break;
//     case 3:
//     num1 = num1 * num2;
//     Console.WriteLine($"Результат операции:{num1}");
//     break;
//     default:
//     Console.WriteLine("Неизвестная операция");
//     break;
// }
// Console.ReadKey();

////////////////////////////////////////////////////////
///////////////////////////////////////////////////////
// Console.Write("Выберите одну из арифметических операций: 1.Сложение,2.Вычитание,3.Умножение:");
// int op = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(op==1)
// {
//     num1 = num1 + num2;
// }
// else if (op == 2)
// {
//     num1 = num1 - num2;
// }
// else if (op == 3)
// {
//     num1 = num1 * num2;
// }
// else
// {
//     Console.WriteLine("Неопределённая операция");
// }
// Console.WriteLine($"Результат: {num1}");
// Console.ReadKey();

/////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////
// ПЕРВАЯ ЗАДАЧА
// for(int i = 10; i <= 20; i++)
// Console.WriteLine(i*i);
/////////////////////////////////////////////////////////
// ВТОРАЯ ЗАДАЧА
// Console.WriteLine("Введите число N:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// int sum = 0;

// for (int i = 0; i<n; i++)
// {
// Console.WriteLine($"Ведите {i+1} слагаемое");
// array[i] = Convert.ToInt32(Console.ReadLine());
// sum = sum + array[i];
// }
// Console.WriteLine("");
// Console.WriteLine("Ответ: " + sum);
// Console.ReadKey();
/////////////////////////////////////////////////////////
// ТРЕТЬЯ ЗАДАЧА
// Console.WriteLine("Введите число N:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// int sum = 1;

// for (int i = 0; i<n; i++)
// {
// Console.WriteLine($"Ведите {i+1} слагаемое");
// array[i] = Convert.ToInt32(Console.ReadLine());
// sum *= sum + array[i];
// }

// Console.WriteLine("");
// Console.WriteLine("Ответ: " + sum);
// Console.ReadKey();
/////////////////////////////////////////////////////////
