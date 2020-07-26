let nextVal seed =
  if seed % 2 = 0 then seed / 2 else 3 * seed + 1

let rec solve l seed = 
  let n = nextVal seed
  match l with
  | [] -> solve [seed; n] n
  | l -> if List.exists (fun x -> x = n) l then (List.length l) + 1 else solve (n::l) n

stdin.ReadLine() 
|> int 
|> solve [] 
|> printfn "%d"