let readCharArray () = stdin.ReadLine().ToCharArray()
let choice ok ng bool = if bool then ok else ng

()
|> readCharArray
|> fun x ->
    x
    |> Array.zip (() |> readCharArray)
    |> Array.filter (fun (x, y) ->
        x = y
        || x = '@'
           && (y = 'a'
               || y = 't'
               || y = 'c'
               || y = 'o'
               || y = 'd'
               || y = 'e'
               || y = 'r')
        || y = '@'
           && (x = 'a'
               || x = 't'
               || x = 'c'
               || x = 'o'
               || x = 'd'
               || x = 'e'
               || x = 'r'))
    |> Array.length
    |> (=) (x |> Array.length)
    |> choice "You can win" "You will lose"
    |> printfn "%s"
