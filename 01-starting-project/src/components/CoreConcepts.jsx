function CoreConcepts(props){
    return (
      <li>
        <img src={props.image} alt="Stylized atom" />
        <h3>{props.title}</h3>
        <p>{props.description}</p>
      </li>
    );
  }


  export default CoreConcepts;