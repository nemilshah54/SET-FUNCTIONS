
// Name: Nemil R Shah
// UIN: 670897116
// netID: nshah213

module Tests

#light

open System
open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestClass () =

  // Isempty test cases.--------------1

  [<TestMethod>]
  member this.isEmpty_T01 () =
    let expected = true
    let actual = Set.isEmpty []
    Assert.AreEqual(expected, actual)
    
  [<TestMethod>]
  member this.isEmpty_T02 () =
    let expected = false
    let actual = Set.isEmpty [1;2;3]
    Assert.AreEqual(expected, actual)
    
    // Ismember test cases.---------------2

  [<TestMethod>]
  member this.isMember_T01 () =
    let expected = true
    let actual = Set.isMember "cat" ["apple";"cat";"dog"]
    Assert.AreEqual(expected, actual) 
    
  [<TestMethod>]
  member this.isMember_T02 () =
    let expected = false
    let actual = Set.isMember 4 [1;2;3]
    Assert.AreEqual(expected, actual) 

  [<TestMethod>]
  member this.isMember_T03 () =
    let expected = false
    let actual = Set.isMember "apple" []
    Assert.AreEqual(expected, actual) 
    
    // Insert test cases.--------------------3
    
  [<TestMethod>]
  member this.insert_T01 () =
    let expected = [1]
    let actual = Set.insert 1 []
    Assert.AreEqual(expected, actual) 
    
  [<TestMethod>]
  member this.insert_T02 () =
    let expected = [1;2;3]
    let actual = Set.insert 2 [1;3]
    Assert.AreEqual(expected, actual) 

  [<TestMethod>]
  member this.insert_T03 () =
    let expected = ["apple";"cat";"dog"]
    let actual = Set.insert "cat" ["apple";"dog"]
    Assert.AreEqual(expected, actual) 
    
    // Remove test cases.----------------4
    
  [<TestMethod>]
  member this.remove_T01 () =
    let expected = ["apple";"dog"]
    let actual = Set.remove "cat" ["apple";"cat";"dog"]
    Assert.AreEqual(expected, actual) 
    
  [<TestMethod>]
  member this.remove_T02 () =
    let expected = [ "dog"]
    let actual = Set.remove "apple" ["apple"; "dog"]
    Assert.AreEqual(expected, actual) 
    
  [<TestMethod>]
  member this.remove_T03 () =
    let expected = ( List.empty : string List)
    let actual = Set.remove "apple" []
    Assert.AreEqual(expected, actual) 
    
  [<TestMethod>]
  member this.remove_T04 () =
    let expected = ( List.empty : int List)
    let actual = Set.remove 1 []
    Assert.AreEqual(expected, actual) 
    
    
    // Size test cases.--------------------5
      
  [<TestMethod>]
  member this.size_T01 () =
    let expected = 2
    let actual = Set.size  ["apple";"dog"]
    Assert.AreEqual(expected, actual) 
    
  [<TestMethod>]
  member this.size_T02 () =
    let expected = 0
    let actual = Set.size []
    Assert.AreEqual(expected, actual) 
    
     
  [<TestMethod>]
  member this.size_T03 () =
    let expected = 1
    let actual = Set.size [1]
    Assert.AreEqual(expected, actual) 
    
    
  // Union Test cases.----------------------6
  
  [<TestMethod>]
  member this.union_T01 () =
    let expected = [1;2;3;4;5]
    let actual = Set.union [1;2;3] [4;5]
    Assert.AreEqual(expected, actual) 
    
  [<TestMethod>]
  member this.union_T02 () =
    let expected = [1;2;3]
    let actual = Set.union [1;2;3] []
    Assert.AreEqual(expected, actual)
    
  [<TestMethod>]
  member this.union_T03 () =
    let expected = ( List.empty : int List)
    let actual = Set.union ( []: int List)  ( []: int List)
    Assert.AreEqual(expected, actual)
    
    
    // Intersection Test Cases----------------------------------7
    
      
  [<TestMethod>]
  member this.intersection_T01 () =
    let expected = [2;3]
    let actual = Set.intersection [1;2;3] [2;3;4]
    Assert.AreEqual(expected, actual)
    
    
          
  [<TestMethod>]
  member this.intersection_T02 () =
    let expected = ( List.empty : int List)
    let actual = Set.intersection ( []: int List)  [2;3;4]
    Assert.AreEqual(expected, actual)
    
    
  [<TestMethod>]
  member this.intersection_T03 () =
    let expected = ( List.empty : int List)
    let actual = Set.intersection [2;3;4] ( []: int List) 
    Assert.AreEqual(expected, actual)
    
  [<TestMethod>]
  member this.intersection_T04 () =
    let expected =  ( List.empty : int List)
    let actual = Set.intersection ( []: int List)  ( []: int List) 
    Assert.AreEqual(expected, actual)   
    
  [<TestMethod>]
  member this.intersection_T05 () =
    let expected = [10;18]
    let actual = Set.intersection [1;5;10;18] [10;18;19;28]
    Assert.AreEqual(expected, actual)
    
    
    // Difference Test cases.-------------------------------8
    
  [<TestMethod>]
  member this.difference_T01 () =
    let expected = [1;2;3;4;5]
    let actual = Set.difference [1;2;3;4;5] [7;8]
    Assert.AreEqual(expected, actual)
    
    
          
  [<TestMethod>]   
  member this.difference_T02 () =
    let expected =  ( List.empty : int List)
    let actual = Set.difference( []: int List)  [2;3;4]
    Assert.AreEqual(expected, actual)
    
    
  [<TestMethod>]
  member this.difference_T03 () =
    let expected = [1;2;5]
    let actual = Set.difference [1;2;3;4;5] [3;4;6]
    Assert.AreEqual(expected, actual)
    
  [<TestMethod>]  
  member this.difference_T04 () =
    let expected = ( List.empty : int List)
    let actual = Set.difference ( []: int List) ( []: int List) 
    Assert.AreEqual(expected, actual)
    
  [<TestMethod>]
  member this.difference_T05 () =
    let expected = [1;2;3]
    let actual = Set.difference [1;2;3] ( []: int List) 
    Assert.AreEqual(expected, actual)
    
    // Subset Test cases.------------------------------9
    
  [<TestMethod>]
  member this.subset_T01 () =
    let expected = true
    let actual = Set.subset [1;2] [1;2;3]
    Assert.AreEqual(expected, actual) 
      
      
      
  [<TestMethod>]
  member this.subset_T02 () =
    let expected = true
    let actual = Set.subset [] [1;2;3]
    Assert.AreEqual(expected, actual) 
    
        
  [<TestMethod>]
  member this.subset_T03 () =
    let expected = true
    let actual = Set.subset [] []
    Assert.AreEqual(expected, actual) 
    
            
  [<TestMethod>]
  member this.subset_T04 () =
    let expected = false
    let actual = Set.subset [1;2;3] [1;2;4;5;6]
    Assert.AreEqual(expected, actual) 
    
  [<TestMethod>]
  member this.subset_T05 () =
    let expected = true
    let actual = Set.subset [1;2;3] [1;2;3]
    Assert.AreEqual(expected, actual) 
    
    
        
    // Equivalent Test cases---------------------10
    
       
  [<TestMethod>]
  member this.equivalent_T01 () =
    let expected = true
    let actual = Set.equivalent [1;2;3;4] [1;2;3;4]
    Assert.AreEqual(expected, actual) 
    
  [<TestMethod>]
  member this.equivalent_T02 () =
    let expected = true
    let actual = Set.equivalent [] []
    Assert.AreEqual(expected, actual) 
    
  [<TestMethod>]
  member this.equivalent_T03 () =
    let expected = false
    let actual = Set.equivalent [] [2;3]
    Assert.AreEqual(expected, actual) 
    
  [<TestMethod>]
  member this.equivalent_T04 () =
    let expected = false
    let actual = Set.equivalent [1;2;3] []
    Assert.AreEqual(expected, actual) 
    
  [<TestMethod>]
  member this.equivalent_T05 () =
    let expected = false
    let actual = Set.equivalent [1;2;3] [1;2;3;4]
    Assert.AreEqual(expected, actual) 
    
    
        
  [<TestMethod>]
  member this.equivalent_T06 () =
    let expected = false
    let actual = Set.equivalent [1;2;3;4] [1;2;3]
    Assert.AreEqual(expected, actual) 
    
    
    // Product Test cases-------------------------11
    
  [<TestMethod>]
  member this.product_T01 () =
    let expected =   [[1;3]; [1;4]; [2;3]; [2;4] ]
    let actual = Set.product  [1;2] [3;4]
    Assert.AreEqual(expected, actual) 
    
  [<TestMethod>]
  member this.product_T02 () =
    let expected =   ( []: int List List)
    let actual = Set.product  [1;2]   ( []: int List)
    Assert.AreEqual(expected, actual) 
    
    
    
    // Powerset-----------------------------------12
       
  [<TestMethod>]
  member this.powerset_T01 () =
    let expected =   [ []; [1]; [2]; [3]; [1;2]; [1;3]; [2;3]; [1;2;3] ]
    let actual = Set.powerset  [1;2;3]
    Assert.AreEqual(expected, actual) 
    
  [<TestMethod>]
  member this.powerset_T02 () =
    let expected =   [ []; [1]; [2]; [1;2] ]
    let actual = Set.powerset  [1;2]
    Assert.AreEqual(expected, actual) 
    
  [<TestMethod>]
  member this.powerset_T03 () =
    let expected =   [ []; [1] ]
    let actual = Set.powerset  [1]
    Assert.AreEqual(expected, actual) 

    
  
    
    
    
    
    
    
