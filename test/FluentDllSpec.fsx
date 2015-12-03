#r "../out/library.dll"

open Wk.FluentApi

let MySeq() =
    let x = {1.0 .. 10.0}
    x.average()

MySeq() |> printfn "%A"