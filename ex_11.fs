type F = 
  | AM
  | PM

type TimeOfDay = { hours : int; minutes : int; f: F }

let (.>.) x y = 
    let compare = function
        |(x, y) when x.f > y.f -> true
        |(x, y) when x.f < y.f -> false
        |(x, y) when x.hours > y.hours -> true
        |(x, y) when x.hours < y.hours -> false
        |(x, y) when x.minutes > y.minutes -> true
        |_ -> false
    compare (x,y)
    
(*
let a = {hours = 12; minutes = 1; f= AM }
let b = {hours = 1; minutes = 1; f= PM }
printfn "%b" (b .>. a)
*)
