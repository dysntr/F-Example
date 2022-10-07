printfn "Hello World from F#"

// #Myfirstcript.fsx
// fsx is F# script file... cli interperter ('fsi')
// fsx file will be executed as a script gets executed 

// #Program.fs
// .net complier will turn into a complied applications
// compile to -> .exe (requires .net run time), single file packaged bin file (static link lib)
// reflection** - language construct for a program to examine itself.. eg. java, c# (.net languages)
// F# interplated strings use reflection 


let toPigLatin (word: string) =
    let isVowel (c: char) =
        match c with        //F# forces you to match everything
        | 'a' | 'e' | 'i' |'o' |'u' | 'A' | 'E' | 'I' | 'O' | 'U' -> true
        //|x -> true //hold the match as x, everything match
        |_ -> false //default or fall through _ -> means you don't care
    
    if (isVowel word[0]) then
        word + "yay"    //whitespace and indentition importance
    // currying - allows for partial applications (optional parameters), bind presets to different names (ex. http request to RPC in web3.fs)
    // vs. not currying eg. isVowel(word[0]

    else
        word[1..] + string(word[0]) + "ay" //for string concat all types have to be the same
