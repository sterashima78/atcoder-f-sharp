let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let judge num =
    num
    |> string
    |> fun x -> x.ToCharArray()
    |> Array.rev
    |> System.String
    |> int
    |> (=) num


()
|> readIntArray
|> fun [| a; b |] -> seq { a .. b }
|> Seq.filter judge
|> Seq.length
|> printfn "%d"
