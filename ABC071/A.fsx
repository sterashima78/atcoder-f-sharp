stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| x; a; b |] ->
    if (System.Math.Abs(x - a)) > (System.Math.Abs(x - b))
    then "B"
    else "A"
|> printfn "%s"
