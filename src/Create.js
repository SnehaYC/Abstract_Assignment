import React, { useState } from 'react';
import './Create.css';
import axios from 'axios';
import { Link, useNavigate } from 'react-router-dom';

const Create = () => {
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const navigate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault(); // Prevent default form submission

    axios.post('https://6698fedb2069c438cd70e88e.mockapi.io/EmpData', {
      name: name,
      email: email,
    })
    .then(() => {
      navigate("/read");
    })
    .catch((error) => {
      console.error("There was an error creating the data!", error);
    });
  };

  return (
    <>
      <form className="container" onSubmit={handleSubmit}>
        <div className="mb-2">
          <div className="mb-1">
            <label htmlFor="nameInput" className="form-label">Name</label>
            <input 
              type="text" 
              className="form-control" 
              id="nameInput"
              onChange={(e) => setName(e.target.value)}
            />
          </div>
          <label htmlFor="emailInput" className="form-label">Email address</label>
          <input 
            type="email" 
            className="form-control" 
            id="emailInput" 
            aria-describedby="emailHelp"
            onChange={(e) => setEmail(e.target.value)}
          />
        </div>
        
        <button type="submit" className='btn btn-success'>Submit</button>
        <button className='btn btn-info'>User Info</button>
      </form>
    </>
  );
}

export default Create;
