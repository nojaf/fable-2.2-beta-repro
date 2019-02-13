module App.View

open Fable.Helpers.React
open Fable.Helpers.React.Props
open App.Types

let view (model:Model) dispatch =

    div []
        [ button [ OnClick (fun _ -> dispatch Increment) ] [ str "+" ]
          div [] [ str (string model) ]
          button [ OnClick (fun _ -> dispatch Decrement) ] [ str "-" ] ]