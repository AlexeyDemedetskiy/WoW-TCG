﻿// This file is a script that can be executed with the F# Interactive.  
// It can be used to explore and test the library project.
// Note that script files will not be part of the project build.

#r "E:\Coding\HAP\HtmlAgilityPack.dll"

#load "Web.fs"
#load "Parser.fs"

open Parser
open HtmlAgilityPack

let GetCard =
    let html = Web.LoadCard "Bloodsoul"
    let doc = new HtmlAgilityPack.HtmlDocument()
    doc.LoadHtml(html)
    Parser.ParseCard(doc.DocumentNode)
