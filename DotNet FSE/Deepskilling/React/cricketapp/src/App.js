import './App.css';
import ListofPlayers from './ListofPlayers';
import IndianTeam, {
  OddPlayers,
  EvenPlayers,
  IndianPlayers,
  ListofIndianPlayers
} from './IndianPlayers';

function App() {

  // Change this to false to see the second output
  const flag = true;

  if (flag) {

    return (
      <div>

        <h1>List of Players</h1>

        <ListofPlayers />

      </div>
    );

  } else {

    return (

      <div>

        <h1>Indian Team</h1>

        <h2>Odd Players</h2>
        <OddPlayers>{IndianTeam}</OddPlayers>

        <hr />

        <h2>Even Players</h2>
        <EvenPlayers>{IndianTeam}</EvenPlayers>

        <hr />

        <h2>List of Indian Players Merged</h2>

        <ListofIndianPlayers IndianPlayers={IndianPlayers} />

      </div>

    );

  }

}

export default App;