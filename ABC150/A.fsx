let [| k; x |] =
    stdin.ReadLine().Split(" ") |> Array.map int

(if k * 500 >= x then "Yes" else "No")
|> printfn "%s"
