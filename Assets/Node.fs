namespace FSharp
open UnityEngine

type Node() =
    inherit MonoBehaviour()
    //let mutable line : LineRenderer
    member this.Start() = 
        let line = this.GetComponent<LineRenderer>()
        this.transform.position <- this.transform.position + new Vector3(1.0f, 0.0f, 0.0f)
        line.setPositions()
        ()