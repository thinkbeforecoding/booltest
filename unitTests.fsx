#r "bin/test_fs_optimized.dll"

let shouldBeAlphaNum c =
    if Test.isAlphaNum c then
        printfn "[OK]"
    else
        printfn "[Failure] '%c' should be alpha num" c
        failwith "Test failed"

let shouldNotBeAlphaNum c =
    if not (Test.isAlphaNum c) then
        printfn "[OK]"
    else
        printfn "[Failure] '%c' should not be alpha num" c
        failwith "Test failed"


'/' |> shouldNotBeAlphaNum // before '0'

'0' |> shouldBeAlphaNum // in 1st range

':' |> shouldNotBeAlphaNum // between '0' and 'A'

'A' |> shouldBeAlphaNum  // in 2nd range

'[' |> shouldNotBeAlphaNum // after 'Z'