let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let readDirection _ =
    stdin.ReadLine().Split(" ")
    |> fun [| a; b |] -> (a, int b)

()
|> readIntArray
|> fun [| n; a; b |] ->
    seq { 1 .. n }
    |> Seq.map readDirection
    |> Seq.fold (fun state (dir, dist) ->
        let direction = if dir = "West" then -1 else 1

        let distance =
            if dist < a then a
            elif b < dist then b
            else dist

        state + (direction * distance)) 0
    |> fun x ->
        if x = 0 then printfn "%d" 0
        elif x < 0 then printfn "West %d" (abs x)
        else printfn "East %d" x
