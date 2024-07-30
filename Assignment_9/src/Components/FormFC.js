import React, { useState } from 'react';

export default function FormAndWelcome() {
  const [formData, setFormData] = useState({
    name: '',
    address: '',
    pincode: '',
    phoneNo: ''
  });

  const [submitted, setSubmitted] = useState(false);

  const handleChange = (event) => {
    const { name, value } = event.target;
    setFormData({
      ...formData,
      [name]: value
    });
  };

  const submitData = (event) => {
    event.preventDefault();
    setSubmitted(true);
  };

  if (submitted) {
    return (
      <div>
        <h2>Welcome, {formData.name}!</h2>
        <p><strong>Address:</strong> {formData.address}</p>
        <p><strong>Pincode:</strong> {formData.pincode}</p>
        <p><strong>Phone Number:</strong> {formData.phoneNo}</p>
      </div>
    );
  }

  return (
    <form onSubmit={submitData}>
      <h2>Login Form using Function Component</h2>
      <div>
        <label>Enter Name</label>
        <input
          type="text" name="name" value={formData.name}  onChange={handleChange}
        />
      </div>
      <div>
        <label>Enter Address</label>
        <input
          type="text" name="address" value={formData.address} onChange={handleChange}
        />
      </div>
      <div>
        <label>Enter Pincode</label>
        <input
          type="text" name="pincode" value={formData.pincode} onChange={handleChange}
        />
      </div>
      <div>
        <label>Enter Phone Number</label>
        <input type="text" name="phoneNo" value={formData.phoneNo} onChange={handleChange}
        />
      </div>
      <div>
        <button type="submit">Register</button>
      </div>
    </form>
  );
}
