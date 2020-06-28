let toMemo f =
    let mutable table = Map.empty

    let rec _memo a =
        match Map.tryFind a table with
        | Some x -> x
        | None ->
            let x = f _memo a
            table <- Map.add a x table
            x

    _memo
