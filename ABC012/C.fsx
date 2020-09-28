let readInt _ = stdin.ReadLine() |> int

let toDivisors n =
    seq { 1 .. n }
    |> Seq.filter (fun a -> a * a <= n)
    |> Seq.collect (fun x ->
        if n % x = 0 && x * x <> n then
            seq {
                x
                (n / x)
            }
        elif n % x = 0 then
            seq { x }
        else
            Seq.empty)

let rec toStr ans l =
    match l with
    | x :: y :: xx ->
        if x > 9 || y > 9 then
            toStr ans xx
        else
            let str1 = sprintf "%d x %d" x y
            let str2 = sprintf "%d x %d" y x
            toStr (str1 :: str2 :: ans) xx
    | [ x ] ->
        let str = sprintf "%d x %d" x x
        toStr (str :: ans) []
    | [] -> ans |> List.sort |> String.concat "\n"

()
|> readInt
|> (-) 2025
|> toDivisors
|> Seq.toList
|> toStr []
|> printfn "%s"
