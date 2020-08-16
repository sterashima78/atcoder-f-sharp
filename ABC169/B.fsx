let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int64

readIntArray ()

readIntArray ()
|> Array.fold (fun x y ->
    if y = 0L then 0L
    else if x <= -1L || x > 1000000000000000000L / y then -1L
    else x * y) 1L
|> fun x -> if x > 1000000000000000000L then -1L else x
|> printfn "%d"
