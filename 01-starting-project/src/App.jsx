import reactImg from './assets/react-core-concepts.png'
import {CORE_CONCEPTS} from './data.js'

const reactDescriptions = ['Fundamental', 'Crucial', 'Core'];

function genRandomInt(max) {
  return Math.floor(Math.random() * (max + 1));
}


function Header(){
  const description = reactDescriptions[genRandomInt(2)];
  return (
    <header>
        <img src={reactImg} alt="Stylized atom" />
        <h1>React Essentials</h1>
        <p>
          {description} React concepts you will need for almost any app you are
          going to build!
        </p>
      </header>
  );
}

function CoreConcepts(props){
  return (
    <li>
      <img src={props.image} alt="Stylized atom" />
      <h3>{props.title}</h3>
      <p>{props.description}</p>
    </li>
  );
}

function App() {
  return (
    <div>
      <Header/>

      <main>
        <section id="core-concepts">
          <h2>Concepts</h2>
          <ul>
            {/* Manually add: <CoreConcepts {...CORE_CONCEPTS[0]} /> */}
            
            {CORE_CONCEPTS.map((concept) => <CoreConcepts title={concept.title} description={concept.description} image={concept.image} />)}
            
          </ul>
        </section>
        <h2>Time to get started!</h2>
      </main>
    </div>
  );
}

export default App;
