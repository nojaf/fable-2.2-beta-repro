module App.Main

open Elmish
open Elmish.React
open App

Program.mkSimple State.init State.update View.view
|> Program.withReact "elmish-app"
|> Program.withConsoleTrace
|> Program.run
