let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let readInt _ = stdin.ReadLine() |> int

let modadd m x y = (x + y) % m
let add = modadd 1000000007

let solve top current hole =
    let mutable memo = Map.empty

    let rec _solve top current hole =
        match memo.TryFind current with
        | Some n -> n
        | None ->
            let tmpHole = Array.concat [ hole; [| -1; -1 |] ]
            if current = top then
                1
            elif current > top then
                0
            elif tmpHole.[0] = current
                 + 1
                 && tmpHole.[1] = current + 2 then
                0
            elif tmpHole.[0] = current + 1 then
                let ans =
                    _solve top (current + 2) (hole |> Array.tail)

                memo = memo.Add(current, ans)
                ans
            elif tmpHole.[0] = current + 2 then
                let ans = _solve top (current + 1) hole
                memo = memo.Add(current, ans)
                ans
            else
                let ans =
                    add (_solve top (current + 1) hole) (_solve top (current + 2) hole)

                memo = memo.Add(current, ans)
                ans

    _solve top current hole

()
|> readIntArray
|> fun [| n; m |] -> [| 1 .. m |] |> Array.map readInt |> solve n 0
|> printfn "%d"
