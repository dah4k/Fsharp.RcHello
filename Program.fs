// Copyright 2025 dah4k
// SPDX-License-Identifier: EPL-2.0

module Fsharp.RcHello

open System.IO
open System.Reflection
open System.Text
open System

let loadEmbeddedFile (pathname: string) : string =
    let info = Assembly.GetExecutingAssembly().GetName()
    let name = info.Name
    use stream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"{name}.{pathname.Replace('/', '.')}")
    use streamReader = new StreamReader(stream, Encoding.UTF8)
    streamReader.ReadToEnd()

[<EntryPoint>]
let main args =
    Console.WriteLine "Hello from F#"
    Console.Write $"""%s{loadEmbeddedFile "Files/greetings.txt"}"""
    0
