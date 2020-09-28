let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

stdin.ReadLine()
|> readIntArray
|> Array.groupBy (fun x ->
    if x >= 3200 then "A"
    elif x >= 2800 then "B"
    elif x >= 2400 then "C"
    elif x >= 2000 then "D"
    elif x >= 1600 then "E"
    elif x >= 1200 then "F"
    elif x >= 800 then "G"
    elif x >= 400 then "H"
    else "I")
|> Array.fold (fun (min, max) (x, arr) -> if x = "A" then (min, max + (arr |> Array.length)) else (min + 1, max + 1))
       (0, 0)
|> fun (a, b) -> if a = 0 then printfn "1 %d" b else printfn "%d %d" a b
