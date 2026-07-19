import './App.css';
import CalculateScore from './Components/CalculateScore';

function App() {
  return (
    <div>
      <CalculateScore
        Name="Saloni Singh"
        School="CV Raman Global University"
        Total={450}
        Goal={5}
      />
    </div>
  );
}

export default App;