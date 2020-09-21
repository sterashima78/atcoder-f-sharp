let readInt _ = stdin.ReadLine() |> int
let readArray _ = stdin.ReadLine().Split(" ")

()
|> readInt
|> fun x -> [| 1 .. x |]
|> Array.map readArray
|> fun x ->
    let sum =
        x |> Array.sumBy (fun [| _; a |] -> int a)

    let max =
        x
        |> Array.map (fun [| _; a |] -> int a)
        |> Array.max


    if sum < max * 2 then
        x
        |> Array.find (fun [| _; a |] -> int a = max)
        |> (fun [| a; _ |] -> a)
    else
        "atcoder"
|> printfn "%s"
