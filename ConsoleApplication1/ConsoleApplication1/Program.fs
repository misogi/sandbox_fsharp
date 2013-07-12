(*
巨大なHello world
Alt + Ctrl + F インタラクティブ起動
Alt + Up / Down 並べ替え
*)

open System

[<EntryPoint>]
let main (args : String[]) = 
    
    if args.Length <> 2 then
        failwith "エラー : 引数 <greeting> と <thing> が必要です"
    
    let greeting, thing = args.[0], args.[1]
    let timeOfDay = DateTime.Now.ToString("hh:mm tt")
    
    printfn "時刻 %s : %s, %s" timeOfDay greeting thing
    
    0 