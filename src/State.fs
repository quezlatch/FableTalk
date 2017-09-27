module App.State

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Import.Browser
open Global
open Types


let init result =
  {Count = 0}, Cmd.none

let update msg model =
  match msg with
  | Increment inc -> {model with Count = model.Count + inc}, Cmd.none
  | Decrement dec -> {model with Count = model.Count - dec}, Cmd.none
  | TwoStepsForwardOneStepBack -> 
    model, Cmd.batch [
      Increment(2) |> Cmd.ofMsg
      Decrement(1) |> Cmd.ofMsg
    ]
