let readInt () = stdin.ReadLine() |> int
let readCharArray () = stdin.ReadLine().ToCharArray()


readInt ()
|> fun x ->
    readCharArray ()
    |> Array.map int
    |> Array.map ((+) x)
    |> Array.map (fun z -> if z > (int 'Z') then z - 26 else z)
    |> Array.map char
    |> System.String
    |> printfn "%s"
