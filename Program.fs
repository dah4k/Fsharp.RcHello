// Copyright 2025 dah4k
// SPDX-License-Identifier: EPL-2.0

module Fsharp.RcHello

let loadEmbeddedFile (pathname: string) : string =
    $"TODO: loadEmbeddedFile %s{pathname}"

[<EntryPoint>]
let main args =
    printfn "Hello from F#"
    printfn $"""%s{loadEmbeddedFile "/path/to/some/file"}"""
    0
