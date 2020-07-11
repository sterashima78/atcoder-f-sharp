let rec mark marked list nums = 
  match list with
  | [] -> marked
  | (r, c, n)::list -> if List.exists (fun x -> n = x) nums then mark ((r, c)::marked) list nums else mark marked list nums

let jedge list =
  let hasRowLine l num = l |> List.filter (fun (r, _) -> r = num) |> List.length |> (fun x -> x >= 3)
  let hasColLine l num = l |> List.filter (fun (_, c) -> c = num) |> List.length |> (fun x -> x >= 3)
  if hasRowLine list 1 then
    "Yes"
  else if hasRowLine list 2 then
    "Yes"
  else if hasRowLine list 3 then
    "Yes"
  else if hasColLine list 1 then
    "Yes"
  else if hasColLine list 2 then
    "Yes"
  else if hasColLine list 3 then
    "Yes"
  else if list |> List.filter (fun (r,c) -> r = c) |> List.length |> (fun x -> x = 3) then
    "Yes"
  else if list |> List.filter (fun (r,c) -> (r = 1 && c = 3) || (r = 3 && c = 1) || (r = 2 && c = 2)) |> List.length |> (fun x -> x = 3) then
    "Yes"
  else
    "No"

let l1 = stdin.ReadLine().Split(" ") |> Array.map int |> Array.indexed |> Array.map (fun (i, num) -> (1, i + 1, num)) |> Array.toList
let l2 = stdin.ReadLine().Split(" ") |> Array.map int |> Array.indexed |> Array.map (fun (i, num) -> (2, i + 1, num)) |> Array.toList
let l3 = stdin.ReadLine().Split(" ") |> Array.map int |> Array.indexed |> Array.map (fun (i, num) -> (3, i + 1, num)) |> Array.toList


let l = List.append l1 l2 |> List.append l3
let n = stdin.ReadLine() |> int

[1 .. n] 
|> List.map (fun _ -> stdin.ReadLine() |> int)
|> mark [] l
|> jedge
|> printfn "%s"