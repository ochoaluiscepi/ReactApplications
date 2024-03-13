import {useState} from 'react';

export default function Player({name, symbol,isActive,onChangeName}){

    const [isEditing, setIsEditing] = useState(false);

    const [isName, setIsName] = useState(name);
    
    function handleEditClick(){
            setIsEditing((Editing) => !Editing);
            if(isEditing){
              onChangeName(symbol, playerName);
            }
    }

    function handleEditPlayerName(e){
        setIsName(e.target.value);
    }

    let playerName = <span className="player-name">{isName}</span>;

    if(isEditing){
        playerName = <input type="text" onChange={handleEditPlayerName} className="" required value={isName}/>;
    }

    return (
        <li className={isActive ? 'active':''}>
          <span className="player">
             {playerName}
          <span className="player-symbol">{symbol}</span>
            </span>
          <button onClick={handleEditClick}>{isEditing ? "Save":"Edit"}</button>
        </li>

    );
}
