import {useState} from 'react';
import Player from './components/Player.jsx';
import GameBoard from './components/GameBoard.jsx';
import Log from './components/Log.jsx';
import GameOver from './components/GameOver.jsx';



const WINNING_COMBINATIONS = [
  [
    { row: 0, column: 0 },
    { row: 0, column: 1 },
    { row: 0, column: 2 },
  ],
  [
    { row: 1, column: 0 },
    { row: 1, column: 1 },
    { row: 1, column: 2 },
  ],
  [
    { row: 2, column: 0 },
    { row: 2, column: 1 },
    { row: 2, column: 2 },
  ],
  [
    { row: 0, column: 0 },
    { row: 1, column: 0 },
    { row: 2, column: 0 },
  ],
  [
    { row: 0, column: 1 },
    { row: 1, column: 1 },
    { row: 2, column: 1 },
  ],
  [
    { row: 0, column: 2 },
    { row: 1, column: 2 },
    { row: 2, column: 2 },
  ],
  [
    { row: 0, column: 0 },
    { row: 1, column: 1 },
    { row: 2, column: 2 },
  ],
  [
    { row: 0, column: 2 },
    { row: 1, column: 1 },
    { row: 2, column: 0 },
  ],
];

function deriveActivePlayer(gameTurns){
  
  let currentPlayer = 'X';

  if(gameTurns.length > 0 &&  gameTurns[0].player ==='X'){
    currentPlayer = 'O';
  }
  return currentPlayer;
}

const initialGameBoard = [
  [null,null,null],
  [null,null,null],
  [null,null,null]
];

function App() {
  const [players,setPlayers] = useState({
    X:'Player 1', 
    O:'Player 2'
  });
  //const [activePlayer,setActivePlayer] = useState('X');
  const[gameTurns,setGameTurns] = useState([]);

  const activePlayer = deriveActivePlayer(gameTurns);

  let gameBoard = [...initialGameBoard.map(array=>[...array])];

    for(const turn of gameTurns){
        const {square,player} = turn;
        const {row,col} = square; 

        gameBoard[row][col] = player;
    }
    let winner
  for(const combination of WINNING_COMBINATIONS){
    const firstSquare = gameBoard[combination[0].row][combination[0].column];
    const secondSquare = gameBoard[combination[1].row][combination[1].column];
    const thirdSquare = gameBoard[combination[2].row][combination[2].column];

    if(firstSquare && firstSquare === secondSquare && firstSquare === thirdSquare){
        winner = players[firstSquare];
    }


  }

  const hasDraw = gameTurns.length == 9 && !winner;

  function handleSelectedSquare(rowIndex,colIndex){
    //setActivePlayer((active)=> active === 'X' ? 'O':'X' );
    setGameTurns(prevTurn => {

    const currentPlayer = deriveActivePlayer(prevTurn);
        
        const updatedTurns = [{square:{row:rowIndex,col:colIndex}, player:currentPlayer},
          ...prevTurn];

          return updatedTurns;
    });
  }

  function handleRestart(){
    setGameTurns([]);
  }

  function handlePlayerNameChange(symbol,newName){
    setPlayers((prevPlayers) => {
      return {
        ...prevPlayers,
        [symbol]:newName
      };
    });
  }

  return (
  <main>
    <div id="game-container">
      <ol id="players" className='highlight-player'>
        <Player name ="Player 1" symbol="X" isActive={activePlayer === 'X'} onChangeName={handlePlayerNameChange} />
        <Player name ="Player 2" symbol="O" isActive={activePlayer === 'O'} onChangeName={handlePlayerNameChange}/>
      </ol>
      {(winner || hasDraw) && <GameOver winner= {winner} onRestart={handleRestart}></GameOver>}
      <GameBoard board={gameBoard} onSelectSquare={handleSelectedSquare} ></GameBoard>
    </div>
    <Log turns={gameTurns}></Log>
  </main>
  );
}

export default App
