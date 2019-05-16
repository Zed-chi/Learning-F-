// 20.3.1
let vat n (x:float) = 
    if n >= 0 && n <= 100 then x + (x*float(n)/100.0) 
    else x

// 20.3.2
let unvat n (x:float) = x - ( (x/(100.0+float(n))) * float(n))

// 20.3.3
let min f =
    let rec check = function
        | x when f x = 0 -> x
        | x -> check (x+1)
    check 1
