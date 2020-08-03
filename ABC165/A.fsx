let a = stdin.ReadLine() |> int

let [| f; t |] =
    stdin.ReadLine().Split(" ") |> Array.map int

seq { f .. t }
|> Seq.exists (fun x -> x % a = 0)
|> (fun x -> if x then "OK" else "NG")
|> printfn "%s"
