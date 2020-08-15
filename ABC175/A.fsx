let readCharArray () = stdin.ReadLine().ToCharArray()

readCharArray ()
|> Array.mapFold (fun x y -> (x, (if y = 'R' then x + 1 else 0))) 0
|> fun (a, b) -> a |> Array.tail |> Array.append [| b |]
|> Array.max
|> printfn "%d"
