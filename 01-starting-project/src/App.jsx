
import {CORE_CONCEPTS, EXAMPLES} from './data.js'
import Header from './components/Header/Header.jsx'
import CoreConcepts from './components/CoreConcepts.jsx'
import TabButton from './components/TabButton.jsx'
import {useState} from 'react';


function App() {

  const [valueDynamic, setValueDynamic] = useState('components');

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
            <TabButton onSelect={() => handleClick('components')}>Components</TabButton>
            <TabButton onSelect={() => handleClick('jsx')}>JSX</TabButton>
            <TabButton onSelect={() => handleClick('props')}>Props</TabButton>
            <TabButton onSelect={() => handleClick('state')}>State</TabButton>
          </menu>
          <div id="tab-content">
            <h3>{EXAMPLES[valueDynamic].title}</h3>
            <p>{EXAMPLES[valueDynamic].description}</p>
            <pre>
              <code>
              {EXAMPLES[valueDynamic].code}
              </code>
            </pre>
          </div>
          </section>
      </main>
    </div>
  );
}

export default App;
