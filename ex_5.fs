// 16.1
let notDivisible  = function
    |(n, m) when n = 0 || m = 0 -> false
    |(n, m) when m%n = 0 -> true
    | _ -> false

// 16.2
let prime n = 
    let rec check = function
        |(n, m) when n< 0 -> check(-n, -m-1)
        |(0, _) -> false
        |(1, _) -> true
        |(_, 1) -> true
        |(n, m) when n%m = 0 -> false
        |(n, m) -> check (n, (m-1))
    check (n, n-1)
