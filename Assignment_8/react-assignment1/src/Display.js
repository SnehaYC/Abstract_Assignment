import React, { useState } from 'react';

function Display({ name, address }) {
    const [currentName, setCurrentName] = useState(name);
    const [currentAddress, setCurrentAddress] = useState(address);

    const handleNameChange = (e) => {
        setCurrentName(e.target.value);
    };

    const handleAddressChange = (e) => {
        setCurrentAddress(e.target.value);
    };

    return (
        <div>
            <h2>Display Component Using useState</h2>
            <form>
                <div>
                    <label>Name:<input type="text" value={currentName} onChange={handleNameChange} />
                    </label>
                </div>
                <div>
                    <label>Address:<input type="text"value={currentAddress}onChange={handleAddressChange}/>
                    </label>
                </div>
            </form>
            <div>
                <h3>Updated Information</h3>
                <p>Name: {currentName}</p>
                <p>Address: {currentAddress}</p>
            </div>
        </div>
    );
}

export default Display;
