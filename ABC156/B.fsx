let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let rec solve k n c =
    if n / k > 0 then solve k (n / k) (c + 1) else c

readIntArray ()
|> fun [| n; k |] -> solve k n 1
|> printfn "%d"
