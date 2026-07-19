import React from 'react';
import '../Stylesheets/mystyle.css';

function CalculateScore(props) {
    const average = props.Total / props.Goal;

    return (
        <div className="box">
            <h2>Student Details</h2>

            <p><strong>Name:</strong> {props.Name}</p>
            <p><strong>School:</strong> {props.School}</p>
            <p><strong>Total Score:</strong> {props.Total}</p>
            <p><strong>Goal:</strong> {props.Goal}</p>

            <h3>Average Score: {average}</h3>
        </div>
    );
}

export default CalculateScore;