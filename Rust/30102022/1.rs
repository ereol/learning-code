let x;   //declare 'x'
x = 42;  //assign 42 to "x"

let x = 42;  //or be written as a single line/

let x: i32;
x = 42;

let x: i32 = 42;

//can't access uninitialised variables ie
// let x;
// foobar (x);
//   borrow of possibly-uninitialised 'x'
// x = 42;

//doing this is fine 
let x;
x = 42; 
foobar(x);

//the underscore is a lack of name, meaning to throw away something and not warn about not being used.
//does nothing as 42 is a const
//let _=42;
//calls get_thing but throws away its result
//let _ = get_thing();

//tuples
let pair = ('a', 17);
pair.0; //this is 'a'
pair.1; //this is 17
//with explicit type annotation
let pair: (char, i32) = ('a' , 17);
