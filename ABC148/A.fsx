let a = stdin.ReadLine() |> int
let b = stdin.ReadLine() |> int

(if a + b = 3 then 3
 else if a + b = 4 then 2
 else 1)
|> printfn "%d"
