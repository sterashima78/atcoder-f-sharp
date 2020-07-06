let rec solve (ac, wa, tle, re) list = 
  match list with
  | "AC"::xx -> solve (ac + 1, wa, tle, re) xx
  | "WA"::xx -> solve (ac, wa + 1, tle, re) xx
  | "TLE"::xx -> solve (ac, wa, tle + 1, re) xx
  | "RE"::xx  -> solve (ac, wa, tle, re + 1) xx
  | _::xx -> solve (ac, wa, tle, re) xx
  | [] -> (ac, wa, tle, re)
let numOfAns = stdin.ReadLine() |> int
[for _ in 1 .. numOfAns -> stdin.ReadLine()] 
  |> solve (0, 0, 0, 0)
  |> fun (ac, wa, tle, re) -> 
    printfn "AC x %d\nWA x %d\nTLE x %d\nRE x %d" ac wa tle re