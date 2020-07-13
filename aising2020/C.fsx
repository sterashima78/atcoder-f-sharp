let calc (x, y, z) = x * x + y * y + z * z + x * y + y * z + z * x

let count (x, y, z) = 
  if x = y && x = z then 
    1
  else if x <> y && y <> z && z <> x then
    6
  else 
    3

let n = stdin.ReadLine() |> int

seq {
    for x in 1 .. n do
      if calc (x, 1, 1) <= n then
        for y in 1 .. x do
          if calc (x, y, 1) <= n then
            for z in 1 .. y do
              if calc (x, y, z) <= n then yield (calc (x, y, z), count (x, y, z))
} 
|> Seq.append (seq {for k in 1 .. n -> (k, 0)})
|> Seq.groupBy (fun (calc, _) -> calc)
|> Seq.sortBy (fun (i, _)-> i)
|> Seq.map (fun (_, items) -> Seq.fold (fun sum (_, num) -> sum + num) 0 items)
|> Seq.iter (printfn "%d")
