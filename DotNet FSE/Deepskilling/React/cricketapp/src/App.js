import './App.css';
import office from './Images/office.jpg';

function App() {

  const officeSpaces = [

    {
      Name: "DBS",
      Rent: 50000,
      Address: "Chennai"
    },

    {
      Name: "Regus",
      Rent: 75000,
      Address: "Bangalore"
    },

    {
      Name: "WeWork",
      Rent: 65000,
      Address: "Hyderabad"
    },

    {
      Name: "SmartWorks",
      Rent: 55000,
      Address: "Pune"
    }

  ];

  return (

    <div style={{ padding: "20px" }}>

      <h1>Office Space, at Affordable Range</h1>

      {officeSpaces.map((officeItem, index) => (

        <div key={index} style={{ marginBottom: "30px" }}>

          <img
            src={office}
            alt="Office Space"
            width="250"
            height="200"
          />

          <h2>Name: {officeItem.Name}</h2>

          <h3
            style={{
              color:
                officeItem.Rent <= 60000
                  ? "red"
                  : "green"
            }}
          >
            Rent Rs. {officeItem.Rent}
          </h3>

          <h3>Address: {officeItem.Address}</h3>

        </div>

      ))}

    </div>

  );

}

export default App;