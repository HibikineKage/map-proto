namespace FSharp
open UnityEngine

type Character() =
    inherit MonoBehaviour()
    member this.Start() = Debug.Log("Hello World");