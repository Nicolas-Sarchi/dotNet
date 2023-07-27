// Este algoritmo se baja en que se debe hacer un contador desde el número 1 al número 100, en orden correlativo, pero cada vez que un número sea múltiplo de 3, debe decir Fizz y cada vez que un número sea múltiplo de 5, debe decir Buzz, en el caso que un número sea múltiplo de 3 y 5, debe decir FizzBuzz, si el número no es múltiplo, se debe mostrar solamente el número.

for (int i = 1; i < 100; i++)
{

    if (i % 3 == 0 && i % 5 == 0 )
    {
        Console.WriteLine("FizzBuzz");
    } else if(i % 5 == 0){
        Console.WriteLine("Buzz");
    } else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    } else{
        Console.WriteLine(i);

    }
}

// 1
// 2
// Fizz
// 4
// Buzz
// Fizz
// 7
// 8
// Fizz
// Buzz
// 11
// Fizz
// 13
// 14
// FizzBuzz
// 16
// 17
// Fizz
// 19
// Buzz
// Fizz
// 22
// 23
// Fizz
// Buzz
// 26
// Fizz
// 28
// 29
// FizzBuzz
// 31
// 32
// Fizz
// 34
// Buzz
// Fizz
// 37
// 38
// Fizz
// Buzz 
// 41 
// Fizz 
// 43 
// 44 
// FizzBuzz 
// 46 
// 47 
// Fizz 
// 49 
// Buzz 
// Fizz 
// 52 
// 53 
// Fizz 
// Buzz 
// 56 
// Fizz 
// 58 
// 59 
// FizzBuzz 
// 61 
// 62 
// Fizz 
// 64 
// Buzz 
// Fizz 
// 67 
// 68 
// Fizz 
// Buzz 
// 71 
// Fizz 
// 73 
// 74 
// FizzBuzz 
// 76 
// 77 
// Fizz 
// 79 
// Buzz  
// Fizz  
// 82  
// 83  
// Fizz  
// Buzz  
// 86  
// Fizz  
// 88  
// 89  
// FizzBuzz  
// 91  
// 92  
// Fizz  
// 94  
// Buzz  
// Fizz  
// 97  
// 98  
// Fizz  
// Buzz

