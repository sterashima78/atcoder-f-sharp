let readInt _ = stdin.ReadLine() |> int

let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readInt
|> fun x -> [ 1 .. x ]
|> List.map readIntArray
|> List.sumBy (fun [| a; b |] -> b - a + 1)
|> printfn "%d"
