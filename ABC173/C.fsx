let [| h; w; k |] = stdin.ReadLine().Split(" ") |> Array.map int

let f = 
    [| 0 .. (h - 1) |]
    |> Array.map (fun row -> 
      stdin.ReadLine().ToCharArray() 
      |> Array.indexed 
      |> Array.map (fun (col, cell) -> (row, col, string cell)))
    |> Array.reduce Array.append


let rec toMaskIndex num indexes mask = 
  let d = pown 2 num
  let next = num - 1
  match num with
    | -1 -> indexes
    | num -> if mask >= d then toMaskIndex next (num::indexes) (mask - d) else toMaskIndex next indexes mask

let isUse rows cols (r, c, _) =
  let hasRow = List.exists (fun elem -> elem = r) rows
  let hasCol = List.exists (fun elem -> elem = c) cols
  hasRow && hasCol

let isBlack (_, _, cell) = cell = "#"

let countBlack field (row, col) =
  let rows = toMaskIndex h [] row
  let cols = toMaskIndex w [] col  
  field 
  |> Array.filter (isUse rows cols)
  |> Array.filter isBlack
  |> Array.length

[
  for k in 0 .. ((pown 2 h) - 1) do
    for j in 0 .. ((pown 2 w) - 1) -> (k, j)
] 
|> List.map (countBlack f)
|> List.filter (fun x -> x = k)
|> List.length
|> printfn "%d"