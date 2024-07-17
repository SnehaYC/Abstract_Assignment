import React from 'react';

function StudentFunction({ name, address, scores }) {
  return (
    <div>
      <h2>Student Information</h2>
      <p>Name: {name}</p>
      <p>Address: {address}</p>
      <p>Scores: {scores.join(', ')}</p>
    </div>
  );
}

export default StudentFunction;
