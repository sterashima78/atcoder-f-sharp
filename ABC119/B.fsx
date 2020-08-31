let readInt () = stdin.ReadLine() |> int

let readMoney () =
    stdin.ReadLine().Split(" ")
    |> fun [| x; y |] -> (float x, y)

[ 1 .. (readInt ()) ]
|> List.map (fun _ -> readMoney ())
|> List.sumBy (fun (money, unit) -> if unit = "JPY" then money else money * 380000.0)
|> printfn "%f"
