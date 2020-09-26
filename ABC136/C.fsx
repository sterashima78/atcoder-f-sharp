let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let choice ok ng bool = if bool then ok else ng

stdin.ReadLine()
|> readIntArray
|> Array.fold (fun (ok, before) current ->
    if not ok then (ok, current)
    elif before <= current then (true, current)
    elif before - 1 <= current then (true, current + 1)
    else (false, current)) (true, 0)
|> fst
|> choice "Yes" "No"
|> printfn "%s"
