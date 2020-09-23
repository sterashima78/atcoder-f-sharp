let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let uniqArray x = x |> Array.groupBy id |> Array.map fst
let choice ok ng bool = if bool then ok else ng

stdin.ReadLine()

()
|> readIntArray
|> fun x ->
    stdin.ReadLine()
    let all = x |> Array.append (readIntArray ())
    all |> uniqArray |> Array.length |> (=) all.Length
|> choice "YES" "NO"
|> printfn "%s"
