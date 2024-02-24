export default function TabButton(props){

    return (
        <li><button key={props.onSelect} className={props.isSelected ? "active":""} onClick={props.onSelect}>{props.children}</button></li>
        );
}