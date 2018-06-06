namespace FSharp
open UnityEngine

type Node() =
    inherit MonoBehaviour()
    //let mutable line : LineRenderer
    member this.Start() = 
        let line = this.GetComponent<LineRenderer>()
        line.setPositions()
        ()