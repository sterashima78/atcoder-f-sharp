let readCharArray () = stdin.ReadLine().ToCharArray()

[| 1 .. 4 |]
|> Array.map (fun _ -> readCharArray () |> Array.rev |> System.String)
|> Array.rev
|> String.concat "\n"
|> printf "%s"
