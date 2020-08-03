let [| _; _; c; d; e; f |] = stdin.ReadLine().ToCharArray()

(if c = d && e = f then "Yes" else "No")
|> printfn "%s"
