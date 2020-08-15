let readInt () = stdin.ReadLine() |> int

let a = readInt ()
let b = readInt ()

if a % b = 0 then 0 else b - (a % b)
|> printfn "%d"
