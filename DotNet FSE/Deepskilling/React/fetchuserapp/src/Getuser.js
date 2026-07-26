import React, { Component } from "react";

class Getuser extends Component {

    constructor(props) {
        super(props);

        this.state = {
            person: null,
            loading: true
        };
    }

    async componentDidMount() {

        try {

            const url = "https://api.randomuser.me/";
            const response = await fetch(url);
            const data = await response.json();

            this.setState({
                person: data.results[0],
                loading: false
            });

        } catch (error) {
            console.log(error);
        }

    }

    render() {

        if (this.state.loading) {
            return <h2>Loading...</h2>;
        }

        const { title, first } = this.state.person.name;
        const image = this.state.person.picture.large;

        return (

            <div
                style={{
                    textAlign: "center",
                    marginTop: "40px"
                }}
            >

                <h1>
                    {title} {first}
                </h1>

                <img
                    src={image}
                    alt="User"
                    width="200"
                    height="200"
                />

            </div>

        );

    }

}

export default Getuser;