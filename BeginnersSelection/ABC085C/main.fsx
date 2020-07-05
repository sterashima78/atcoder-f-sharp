let [| n; sum |] = stdin.ReadLine().Split(" ") |> Array.map int

seq {
  for x in 0 .. n do
    for y in 0 .. (n - x) -> (x, y, n - x - y)
} 
|> Seq.filter (fun (x, y, z) -> (x * 10000 + y * 5000 + z * 1000) = sum)
|> Seq.tryFind (fun _ -> true) 
|> fun x -> 
  match x with
  | Some y -> y
  | None -> (-1, -1, -1)
|> fun (x, y ,z) -> printfn "%d %d %d" x y z