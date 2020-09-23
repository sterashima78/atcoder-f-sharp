let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

let solve n k = k * pown (k - 1L) (int n - 1)

()
|> readIntArray
|> fun [| n; k |] -> solve n k
|> printfn "%d"
