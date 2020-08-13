stdin.ReadLine()
|> int
|> (%)
<| 500
|> fun x -> if x <= (stdin.ReadLine() |> int) then "Yes" else "No"
|> printfn "%s"
