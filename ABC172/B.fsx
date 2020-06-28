let arr1 = stdin.ReadLine().ToCharArray()
let arr2 = stdin.ReadLine().ToCharArray()

Array.zip arr1 arr2
|> Array.map (fun (a, b) -> if a = b then 0 else 1)
|> Array.reduce (+)
|> printfn "%d"
