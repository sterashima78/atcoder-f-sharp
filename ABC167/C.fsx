let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let createBitSeq n =
    { 1 .. pown 2 n - 1 }
    |> Seq.map (fun x -> System.Convert.ToString(x, 2))

let selectByBit (arr: 'a []) (str: string) =
    str.ToCharArray()
    |> Array.rev
    |> Array.mapi (fun index v -> if v = '1' then Some(arr.[index]) else None)
    |> Array.choose id

()
|> readIntArray
|> fun [| n; _; x |] ->
    let data = [| 1 .. n |] |> Array.map readIntArray
    createBitSeq n
    |> Seq.map (selectByBit data >> Array.reduce (Array.map2 (+)))
    |> Seq.filter (fun arr -> arr.[1..] |> Array.forall ((<=) x))
    |> fun s ->
        if Seq.isEmpty s
        then -1
        else s |> Seq.map (fun arr -> arr.[0]) |> Seq.min
|> printfn "%d"
