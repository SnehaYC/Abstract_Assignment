import React, { useContext } from 'react';
import DataContext from './DataContext.js';

export const Welcome = () => {
    const { username } = useContext(DataContext);
    
    return (
     
        <div>
            <h2>Welcome,{username}</h2>
        </div>
    );
};
