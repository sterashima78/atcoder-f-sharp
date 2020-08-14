let n = stdin.ReadLine() |> int
let k = stdin.ReadLine() |> int
let x = stdin.ReadLine() |> int
let y = stdin.ReadLine() |> int

if n < k then n * x else k * x + (n - k) * y
|> printfn "%d"
