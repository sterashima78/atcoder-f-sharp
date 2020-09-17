let readInt _ = stdin.ReadLine() |> int
let modmul m x y = ((x % m) * (y % m)) % m
let mul = modmul 1000000007L

()
|> readInt
|> Seq.init
<| (fun x -> (x + 1) |> int64)
|> Seq.reduce mul
|> printfn "%d"
