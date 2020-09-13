let readInt _ = stdin.ReadLine() |> int

Array.concat [

               [| 1 .. () |> readInt |]
               |> Array.map (fun _ -> (stdin.ReadLine(), 1))
               [| 1 .. () |> readInt |]
               |> Array.map (fun _ -> (stdin.ReadLine(), -1)) ]
|> Array.groupBy fst
|> Array.map (fun (_, arr) -> arr |> Array.sumBy snd)
|> Array.max
|> fun x -> if x < 0 then 0 else x
|> printfn "%d"
