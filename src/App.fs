module App.View

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.Browser
open Types
open App.State
open Global

importAll "../sass/main.sass"

open Fable.Helpers.React
open Fable.Helpers.React.Props

open Fulma
open Fulma.Elements
open Fulma.Layouts
open Fulma.Extra.FontAwesome

let root model dispatch =
    Container.container [ Container.isFluid ]
        [ Content.content [ ]
            [ 
                h1 [ ] [str "Counter of wonderfulness"]
                div 
                  []
                  [
                      Button.button [ Button.isSmall ; Button.props [ OnClick (fun _ -> Increment(2) |> dispatch) ]] [ 
                          Icon.faIcon [ ] Fa.ArrowUp
                          str "Increment" ]
                      div [] [ model.Count |> sprintf "Val is %A" |> str ]
                      Button.button [ Button.isSmall ; Button.props [ OnClick (fun _ -> Decrement(1) |> dispatch) ]] [ 
                          Icon.faIcon [ ] Fa.ArrowDown
                          str "Decrement" ]
                  ]
            ]
        ]

open Elmish.React
open Elmish.Debug

// App
Program.mkProgram init update root
|> Program.withReact "elmish-app"
#if DEBUG
|> Program.withDebugger
#endif
|> Program.run
