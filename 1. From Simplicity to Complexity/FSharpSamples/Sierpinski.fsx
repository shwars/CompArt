﻿#load @"..\CompArt_FromSimplicityToComplexity\packages\FSharp.Charting.0.90.13\FSharp.Charting.fsx"
open FSharp.Charting
open System

let mid (x1,y1) (x2,y2) = (x1+x2)/2,(y1+y2)/2 
let mid3 (x1,y1) (x2,y2) (x3,y3) = (x1+x2+x3)/3,(y1+y2+y3)/2

let Rnd = new Random()
let pick (L:'t list) = L.[Rnd.Next(0,Seq.length L)]

let sierpinski (p1,p2,p3) =
   let rec sierpinski' pt =
      seq {
        let p = pick [p1;p2;p3]
        let pt' = mid pt p
        yield pt'
        yield! sierpinski' pt'
      }
   sierpinski' (mid3 p1 p2 p3)
    
sierpinski ((0,0),(300,600),(600,0)) |> Seq.take 5000 |> Chart.FastPoint

