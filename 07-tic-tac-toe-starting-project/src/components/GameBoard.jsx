import {useState} from 'react';




export default function GameBoard({onSelectSquare, board}){

    

    return (
        <ol id="game-board">
            {board.map((row, index)=> <li key={index}>
            <ol>
                {row.map((playerSymbol, colIndex)=>
                <li key={colIndex}>
                    <button onClick ={() => onSelectSquare(index,colIndex)} disabled={playerSymbol !== null}>{playerSymbol}</button>
                </li>)}
            </ol>
             </li>)}
           
        </ol>

    );
}