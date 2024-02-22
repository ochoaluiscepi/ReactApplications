
import {CORE_CONCEPTS, EXAMPLES} from './data.js'
import Header from './components/Header/Header.jsx'
import CoreConcepts from './components/CoreConcepts.jsx'
import TabButton from './components/TabButton.jsx'
import {useState} from 'react';


function App() {

  const [valueDynamic, setValueDynamic] = useState('');

  let message = <p>Please select a topic</p>;

  if(valueDynamic){
    message = <div id="tab-content">
    <h3>{EXAMPLES[valueDynamic].title}</h3>
    <p>{EXAMPLES[valueDynamic].description}</p>
    <pre>
      <code>
      {EXAMPLES[valueDynamic].code}
      </code>
    </pre>
    </div>
  }

  function handleClick(selectedButton){
    setValueDynamic(selectedButton);
  }

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
        <section id="examples">
          <h2>Example</h2>
          <menu>
            <TabButton isSelected={valueDynamic == "components"} onSelect={() => handleClick('components')}>Components</TabButton>
            <TabButton isSelected={valueDynamic == "jsx"} onSelect={() => handleClick('jsx')}>JSX</TabButton>
            <TabButton isSelected={valueDynamic == "props"} onSelect={() => handleClick('props')}>Props</TabButton>
            <TabButton isSelected={valueDynamic == "state"} onSelect={() => handleClick('state')}>State</TabButton>
          </menu>
          
            {message}
           
          
          </section>
      </main>
    </div>
  );
}

export default App;
