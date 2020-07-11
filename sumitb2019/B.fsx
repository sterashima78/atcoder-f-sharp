let after = stdin.ReadLine() |> int

after
|> float 
|> fun x -> x / 1.08
|> int
|> fun x -> 
  match x with
  | x when int (float x * 1.08) = after -> string x
  | x when int (float (x + 1) * 1.08) = after -> string (x + 1)
  | _ -> ":("
|> printfn "%s"