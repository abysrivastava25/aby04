import {circle,rectangle,cylinder} from "./Areas.js"
import {uniqueArray} from "./UniqueFilter.js"
  
//Q1: using arrow function to filter out the numbers which are greater than 70.

const orig_Array=[3,62,234,7,23,74,23,76,92];
let new_Array=orig_Array.filter(orig_Array=>orig_Array>70);
console.log("The new Array is = \n",new_Array);
// the result you can see on the console.
/*-------------------------------------------------------------------------------------------------------
*/

//Q2 
//a.  Select all the list items on the page and convert to array.

const items = Array.from(document.getElementById("text").getElementsByTagName('li'));
const result=[];
for(var element of items)
{
    result.push(element.textContent);
 }
   console.log("Q2a resultant array =\n",result);
/*--------------------------------------------------------------------------------------------------------
*/


//2b.  Filter for only the elements that contain the word 'flexbox'
const filtered = items.filter(item => item.textContent.includes('Flexbox'));
const res=[]; 

for(var element of filtered)
{
    res.push(element.textContent);
}
console.log("Q2b result =\n",res);

/* --------------------------------------------------------------------------------------------------------
*/

//Q2c  Map down to a list of time strings
const mapres= items.map(item => item.dataset.time);
console.log("Q2c result is=\n")
for(var element of mapres)
{
    console.log(element);
}
/*--------------------------------------------------------------------------------------------------------
*/

//Q2d Map to an array of seconds

const seconds=mapres.map(time => {
    const parts = time.split(':').map(part => parseFloat(part));
    return (parts[0] * 60) + parts[1];
  });
  console.log("Q2d result is=\n");
  for(var element of seconds)
  {
      console.log(element);
  }

  /*------------------------------------------------------------------------------------------------------
  */

  // Q2e Reduce to get total using .filter and .map

  let Totaltym=seconds.reduce((runningTotal, second) => runningTotal + second);
  console.log("Q2e result = \n",Totaltym);

  /*------------------------------------------------------------------------------------------------------
   */

   //Q3  Create a markup template using string literal

// const song = {
//     name: 'Dying to live',
//     artist: 'Tupac',
//     featuring: 'Biggie Smalls'
//    };
   
    
   
//    Result:
//    "<div class="song">
//       <p>
//         Dying to live — Tupac
//         (Featuring Biggie Smalls)
//       </p>
//     </div>

        const song = {
        name: 'Dying to live',
        artist: 'Tupac',
        featuring: 'Biggie Smalls'
       };

       const temp= `<div class="song">
                    <p>
                        ${song.name} - ${song.artist}
                        (Featuring ${song.featuring})
                    </p>
                </div>`
            console.log("Q3 result =\n",temp);
/*-----------------------------------------------------------------------------------------------
*/                   

//Q4. Extract all keys inside address object from user object using destructuring ?
/*
const user = {
    firstName: ‘Sahil’,
    lastName: ‘Dua’,
    Address: {
    Line1: ‘address line 1’,
    Line2: ‘address line 2’,
    State: ‘Delhi’,
    Pin: 110085,
    Country: ‘India’,
    City: ‘New Delhi’,
    },
    phoneNo: 9999999999
    }
*/
const user = {
    firstName: "Sahil",
    lastName: "Dua",
    Address: {
        Line1: "address line 1",
        Line2: "address line 2",
        State: "Delhi",
        Pin: 110085,
        Country: "India",
        City: "New Delhi",
        },
    phoneNo: 9999999999
 }
let{Line1,Line2,State,Pin,Country,City}=user.Address;
 console.log("Q4a result =\n",Line1,Line2,State,Pin,Country,City);

 /*-----------------------------------------------------------------------------------------------
  */
// Q4b  Filter unique array members using Set.
 let array=[62,52,21,52,62,1,7,7];
 let arr_set=new Set(array);
 console.log("Q4 result =\n",arr_set);

 /*-----------------------------------------------------------------------------------------------
 */

 //Q5 Find the possible combinations of a string and store them in a MAP? 

 var words = ["a", "b", "h","i"];
var ways = [];
var i= "";
var res_map=new Map();
var word_length = Math.pow(2, words.length);

for (var x = 0; x < word_length ; x++){
    i= "";
    for (var j=0;j<words.length;j++) {
        if ((x & Math.pow(2,j))){ 
            i += words[j]
        }
    }
    if (i !== "") {
        ways.push(i);
    }
    res_map.set(i);   
}
console.log("Q5 result is =\n",res_map);

/*------------------------------------------------------------------------------------------------

*/

//Q6 Write a program to implement inheritance upto 3 classes.The Class must  public variables and static functions.
 
console.log("Q6 Begins Here \n")
class Car{
    Details(){
        console.log("this is a general car class\n");
    }
}

class SuperCar extends Car{

    static model(){
        console.log("this is a future concept model\n");
    }
    Details(){
        console.log("this is supercar class\n");
    }
}

class SportsCar extends Car
{
    Details()
    {
        console.log("this is a Sports car class\n");
    }
}

let object=new SportsCar();
object.Details();
SuperCar.model(); //this is static method call

/*----------------------------------------------------------------------------------------------------
*/

