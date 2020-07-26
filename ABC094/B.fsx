let [| n; m; x |] = stdin.ReadLine().Split(" ") |> Array.map int

let gates = stdin.ReadLine().Split(" ") |> Array.map int

let costToZero = gates |> Array.filter (fun a -> a < x) |> Array.length
let costToN = gates |> Array.filter (fun a -> a > x) |> Array.length

min costToZero costToN |> printfn "%d"