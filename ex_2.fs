let g n = n + 5 // int

let gg = fun n -> n + 5

let square x = x * x
let sumOfSquares (x, y) = square x + square y

let h (x, y) = System.Math.Sqrt (sumOfSquares (x, y))
