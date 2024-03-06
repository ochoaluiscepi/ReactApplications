import {useState} from 'react';
import Player from './components/Player.jsx';
import GameBoard from './components/GameBoard.jsx';
import Log from './components/Log.jsx';

function deriveActivePlayer(gameTurns){
  
  let currentPlayer = 'X';

  if(gameTurns.length > 0 &&  gameTurns[0].player ==='X'){
    currentPlayer = 'O';
  }
  return currentPlayer;
}

function App() {
  //const [activePlayer,setActivePlayer] = useState('X');
  const[gameTurns,setGameTurns] = useState([]);

  const activePlayer = deriveActivePlayer(gameTurns);

  function handleSelectedSquare(rowIndex,colIndex){
    //setActivePlayer((active)=> active === 'X' ? 'O':'X' );
    setGameTurns(prevTurn => {

    const currentPlayer = deriveActivePlayer(prevTurn);
        
        const updatedTurns = [{square:{row:rowIndex,col:colIndex}, player:currentPlayer},
          ...prevTurn];

          return updatedTurns;
    });
  }

  return (
  <main>
    <div id="game-container">
      <ol id="players" className='highlight-player'>
        <Player name ="Player 1" symbol="X" isActive={activePlayer === 'X'} />
        <Player name ="Player 2" symbol="O" isActive={activePlayer === 'O'}/>
      </ol>
      <GameBoard onSelectSquare={handleSelectedSquare} turns={gameTurns}></GameBoard>
    </div>
    <Log turns={gameTurns}></Log>
  </main>
  );
}

export default App
