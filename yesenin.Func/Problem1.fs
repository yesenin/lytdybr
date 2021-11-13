module FProblem1

let predicate n =
    n % 3 = 0 || n % 5 = 0

let solve n =
    let range = [ 1 .. n - 1 ]
    List.filter predicate range |> List.sum