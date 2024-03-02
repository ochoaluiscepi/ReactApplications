import {useState} from 'react';

const initialGameBoard = [
    [null,null,null],
    [null,null,null],
    [null,null,null]
];


export default function GameBoard({onSelectSquare,turns}){

    let gameBoard = initialGameBoard;

    for(const turn of turns){
        const {square,player} = turn;
        const {row,col} = square; 

        gameBoard[row][col] = player;
    }

    return (
        <ol id="game-board">
            {gameBoard.map((row, index)=> <li key={index}>
            <ol>
                {row.map((col, colIndex)=>
                <li key={colIndex}>
                    <button onClick ={() => onSelectSquare(index,colIndex)}>{col}</button>
                </li>)}
            </ol>
             </li>)}
           
        </ol>

    );
}