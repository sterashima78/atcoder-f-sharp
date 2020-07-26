let rec gain money fList =
    match fList with
    | [] -> money
    | [ _ ] -> money
    | (a :: b :: fList) ->
        if a < b then
            let num = money / a
            let newMoney = money + (b - a) * num
            gain newMoney (b :: fList)
        else
            gain money (b :: fList)


stdin.ReadLine()

stdin.ReadLine().Split(" ")
|> Array.map int64
|> Array.toList
|> gain (int64 1000)
|> printfn "%d"
