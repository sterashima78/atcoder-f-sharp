let readCharArray () = stdin.ReadLine().ToCharArray()
let choice ok ng bool = if bool then ok else ng

readCharArray ()
|> fun x ->
    x.[0] = 'A'
    && x.[2..(x.Length - 2)]
       |> Array.filter ((=) 'C')
       |> Array.length
       |> ((=) 1)
    && x
       |> Array.filter System.Char.IsUpper
       |> Array.length
       |> ((=) 2)
|> choice "AC" "WA"
|> printfn "%s"
