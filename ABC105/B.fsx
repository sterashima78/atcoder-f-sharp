let readInt () = stdin.ReadLine() |> int
let choice ok ng bool = if bool then ok else ng

readInt ()
|> fun x ->
    Array.allPairs [| 0 .. x / 4 |] [| 0 .. x / 7 |]
    |> Array.tryFind (fun (f, s) -> (f * 4 + s * 7) = x)
    |> Option.isSome
    |> choice "Yes" "No"
    |> printfn "%s"
