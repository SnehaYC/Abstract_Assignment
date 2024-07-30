    import axios from 'axios';
    import React, { useEffect, useState } from 'react';
    import { Link, useNavigate } from 'react-router-dom';

    function Update() {
        const [id, setId] = useState("");
        const [name, setName] = useState("");
        const [email, setEmail] = useState("");
        const navigate = useNavigate();

        useEffect(() => {
            setId(localStorage.getItem("id"));
            setName(localStorage.getItem("name"));
            setEmail(localStorage.getItem("email"));
        }, []);

        const handleUpdate = (e) => {
            e.preventDefault();
            axios.put(`https://6698fedb2069c438cd70e88e.mockapi.io/EmpData/${id}`, {
                name: name,
                email: email,
            })
            .then(() => {
                navigate("/read"); // Redirect to /read after successful submission
            })
            .catch(error => {
                console.error("There was an error updating the data!", error);
            });
        }

        return (
            <>
                
                <form className="container" onSubmit={handleUpdate}>
                <h2 className='my-title'>Update</h2>
                    <div className="mb-2">
                        <div className="mb-1">
                            <label htmlFor="nameInput" className="form-label">Name</label>
                            <input 
                                type="text" 
                                className="form-control" 
                                id="nameInput"
                                value={name}
                                onChange={(e) => setName(e.target.value)}
                            />
                        </div>
                        <div className="mb-1">
                            <label htmlFor="emailInput" className="form-label">Email address</label>
                            <input 
                                type="email" 
                                className="form-control" 
                                id="emailInput" 
                                value={email}
                                aria-describedby="emailHelp"
                                onChange={(e) => setEmail(e.target.value)}
                            />
                        </div>
                    </div>
                    <button type="submit" className="btn btn-primary mx-2">Update</button>
                    <Link to="/read">
                    <button className='btn btn-success mx-2'>Back</button>
                    </Link>
                </form>
            </>
        );
    }

    export default Update;