//Q7  Write a program to implement a class having static functions
console.log("Q7 begins here \n");
class static_method
{
   static Demo(){
        console.log("This is a static method \n");
    }
}
static_method.Demo();

/*-----------------------------------------------------------------------------------------------------
*/

//Q8 Import a module containing the constants and method for calculating area of circle, rectangle, cylinder.

console.log("Q8 Begins here \n \n ");
console.log("area of circle=\n",circle(10));
console.log("area of reactanle=\n",rectangle(3,6));
console.log("area of cylinder= \n",cylinder(6,4));

/*-----------------------------------------------------------------------------------------------------
*/

//Q9  Import a module for filtering unique elements in an array.
 
console.log("Q9 begins here\n");
console.log("Unique Array \n",uniqueArray);

/*-----------------------------------------------------------------------------------------------------
 */

 //Q10 Write a program to flatten a nested array to single level using arrow functions.

 var nestedArray = [[7,8, 4],[9, 3, 6], [8, 2, 1, 5]];
let flatten=()=>{
    var SeperatedArray = []; 
for (var x = 0; x < nestedArray.length; x++) {
  for (var y = 0; y < nestedArray[x].length; y++)
    SeperatedArray.push(nestedArray[x][y]);
}
return SeperatedArray;
}
console.log("Q 10 result is =\n",flatten());

/*-----------------------------------------------------------------------------------------------------
*/

//Q11  Implement a singly linked list in es6 and implement addFirst() addLast(), length(), getFirst(), getLast(). (without using array)

class LinkedList {
    constructor() {
      this.head = null;
      this.tail = null;
      this.count = 0;
    }
    
    get length() {
      return this.count;
    }
    
    addLast(data) {
      
      const node = {
        data: data,
        next: null
      }
      
      if(this.count === 0) {
      
        this.head = node;
      } else {
      
        this.tail.next = node;
      }
      
      this.tail = node;
      
      this.count++;
    }
    
    addFirst(data) {
      
      const node = {
        data: data,
        next: null
      }
      
      
      const temp = this.head;
      
      
      this.head = node;
      
      
      this.head.next = temp;
      
      this.count++;
      
      if(this.count === 1) {
      
        this.tail = this.head;
      }
    }            
     removeFirst() {
        if(this.count > 0) {
            
            this.head = this.head.next;
            
            this.count--;  
            
            if(this.count === 0) {
              
              this.tail = null;  
            } 
          }
     }  

  
  
  getFirst()
  {
    let getFirstNode=this.head;
    if(!this.head){
       console.log("Linked list is empty");
    }
    else{
       console.log("The first element of linked list is     " +getFirstNode.data);
        
    }
  }

  getLast()
  {
    let getLastNode=this.tail;
    if(!this.head){
       console.log("Linked list is empty");
    }
    else{
       console.log("The first element of linked list is     " +getLastNode.data);
        
    } 
  }
  listLength()
  {
    let counter = 0;
    let node = this.head;
    if(!this.head){
        console.log("Linked list is empty");
    }
    else{
        while(node.next!=null){
            counter++;
            node=node.next;
            
        }
        counter+=1;
        console.log("The length of list is    "+counter);
    }
  }

  printList(){
    let curr = this.head;
    let out = [];
    while(curr !== null){
        if(curr.next === null){
            out.push(curr.data);
        }else{
            out.push(curr.data);
            out.push("->")
        }
        curr = curr.next;
    }
    return out.join("");
}

}


console.log("Q 11 result is \n");
  var linkedList = new LinkedList();
  linkedList.addLast(2);
  linkedList.addLast(19);
  linkedList.addFirst(1);         
  linkedList.addFirst(100);
  linkedList.addLast(4);
  linkedList.addFirst(45);
  linkedList.getFirst();
  linkedList.getLast();
  linkedList.listLength();           
  console.log(linkedList.printList());

/*--------------------------------------------------------------------------------------------
*/

//Q12 Implement Map and Set using Es6
 console.log("Q12 Implementing map and set \n")
let mapArray=[2,3,4,5,6];
let multiply=mapArray.map((n)=>n*n);
console.log("Map Result =\n",multiply);
console.log("Set result =\n");
let proglang=new Set();
proglang.add('C#');
proglang.add('C++');
proglang.add('python');
proglang.add('java');
for(var element of proglang.values())
{
    console.log(element);
}
/*---------------------------------------------------------------------------------------------------------------*/
 
//Q13  Implementation of stack (using linked list)

console.log("Implementing stack");
class Stack{
    constructor(){
        this.list=new LinkedList();
    }
    push(item){
        this.list.addFirst(item);
    }
    pop(){
        if(!this.list.listLength){
            return;
        };
        let val =this.list.head.data;
        this.list.removeFirst();
        return val;
    }
    peek(){
        if(!this.list.head){return ;}
        return this.list.head.data;
    }
    length(){
        return this.list.listLength();
    }
}
let stack =new Stack();
stack.push(3);
stack.push(7);
stack.push(6);
stack.push(8);  
console.log(`pop operation:${stack.pop()}`);
console.log(`peek Operation:${stack.peek()}`);
console.log(stack.length());