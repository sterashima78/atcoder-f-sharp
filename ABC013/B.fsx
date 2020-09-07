let readInt () = stdin.ReadLine() |> int

(readInt (), readInt ())
|> fun (now, target) ->
    let a =
        if target > now then now - target else target - now

    let x = (abs a)
    let y = (abs (a + 10))
    if x > y then y else x
|> printfn "%d"
