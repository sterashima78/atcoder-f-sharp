let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

stdin.ReadLine()

()
|> readIntArray
|> Array.sumBy (fun x ->
    let r = x % 6
    if r >= 3 then r - 3
    else if r = 0 then 3
    else r - 1)
|> printfn "%d"
