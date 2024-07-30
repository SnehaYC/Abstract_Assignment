import React, { useState, useEffect } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import axios from 'axios';
import './Read.css'; 
import { Link } from 'react-router-dom';

const Read = () => {
  const [data, setData] = useState([]);
  

  const getData = () => {
    axios.get('https://6698fedb2069c438cd70e88e.mockapi.io/EmpData')
      .then((res) => {
        console.log(res.data);
        setData(res.data);
      })
      .catch((error) => {
        console.error("There was an error fetching the data!", error);
      });
  };

  useEffect(() => {
    getData();
  }, []);

  const setLocalStorage = (id, name, email) => {
    localStorage.setItem("id", id);
    localStorage.setItem("name", name);
    localStorage.setItem("email", email);
  };

  const deleteData = (id) => {
    axios.delete(`https://6698fedb2069c438cd70e88e.mockapi.io/EmpData/${id}`)
      .then(() => {
        getData();
      })
      .catch((error) => {
        console.error("There was an error deleting the data!", error);
      });
  };

  

  return (
    <>
      <div className="table-container">
        
        <div className='d-flex justify-content-between align-items-center my-container'>
          <h2 className='my-title'>Updated Data</h2>
          <Link to="/">
            <button className='btn btn-secondary my-button'>Add Info</button>
          </Link>
        </div>
        <table className='table align-middle mb-0'>
          <thead>
            <tr>
              <th>id</th>
              <th>Name</th>
              <th>Email</th>
              <th>Actions</th>
            </tr>
          </thead>
          <tbody>
            {data.map((item) => (
              <tr key={item.id}>
                <td>{item.id}</td>
                <td>{item.name}</td>
                <td>{item.email}</td>
                <td>
                  <Link to="/update">
                    <button 
                      type="button" 
                      className="btn btn-link btn-sm btn-rounded" 
                      aria-label="Edit"
                      onClick={() => setLocalStorage(item.id, item.name, item.email)}
                    >
                      Edit
                    </button>
                  </Link>
                  <button
                    type="button"
                    className="btn btn-link btn-sm btn-rounded"
                    aria-label="Delete"
                    onClick={() => deleteData(item.id)}
                  >
                    Delete
                  </button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </>
  );
}

export default Read;
