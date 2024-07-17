import logo from './logo.svg';
import './App.css';
import React, { useState } from 'react';

import First from './Function_Comp/First';
import Second from './Function_Comp/Second';
import Third from './Function_Comp/Third';
import Fourth from './Function_Comp/Fourth';
// #----------Imports of Class Components--
import First1 from './Class_Components/First1';
import Second1 from './Class_Components/Second2';
import Third1 from './Class_Components/Third1';
import Fourth1 from './Class_Components/Fourth';

// #-----------Passing data comp to comp
import StudentFunction from './Passing_ApptoStudent/StudentFunction';
import StudentClass from './Passing_ApptoStudent/StudentClass';

// #------------Use of Props
import Display from './Display';
import Display1 from './Display1';

import MessageControl from './Messagehandler';

function App() {
  const studentInfo = {
    name: "Sneha",
    address: "Bulding No 11, ABD, INDIA",
    scores: [35, 35, 35]
  };
  const handleDisplayHello = () => {
    setMessage("Hello");
  };

  const handleDisplayBye = () => {
    setMessage("Bye");
  };

  const [message, setMessage] = useState("");
  return (
    <div className="App">
      <header className="App-header">
        <h6>Hello World</h6>
        <hr></hr>
      </header>
      <First />
      <Second />
      <Third />
      <Fourth />
      <hr></hr>
      <First1 />
      <Second1 />
      <Third1 />
      <Fourth1 />
      <hr></hr>
      <StudentFunction
        name={studentInfo.name}
        address={studentInfo.address}
        scores={studentInfo.scores}
      />
      <hr></hr>
      <StudentClass
        name={studentInfo.name}
        address={studentInfo.address}
        scores={studentInfo.scores}
      />
      <hr></hr>
      <Display
        name={studentInfo.name}
        address={studentInfo.address}


      />
      
      <hr></hr>

      <Display1
        name={studentInfo.name}
        address={studentInfo.address}
      />

<hr></hr>
      <MessageControl
        onDisplayHello={handleDisplayHello}
        onDisplayBye={handleDisplayBye}
      />
      <h2>{message}</h2>



    </div>
  );
}

export default App;
