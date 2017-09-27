module App.Types

open Global

type Msg =
  | Increment of int
  | Decrement of int
  | TwoStepsForwardOneStepBack

type Model = {
    Count: int
  }
