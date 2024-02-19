
import {CORE_CONCEPTS} from './data.js'
import Header from './components/Header/Header.jsx'
import CoreConcepts from './components/CoreConcepts.jsx'
import TabButton from './components/TabButton.jsx'
import {useState} from 'react';


function App() {

  const [valueDynamic, setValueDynamic] = useState('initial');

  function handleClick(selectedButton){
    switch(selectedButton){
      case 'Components':
        setValueDynamic(CORE_CONCEPTS[0].description);
      break;
      case 'JSX':
        setValueDynamic(CORE_CONCEPTS[1].description);
      break;
      case 'Props':
        setValueDynamic(CORE_CONCEPTS[2].description);
      break;
      case 'State':
        setValueDynamic(CORE_CONCEPTS[3].description);
      break;
    }
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
            <TabButton onSelect={() => handleClick('Components')}>Components</TabButton>
            <TabButton onSelect={() => handleClick('JSX')}>JSX</TabButton>
            <TabButton onSelect={() => handleClick('Props')}>Props</TabButton>
            <TabButton onSelect={() => handleClick('State')}>State</TabButton>
          </menu>
          {valueDynamic}
          </section>
      </main>
    </div>
  );
}

export default App;
