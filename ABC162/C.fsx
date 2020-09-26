let readInt _ = stdin.ReadLine() |> int64
let rec gcd a b = if b = 0L then a else gcd b (a % b)
let gcd3 a b c = a |> gcd b |> gcd c

()
|> readInt
|> fun x ->
    seq {
        for a in 1L .. x do
            for b in 1L .. x do
                for c in 1L .. x do
                    (a, b, c)
    }
|> Seq.sumBy (fun (a, b, c) -> gcd3 a b c)
|> printfn "%d"
