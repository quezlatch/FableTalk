module App.Types

open Global

type Msg =
  | Increment of int
  | Decrement of int

type Model = {
    Count: int
  }
