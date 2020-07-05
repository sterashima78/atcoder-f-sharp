let rec uniq tList fList =
  match fList with
    | x::y::z -> if x = y then uniq tList (y::z) else uniq (x::tList) (y::z)
    | x::z -> uniq (x::tList) z
    | [] -> tList
 
let numOfPlate = stdin.ReadLine() |> int

[1 .. numOfPlate] 
  |> List.map (fun _ -> stdin.ReadLine() |> int )
  |> List.sort
  |> uniq []
  |> List.length
  |> printfn "%d"