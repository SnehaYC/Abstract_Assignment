
import React, { useRef, useState } from 'react';
import Welcome from './RefWelcome';

const RefLogin = () => {
  const usernameRef = useRef('');
  const emailRef = useRef('');
  const passwordRef = useRef('');

  const [userDetails, setUserDetails] = useState(null);

  const handleSubmit = (e) => {
    e.preventDefault();
    const details = {
      username: usernameRef.current.value,
      email: emailRef.current.value,
      password: passwordRef.current.value,
    };
    setUserDetails(details);
  };

  return (
    <div>
      <h2>Login Component using Ref</h2>
      {userDetails === null ? (
        <form onSubmit={handleSubmit}>
          <div>
            <label>Username:</label>
            <input type="text" ref={usernameRef} />
          </div>
          <div>
            <label>EmailID:</label>
            <input type="email" ref={emailRef} />
          </div>
          <div>
            <label>Password:</label>
            <input type="password" ref={passwordRef} />
          </div>
          <button type="submit">Login</button>
        </form>
      ) : (
        <Welcome userDetails={userDetails}/>
      )}
    </div>
  );
}

export default RefLogin;


