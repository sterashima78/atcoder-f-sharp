let isMovable (t1, x1, y1) (t2, x2, y2) =
  let t = t2 - t1
  let dist = abs (x1 - x2) + abs (y1 - y2)
  dist <= t && ((t % 2) = (dist % 2))

let rec solve l = 
  match l with
  | p1::[p2] -> if isMovable p1 p2 then "Yes" else "No"
  | p1::p2::x -> if isMovable p1 p2 then solve (p2::x) else "No"
  | [p] -> if isMovable (0, 0, 0) p then "Yes" else "No"
  | _ -> "??"

let numOfLine = stdin.ReadLine() |> int
[
  for _ in 1 .. numOfLine -> 
    stdin.ReadLine().Split(" ") 
    |> Array.map int 
    |> (fun [| t; x; y|] -> (t, x, y)) 
] |> solve |> printfn "%s"

