// 7.1.1
let rec fibo = function
    | 0 -> 0
    | 1 -> 1
    | 2 -> 1
    | -1 -> 1
    | n when n < 0 -> fibo (n+2) - fibo (n+1)
    | n -> fibo (n-1) + fibo (n-2)

// 7.1.2
let rec sum = function
    | n when n < 0 -> 0
    | 0 -> 0
    | 1 -> 1
    | n -> n + (sum (n-1))


// 7.1.3
let rec sum2 = function 
    | (m,0) -> m
    | (m,n) -> (m*(n+1)) + (sum n)
