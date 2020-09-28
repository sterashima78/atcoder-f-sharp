let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

()
|> readIntArray
|> fun [| x; y |] -> Seq.unfold (fun z -> if y >= z then Some(z, z * 2L) else None) x
|> Seq.length
|> printfn "%d"
