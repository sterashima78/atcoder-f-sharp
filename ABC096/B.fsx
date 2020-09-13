let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let readInt () = stdin.ReadLine() |> int

()
|> readIntArray
|> fun x ->
    let y = readInt ()
    let max = x |> Array.max
    max
    |> ((*) (pown 2 y))
    |> ((+) (Array.sum x))
    |> (-)
    <| max
    |> printfn "%d"
