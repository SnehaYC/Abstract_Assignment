import React, { useState } from 'react';
import Welcome from './Welcome';

function Login() {
  const [user, setUser] = useState({
    username: '',
    email: '',
    age: ''
  });
  const [loggedIn, setLoggedIn] = useState(false);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setUser(prevDetails => ({
      ...prevDetails,
      [name]: value
    }));
  };


  const handleSubmit = (e) => {
    e.preventDefault();
    setLoggedIn(true);
  };

  if (loggedIn) {
    return <Welcome username={user.username} />;
  }

  return (
    <div>
      <h2>Login form using props</h2>
      <form onSubmit={handleSubmit}>
        <label>Username:
          <input type="text"   name="username"value={user.username} onChange={handleChange}  />
        </label><br></br>
        <label>Email:
          <input type="text"   name="email" value={user.email} onChange={handleChange}  />
        </label><br/>
        <label>Age:
          <input type="text"    name="age" value={user.age} onChange={handleChange}  />
        </label><br></br>
        <button type="submit">Login</button>
      </form>
    </div>
  );
}

export default Login;
