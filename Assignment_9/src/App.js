
import './App.css';
import FormCC from './Components/FormCC';
import FormFC from './Components/FormFC';
import Login from './Components/Login';
import RefLogin from './Components/RefLogin';

import TitleEveryRender from './Components/TitleEveryRender';
import LoginContext from './context/LoginContext';
import TitleFirstTime from './Components/TitleFirstTime';
import TitleOnChange from './Components/TitleOnChange';

function App() {

  
  return (
    <div className="App">
     <Login/>
     <hr></hr>
<LoginContext /><hr></hr>
<FormCC/> <hr></hr>
<FormFC/><hr></hr>
 <RefLogin/> <hr></hr>
 <TitleFirstTime/><hr></hr>
 <TitleEveryRender/> <hr></hr>
  <TitleOnChange/>
    </div>
  );
}

export default App;
