stdin.ReadLine()
stdin.ReadLine().Split(" ") 
|> Array.map int
|> Array.sort
|> fun a ->
  let p = Array.length a / 2
  a.[p] - a.[p - 1]
|> printfn "%d"
