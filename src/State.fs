module App.State

open App.Types

let init() : Model = 0

let update (msg:Msg) (model:Model) =
    match msg with
    | Increment -> model + 1
    | Decrement -> model - 1