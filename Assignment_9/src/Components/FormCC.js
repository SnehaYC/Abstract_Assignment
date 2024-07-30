import { Component } from "react";

import WelcomeCC from "./WelcomeCC";

export default class FormCC extends Component
{
    state={
        name:"",
        address:"",
        pincode:"",
        phoneNo:"",
        submitted: false
    }
        handleChange=(event)=>
            {
           console.log(event.target.name)
           
           this.setState({[event.target.name]:event.target.value})
               
             }
           submitData =(event)=>
           {
               console.log("Form is submited");
              
               event.preventDefault();
               this.setState({ submitted: true })
           }

           
           render()
           {
            if (this.state.submitted) {
                return <WelcomeCC  data={this.state} />;
            }
           
           
            return(
                <>
                <form  onSubmit={this.submitData}> 
                    <h2>Login form using class Component</h2>
                    <div>
                        <label> Enter Name </label>
       <input type="text" name="name" value={this.state.name}
       onChange={this.handleChange}/>
                    </div>
                    <div>
                        <label> Enter Address </label>
       <input type="text" name="address" value={this.state.address}
       onChange={this.handleChange}/>
                    </div>
                    <div>
                        <label> Enter pincode </label>
       <input type="text" name="pincode" value={this.state.pincode}
       onChange={this.handleChange}/>
                    </div>
                    <div>
                        <label> Enter phoneNo </label>
       <input type="text" name="phoneNo" value={this.state.phoneNo}
       onChange={this.handleChange}/>
                    </div>
    <div>
        <button type="submit"> Register </button>
    </div>
                </form>
                </>
            )
    }
}

