
import {CORE_CONCEPTS} from './data.js'
import Header from './components/Header/Header.jsx'
import CoreConcepts from './components/CoreConcepts.jsx'
import TabButton from './components/TabButton.jsx'


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
        <section id="examples">
          <h2>Example</h2>
          <menu>
            <TabButton>Components</TabButton>
            <TabButton>JSX</TabButton>
            <TabButton>Props</TabButton>
            <TabButton>State</TabButton>
          </menu>
          </section>
      </main>
    </div>
  );
}

export default App;
