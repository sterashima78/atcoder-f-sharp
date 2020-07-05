stdin.ReadLine()
let rec toDiff tList fList = 
  match fList with
  | a::b::x -> toDiff ((a - b)::tList) x
  | [a] -> a::tList
  | [] -> tList

stdin.ReadLine().Split(" ") 
  |> Array.toList
  |> List.map int
  |> List.sortBy (fun x -> -1 * x)
  |> toDiff []
  |> List.reduce (+)
  |> printfn "%d"