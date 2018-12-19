   
// Name: Nemil R Shah
// UIN: 670897116
// netID: nshah213
// 
module Set

#light

//
// returns true if set S is empty [], false if not
// 
let rec isEmpty S = 
  match S with
  | [] -> true
  | _  -> false

//
// returns true if x is in S, false if not
// 
let rec isMember x S = 
   match S with
   | [] -> false
   | e::rest when e = x -> true
   | e::rest -> isMember x rest
   

//
// returns the # of elements in the set
//
let rec size S = 
    match S with
    |  [] -> 0
    |  e::rest -> 1 + size rest

//
// inserts x into S, returning the new set S'
// 
// NOTE #1: elements are inserted in order using <.
// NOTE #2: if x exists in S, then S is returned unchanged.
// 
let rec insert x S = 
   match S with
   | [] -> [x]        // Base case. If list is empty, insert the value.
   | e:: rest when isMember x S = true -> S  // If duplicates found, then return the same list.
   | e:: rest -> if x < e then x:: ( insert e rest)
                 else e:: ( insert x rest)
                 
                 

//
// removes x from S, returning the new set S'
// 
// NOTE: if x is not in S, then S is returned unchanged.
//  // need some correction.
let rec remove x S = 
    match S with
    | [] -> []
    | e:: rest -> if e =x then remove x rest
                  else
                     e:: remove x rest

//
// returns true is A is a subset of B, false if not
//
let rec subset A B = 
  match A with
  | []        -> true
  | hd1::tl1  -> (isMember hd1 B) && (subset tl1 B)

// 
// returns true if A and B contain the same elements,
// false if not
//
let rec equivalent A B =
  match A, B with
  | [], [] -> true
  | [], _  -> false 
  | _ , [] -> false
  | hd1:: tl1, hd2::tl2 -> if hd1= hd2 then
                              equivalent tl1 tl2
                           else
                              false

//
// returns A union B
// 
// Example:
//   A = [1;2;3;4]
//   B = [2;5;6]
//   ==> [1;2;3;4;5;6]
//
let rec union A B = 
    match  A, B with
    | [], [] -> []  // Base case--1  --two empty lists.
    | [], _ -> B    //  Base case--2   --A empty
    | _, [] -> A    //  Base case--3  --- B empty.
    | e1:: rest1, e2:: rest2 when e1 < e2 -> e1:: union rest1 B     // put for all conditions.
    | e1:: rest1, e2:: rest2 when e1 = e2 -> e1:: union rest1 rest2
    | e1:: rest1, e2:: rest2 when e2 < e1 -> e2:: union A rest2

//
// returns A intersect B
// 
// Example:
//   A = [1;2;3;4]
//   B = [2;4]
//   ==> [2;4]
//
let rec intersection A B = 
    match  A, B with
    | [], [] -> []  // Base case--1  --two empty lists.
    | [], _  -> []    //  Base case--2   --A empty
    | _, []  -> []   //  Base case--3  --- B empty.
    | e1:: rest1, e2:: rest2 when e1 < e2 ->  intersection rest1 B
    | e1:: rest1, e2:: rest2 when e2 < e1 ->  intersection A rest2
    | e1:: rest1, e2:: rest2 when e1 = e2 -> e1:: intersection rest1 rest2  // Only put when it is equal
    
   
// returns A - B
// 
// Example:
//   A = [1;2;3;4]
//   B = [2;4]
//   ==> [1;3]
//   
let rec difference A B = 
    match  A, B with
    | [], [] -> []  // Base case--1  --two empty lists.
    | [], _ ->  []  // Base case--2  -- A empty.
    | _, []  -> A   //  Base case--3  --- B empty.
    | e1:: rest1, e2:: rest2 when e1 < e2 -> e1:: difference rest1 B
    | e1:: rest1, e2:: rest2 when e2 < e1 -> e2:: difference A rest2
    | e1:: rest1, e2:: rest2 when e1 = e2 -> difference rest1 rest2    // put in list for all conditions, but not equal to. It doesnt
                                                                        // A-B has all elements except intersection. 
                                                                    
// 
// returns the cartesian product of A and B:
// 
// Example:
//   A = [1;2]
//   B = [3;4]
//   ==> [ [1;3]; [1;4]; [2;3]; [2;4] ]
// 

// This is a helper function for mapping the cross product of two list.
// This forms as [1,3]; [1,4]. 1 is from A and it is constant. 3 & 4 from list B.
let rec cartesian x B =
    match B with
    | [] -> []
    | e:: rest -> [x;e] :: (cartesian x rest)

let rec product A B = 
    match  A, B with
    | _, [] -> []     // base case. 
    | [], _ -> []      // base case. 
    | e::rest, _ -> (cartesian e B ) @ (product rest B)     // Concatenation is used here.



// returns the set containing all possible subsets:
// 
// Example:  
//   S = [1;2;3]
//   ==> [ []; [1]; [2]; [3]; [1;2]; [1;3]; [2;3]; [1;2;3] ]

// This powerset function doesnt go with the order.
// List.collect merges all the subsets of that set by traversing through recursion.
let rec powerset S = 
    match S with
    | [] -> [[]]         // base case . Power set can't be empty. So it does contain 1 element in list which is empty list.
    | e:: rest ->  List.collect ( fun subset -> [ subset; e::subset]) ( powerset rest  )
    
    
    

