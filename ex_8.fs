let curry f x y = f(x,y)
let uncurry g = function (x,y) -> (g x) y
