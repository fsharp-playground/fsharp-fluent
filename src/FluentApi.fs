namespace Wk

module FluentApi =

    open System.Runtime.CompilerServices

    [<Extension>]
    [<AutoOpen>]
    type SeqExtensions =
        [<Extension>]
        static member inline max(source: 'T seq, x:int) = Seq.max  source
        [<Extension>]
        static member inline average(source: 'T seq) = Seq.average source


