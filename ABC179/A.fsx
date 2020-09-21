let readCharArray _ = stdin.ReadLine().ToCharArray()

()
|> readCharArray
|> fun a -> if (a |> Array.last) = 's' then Array.concat [ a; [| 'e'; 's' |] ] else Array.concat [ a; [| 's' |] ]
|> System.String
|> printfn "%s"
