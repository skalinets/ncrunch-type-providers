module Tests
open Xunit
open FSharp.Data

type Simple = JsonProvider<""" { "name":"John", "age":94 } """>

[<Fact>]
let test () =
  let simple = Simple.Parse(""" { "name":"Tomas", "age":4 } """)
  Assert.Equal(4,  simple.Age)
  Assert.Equal<string>("Tomas",  simple.Name)
  
