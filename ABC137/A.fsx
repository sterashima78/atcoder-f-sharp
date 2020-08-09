stdin.ReadLine().Split(" ")
|> Array.map int
|> (fun x ->
    [ for k in [ (*); (-); (-); (+) ] do
        x |> Array.reduce k ])
|> List.max
|> printfn "%d"
