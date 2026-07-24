import React, { Component } from "react";
import "./App.css";

import Greeting from "./Greeting";
import LoginButton from "./LoginButton";
import LogoutButton from "./LogoutButton";

class App extends Component {

    constructor(props) {
        super(props);

        this.state = {
            isLoggedIn: false
        };
    }

    handleLogin = () => {
        this.setState({
            isLoggedIn: true
        });
    };

    handleLogout = () => {
        this.setState({
            isLoggedIn: false
        });
    };

    render() {

        const isLoggedIn = this.state.isLoggedIn;

        let button;

        if (isLoggedIn) {
            button = <LogoutButton onClick={this.handleLogout} />;
        } else {
            button = <LoginButton onClick={this.handleLogin} />;
        }

        return (

            <div style={{ margin: "40px" }}>

                <Greeting isLoggedIn={isLoggedIn} />

                <br />

                {button}

            </div>

        );

    }

}

export default App;