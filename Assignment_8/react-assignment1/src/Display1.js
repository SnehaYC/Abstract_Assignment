import React, { Component } from 'react';

class Display1 extends Component {
  constructor(props) {
    super(props);
    this.state = {
      currentName: props.name,
      currentAddress: props.address
    };
  }

  handleNameChange = (e) => {
    this.setState({ currentName: e.target.value });
  };

  handleAddressChange = (e) => {
    this.setState({ currentAddress: e.target.value });
  };

  render() {
    const { currentName, currentAddress } = this.state;

    return (
      <div>
        <h2>Display Component</h2>
        <form>
          <div>
            <label>
              Name:
              <input type="text" value={currentName}onChange={this.handleNameChange}/>
            </label>
          </div>
          <div>
            <label>
              Address:
              <input type="text" value={currentAddress}onChange={this.handleAddressChange}/>
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
}

export default Display1;
