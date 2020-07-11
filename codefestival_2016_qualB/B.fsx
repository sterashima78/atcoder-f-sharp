let rec solve tList all b fList = 
  match fList with
  | 'a'::l -> if all > 0 then solve ("Yes"::tList) (all - 1) b l else solve ("No"::tList) all b l 
  | 'b'::l -> if all > 0 && b > 0 then solve ("Yes"::tList) (all - 1) (b - 1) l else solve ("No"::tList) all (b - 1) l 
  | _::l -> solve ("No"::tList) all b l 
  | [] -> tList
let [| _; a; b |] = stdin.ReadLine().Split(" ") |> Array.map int

stdin.ReadLine().ToCharArray() 
|> Array.toList 
|> solve [] (a + b) b 
|> List.rev
|> List.map (printfn "%s")