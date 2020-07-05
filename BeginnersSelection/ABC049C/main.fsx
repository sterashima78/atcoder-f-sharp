let rec solve str = 
  match str with
  | "d"::"r"::"e"::"a"::"m"::"e"::"r"::x -> if solve x = "YES" then "YES" else solve ("e"::"r"::x)
  | "d"::"r"::"e"::"a"::"m"::x -> solve x
  | "e"::"r"::"a"::"s"::"e"::"r"::x -> if solve x = "YES" then "YES" else solve ("r"::x)
  | "e"::"r"::"a"::"s"::"e"::x -> solve x
  | [] -> "YES"
  | _ -> "NO"

stdin.ReadLine() |> Seq.toList |> List.map string |> solve |> printfn "%s"