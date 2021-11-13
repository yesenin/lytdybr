module yesenin.Func

open FProblem1

[<EntryPoint>]
let main argv =
    let testAnswer = solve 10
    printfn $"Test answer = {testAnswer}"
    
    let answer = solve 1000
    printfn $"Answer = {answer}"
    0