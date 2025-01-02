let mutable x = ref 10
let mutable y = ref 20
let mutable z = ref 30

let swap x y =
    let temp = !x
    x := !y
    y := temp

swap x y
printf "%d %d %d" !x !y !z