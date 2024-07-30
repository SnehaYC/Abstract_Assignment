import { createContext } from 'react';

const DataContext = createContext({
    username: '',
    password: ''
});

export default DataContext;
