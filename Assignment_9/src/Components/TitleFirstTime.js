import React, { useState } from 'react';

const TitleFirstTime = () => {
  const [pageTitle, setPageTitle] = useState('');
  const [variableD, setVariableD] = useState('');
  const [titleUpdated, setTitleUpdated] = useState(false);

  const handleUpdateTitleFirstTime = () => {
    if (!titleUpdated && variableD.trim() !== '') {
      document.title = variableD;
      setPageTitle(variableD);
      setTitleUpdated(true);

    }
  };

  const handleChangeVariableD = (e) => {
    setVariableD(e.target.value);
   
  };

  return (
    <div className="App">
    <h4>Update Title Only First Time</h4>
      <input type="text" value={variableD} onChange={handleChangeVariableD} />
      <button onClick={handleUpdateTitleFirstTime}>Update</button>
    </div>
  );
};

export default TitleFirstTime;



















// import React, { useState, useEffect } from 'react';

// const TitleEveryRender = () => {
//   const [D, setD] = useState('Initial Title');
//   const [titleSet, setTitleSet] = useState(false);

//   useEffect(() => {
//     if (!titleSet) {
//       document.title = D;
//       setTitleSet(true);
//     }
//   }, []); // Empty dependency array ensures this effect runs only once, on mount

//   const handleChange = (event) => {
//     setD(event.target.value);
//   };

//   return (
//     <div>
//       <h4>Update Title Only First Time</h4>
//       <input type="text" value={D} onChange={handleChange} />
//     </div>
//   );
// };

// export default TitleEveryRender;

