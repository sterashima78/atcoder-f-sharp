let rec solve (a, b) list =
  match list with 
  | [] -> a - b
  | a1::b1::list -> solve (a + a1, b + b1) list
  | a1::list -> solve (a + a1, b) list

stdin.ReadLine()
stdin.ReadLine().Split(" ") 
|> Array.map int 
|> Array.toList
|> List.sortBy (fun x -> -x)
|> solve (0, 0)
|> printfn "%d"