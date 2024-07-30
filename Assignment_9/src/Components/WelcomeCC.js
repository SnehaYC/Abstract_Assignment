import React, { Component } from "react";

export default class WelcomeCC extends Component {
    render() {
        const { name, address, pincode, phoneNo } = this.props.data;

        return (
            <div>
                <h2>Welcome, {name}!</h2>
                <p>Address: {address}</p>
                <p>Pincode: {pincode}</p>
                <p>Phone Number: {phoneNo}</p>
            </div>
        );
    }
}
