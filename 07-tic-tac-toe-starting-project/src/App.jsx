import {useState} from 'react';
import Player from './components/Player.jsx';
import GameBoard from './components/GameBoard.jsx';
import Log from './components/Log.jsx';

function App() {
  const [activePlayer,setActivePlayer] = useState('X');
  const[gameTurns,setGameTurns] = useState([]);

  function handleSelectedSquare(rowIndex,colIndex){
    setActivePlayer((active)=> active === 'X' ? 'O':'X' );
    setGameTurns(prevTurn => {

        let currentPlayer = 'X';
        if(prevTurn.length > 0 &&  prevTurn[0].player ==='X'){
          currentPlayer = 'O';
        }

        const updatedTurns = [{square:{row:rowIndex,col:colIndex}, player:activePlayer},
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
    <Log></Log>
  </main>
  );
}

export default App
