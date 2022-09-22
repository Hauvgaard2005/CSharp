//Un-comment below code and fix the issues
//Push to github
int nextFibo; 
int RecursiveFibonacci(int first, int second, int count) { 
    count--; 
    nextFibo = first + second; 
    first = second; 
    second = nextFibo; 
    if (count == 0) { 
        return nextFibo; 
    } else { 
        return RecursiveFibonacci(first, second, count); 
    } 
}
int lastFibo = RecursiveFibonacci(1, 1, 5); 
Console.WriteLine("Last fibo number was " + lastFibo); 
Console.ReadLine();