(if stdin.ReadLine() = "1" then
    "Hello World"
 else
     ((stdin.ReadLine() |> int)
      + (stdin.ReadLine() |> int)
      |> string))
|> printfn "%s"
