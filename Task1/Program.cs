// Напишите программу, которая на вход принимает два целых числа и проверяет,
// не является ли первое число квадратом второго

//int first = 20;
//int second = 5;

//if(second*second == first)
//{
    //Console.Write("Yes");
//}
//else {
    //Console.Write("No");
//}

// напишите программму которая на входе принимает целое число N, на выходе показывает все целые числа от -N до N
// int n = 4;

// for ( int i = -n; i<=n; i++){
    // Console.Write(i+" ");
// }

// напишите прогу, которая принимает на вход трехзнач целое число, на выходе показывает сумму первой и последней цифры этого числа

int num = 666;
int first = num / 100;
int second = num%10;
int sum = first + second;
Console.Write("Sum of first and last digit is " + sum);