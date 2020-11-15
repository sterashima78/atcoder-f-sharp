let readInt _ = stdin.ReadLine() |> int64

let solve t f target =
    let mutable memo = Map.empty

    let rec _solve three five =
        match memo.TryFind((three, five)) with
        | Some a -> a
        | None ->
            let a = pown 3L three
            let b = pown 5L five
            if target - a = b then
                sprintf "%d %d" three five
            elif target - a < b then
                "-1"
            else
                let x = _solve (three + 1) five
                memo <- memo.Add(((three + 1), five), x)
                if x = "-1" then
                    let y = _solve three (five + 1)
                    memo <- memo.Add((three, (five + 1)), y)
                    y
                else
                    x

    _solve t f


() |> readInt |> solve 0 0 |> printfn "%s"
