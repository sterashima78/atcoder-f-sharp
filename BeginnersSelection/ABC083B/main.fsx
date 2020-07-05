let [| n; a; b |] =
    stdin.ReadLine().Split(" ") |> Array.map int

let rec sumOfEachNum num sum =
    match num with
    | 0 -> sum
    | num -> sumOfEachNum (num / 10) (sum + num % 10)

let isSumOfEachNumInnerRange under upper num =
  let sum = sumOfEachNum num 0
  under <= sum && sum <= upper

[ 1 .. n ] |> List.filter (isSumOfEachNumInnerRange a b)
  |> List.reduce (+)
  |> printfn "%d"