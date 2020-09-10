let readCharArray () = stdin.ReadLine().ToCharArray()
let choice ok ng bool = if bool then ok else ng

let rec solve count target query =
    if Array.zip target query
       |> Array.filter (fun (a, b) -> a <> b)
       |> Array.length
       |> ((=) 0) then
        true
    else if target |> Array.length |> (=) count then
        false
    else
        solve
            (count + 1)
            target
            (Array.concat [ (query |> Array.tail)
                            [| query |> Array.head |] ])


()
|> readCharArray
|> solve 0
<| (readCharArray ())
|> choice "Yes" "No"
|> printfn "%s"
