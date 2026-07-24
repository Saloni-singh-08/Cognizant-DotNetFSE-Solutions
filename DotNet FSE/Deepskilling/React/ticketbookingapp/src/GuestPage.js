import React from "react";

function GuestPage() {

    return (
        <div>

            <h2>Flight Details</h2>

            <table border="1" cellPadding="10">

                <thead>
                    <tr>
                        <th>Flight</th>
                        <th>Source</th>
                        <th>Destination</th>
                        <th>Time</th>
                    </tr>
                </thead>

                <tbody>

                    <tr>
                        <td>AI101</td>
                        <td>Delhi</td>
                        <td>Mumbai</td>
                        <td>10:00 AM</td>
                    </tr>

                    <tr>
                        <td>AI202</td>
                        <td>Chennai</td>
                        <td>Bangalore</td>
                        <td>2:30 PM</td>
                    </tr>

                </tbody>

            </table>

            <p>Please login to book your tickets.</p>

        </div>
    );
}

export default GuestPage;