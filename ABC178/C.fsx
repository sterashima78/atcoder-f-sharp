let readInt _ = stdin.ReadLine() |> int64

let modPown m x y =
    seq { 1 .. y }
    |> Seq.fold (fun a _ -> a * x % m) 1L

let mpown = modPown (int64 1e9 + 7L)

()
|> readInt
|> fun x ->
    if x = 1L then
        0L
    else if x = 2L then
        2L
    else
        let a = mpown 10L (int x)
        let b = mpown 9L (int x)
        let c = mpown 8L (int x)
        let ans = (a - b - b + c) % (int64 1e9 + 7L)
        (ans + (int64 1e9 + 7L)) % (int64 1e9 + 7L)
|> printfn "%d"
