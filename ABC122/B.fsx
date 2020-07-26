let rec solve maxLen current rest =
  match rest with
  | 'A'::x -> solve maxLen (current + 1) x
  | 'C'::x -> solve maxLen (current + 1) x
  | 'G'::x -> solve maxLen (current + 1) x
  | 'T'::x -> solve maxLen (current + 1) x
  | _::x -> if current > maxLen then solve current 0 x else solve maxLen 0 x
  | [] -> if current > maxLen then current else maxLen

stdin.ReadLine().ToCharArray()
|> Array.toList
|> solve 0 0
|> printfn "%d"