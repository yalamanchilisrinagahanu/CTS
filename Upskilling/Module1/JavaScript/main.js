console.log("Welcome to the Community Portal");

window.onload=function(){
alert("Page Fully Loaded");
};

/* Data Types */

const eventName="Music Festival";
const eventDate="2026-07-20";
let seats=50;

console.log(
`${eventName} on ${eventDate} Seats:${seats}`
);

/* Class */

class Event{

constructor(name,category,seats){

this.name=name;
this.category=category;
this.seats=seats;

}

}

Event.prototype.checkAvailability=function(){

return this.seats>0;

};

/* Events Array */

let events=[

new Event("Music Festival","Music",20),

new Event("Workshop on Baking","Workshop",15),

new Event("Dance Show","Music",0)

];

/* Push */

events.push(
new Event("Food Festival","Workshop",25)
);

/* Filter */

let musicEvents=
events.filter(
e=>e.category==="Music"
);

console.log(musicEvents);

/* Map */

let eventTitles=
events.map(
e=>"Event : "+e.name
);

console.log(eventTitles);

/* Display */

const container=
document.querySelector("#eventsContainer");

function renderEvents(list){

container.innerHTML="";

list.forEach(event=>{

if(event.seats<=0)
return;

let card=
document.createElement("div");

card.className="event-card";

card.innerHTML=`

<h3>${event.name}</h3>

<p>Category:
${event.category}</p>

<p>Seats:
${event.seats}</p>

<button onclick="registerUser('${event.name}')">
Register
</button>

`;

container.appendChild(card);

});

}

renderEvents(events);

/* Functions */

function addEvent(name,category,seats){

events.push(
new Event(name,category,seats)
);

}

/* Closure */

function registrationCounter(){

let count=0;

return function(){

count++;

return count;

};

}

const totalRegistrations=
registrationCounter();

function registerUser(name){

try{

let event=
events.find(
e=>e.name===name
);

if(event.seats<=0)
throw "No Seats Available";

event.seats--;

alert(
"Registered Successfully\nTotal Registrations : "

* totalRegistrations()
  );

renderEvents(events);

}catch(error){

alert(error);

}

}

/* Higher Order Function */

function filterEventsByCategory(
category,
callback
){

let filtered=
events.filter(
e=>e.category===category
);

callback(filtered);

}

/* Object Entries */

events.forEach(event=>{

console.log(
Object.entries(event)
);

});

/* Change Event */

document
.getElementById("categoryFilter")
.onchange=function(){

let category=this.value;

if(category==="All"){

renderEvents(events);

}
else{

filterEventsByCategory(
category,
renderEvents
);

}

};

/* Keydown Search */

document
.getElementById("searchBox")
.addEventListener(
"keydown",
function(){

let text=
this.value.toLowerCase();

let filtered=
events.filter(

e=>
e.name
.toLowerCase()
.includes(text)

);

renderEvents(filtered);

}

);

/* Form */

document
.getElementById("registerForm")
.addEventListener(
"submit",
function(event){

event.preventDefault();

let name=
this.elements["name"].value;

let email=
this.elements["email"].value;

let valid=true;

if(name===""){

document
.getElementById("nameError")
.innerHTML="Enter Name";

valid=false;

}
else{

document
.getElementById("nameError")
.innerHTML="";

}

if(email===""){

document
.getElementById("emailError")
.innerHTML="Enter Email";

valid=false;

}
else{

document
.getElementById("emailError")
.innerHTML="";

}

if(valid){

submitRegistration({
name,
email
});

}

}

);

/* Fetch API */

function submitRegistration(data){

document
.getElementById("spinner")
.style.display="block";

setTimeout(()=>{

fetch(
"https://jsonplaceholder.typicode.com/posts",
{

method:"POST",

headers:{
"Content-Type":
"application/json"
},

body:JSON.stringify(data)

}

)

.then(response=>response.json())

.then(result=>{

console.log(result);

document
.getElementById("message")
.innerHTML=
"Registration Successful";

})

.catch(error=>{

console.log(error);

document
.getElementById("message")
.innerHTML=
"Registration Failed";

})

.finally(()=>{

document
.getElementById("spinner")
.style.display="none";

});

},2000);

}

/* Async Await */

async function loadEvents(){

try{

document
.getElementById("spinner")
.style.display="block";

const response=
await fetch(
"https://jsonplaceholder.typicode.com/posts"
);

const data=
await response.json();

console.log(data);

}catch(error){

console.log(error);

}
finally{

document
.getElementById("spinner")
.style.display="none";

}

}

loadEvents();

/* Destructuring */

const [firstEvent]=events;

const {
name,
category
}=firstEvent;

console.log(name,category);

/* Spread */

const clonedEvents=
[...events];

/* jQuery */

$("#registerBtn").click(function(){

$(".event-card").fadeOut(500)
.fadeIn(500);

});

console.log(
"Framework Benefit: React/Vue provide component-based architecture and better state management."
);
