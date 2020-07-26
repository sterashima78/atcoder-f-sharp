let solve i = 
  if i <= 599 then
    8
  else if i <= 799 then
    7
  else if i <= 999 then
    6
  else if i <= 1199 then
    5
  else if i <= 1399 then
    4
  else if i <= 1599 then
    3
  else if i <= 1799 then
    2
  else
    1

stdin.ReadLine() 
|> int 
|> solve
|> printfn "%d" 
  
  
