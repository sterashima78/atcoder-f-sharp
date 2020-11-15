let toDivisors n =
    seq { 1L .. (n |> double |> sqrt |> int64) }
    |> Seq.collect (fun x ->
        if n % x = 0L && x * x <> n then
            seq {
                x
                (n / x)
            }
        elif n % x = 0L then
            seq { x }
        else
            Seq.empty)

let readInt _ = stdin.ReadLine() |> int64

()
|> readInt
|> toDivisors
|> Seq.sort
|> Seq.map string
|> String.concat "\n"
|> printfn "%s"
