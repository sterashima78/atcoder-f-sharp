let readInt () = stdin.ReadLine() |> int

let a = readInt ()
let b = readInt ()
let c = readInt ()

Seq.initInfinite ((*) a)
|> Seq.filter (fun x -> x >= c && x % b = 0)
|> Seq.head
|> printfn "%d"
