let rec solve red green blue rest =
    match rest with
    | 0 -> if red < green && green < blue then "Yes" else "No"
    | rest ->
        if red >= green then solve red (green * 2) blue (rest - 1)
        else if green >= blue then solve red green (blue * 2) (rest - 1)
        else "Yes"

let [| red; green; blue |] =
    stdin.ReadLine().Split(" ") |> Array.map int

stdin.ReadLine()
|> int
|> solve red green blue
|> printfn "%s"
