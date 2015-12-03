
#I "../packages/FsUnit/lib/net45"
#r "FsUnit.NUnit.dll"
#r "../packages/NUNit/lib/nunit.framework.dll"
#load "../src/FluentApi.fs"
open Wk.FluentApi
open FsUnit
open NUnit.Framework

{1.0..2.0}.average() |> printfn "%A"
{1..10}.max(100) |> printfn "%A"
