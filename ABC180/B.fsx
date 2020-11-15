let readFloatArray _ =
    stdin.ReadLine().Split(" ") |> Array.map double

let solve x =
    let (a, b, c) =
        x
        |> Array.fold (fun (a, b, c) z -> (a + abs z, b + z * z, max c (abs z))) (double 0.0, double 0.0, double 0.0)

    (a, sqrt b, c)

stdin.ReadLine()
|> readFloatArray
|> solve
|> fun (a, b, c) -> printfn "%A\n%A\n%A" a b c
