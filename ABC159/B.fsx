let readCharArray () = stdin.ReadLine().ToCharArray()
let choice ok ng bool = if bool then ok else ng

let isPalindrome (chars: char []) =
    chars
    |> System.String
    |> (=)
    <| (chars |> Array.rev |> System.String)

readCharArray ()
|> fun x ->
    let num =
        x
        |> Array.length
        |> fun a -> (a - 1) / 2

    let a = x |> isPalindrome
    let b = x |> Array.take num |> isPalindrome

    let c =
        x |> Array.rev |> Array.take num |> isPalindrome

    a && b && c
|> choice "Yes" "No"
|> printfn "%s"
