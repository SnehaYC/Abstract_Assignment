import React from 'react';

function MessageControl({ onDisplayHello, onDisplayBye }) {
  return (
    <div>
      <button onClick={onDisplayHello}>Display Hello</button>
      <button onClick={onDisplayBye}>Display Bye</button>
    </div>
  );
}

export default MessageControl;
