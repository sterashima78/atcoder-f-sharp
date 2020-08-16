let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let choice ok ng bool = if bool then ok else ng

readIntArray ()
|> fun [| a; b; c; d |] ->
    let x =
        Seq.initInfinite ((*) b) |> Seq.findIndex ((<=) c)

    let y =
        Seq.initInfinite ((*) d) |> Seq.findIndex ((<=) a)

    x <= y
|> choice "Yes" "No"
|> printfn "%s"
