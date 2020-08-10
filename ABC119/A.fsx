stdin.ReadLine().Split("/")
|> Array.map int
|> Array.rev
|> Array.take 2
|> (fun [| _; m |] -> if m >= 5 then "TBD" else "Heisei")
|> printfn "%s"
