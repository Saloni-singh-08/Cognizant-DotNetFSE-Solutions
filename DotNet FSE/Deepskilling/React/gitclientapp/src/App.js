import React, { Component } from "react";
import "./App.css";
import GitClient from "./GitClient";

class App extends Component {

    constructor(props) {
        super(props);

        this.state = {
            repositories: []
        };
    }

    async componentDidMount() {

        try {

            const repos = await GitClient.getRepositories("techiesyed");

            this.setState({
                repositories: repos
            });

        } catch (error) {
            console.log(error);
        }

    }

    render() {

        return (

            <div style={{ margin: "30px" }}>

                <h1>GitHub Repositories</h1>

                <ul>

                    {this.state.repositories.map(repo => (

                        <li key={repo.id}>
                            {repo.name}
                        </li>

                    ))}

                </ul>

            </div>

        );

    }

}

export default App;