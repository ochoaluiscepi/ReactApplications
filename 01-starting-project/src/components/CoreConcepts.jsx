import {CORE_CONCEPTS} from '../data.js'
import CoreConcept from './CoreConcept.jsx'

export default function CoreConcepts(){
    return (
<section id="core-concepts">
          <h2>Core Concepts</h2>
          <ul>
            {/* Manually add: <CoreConcepts {...CORE_CONCEPTS[0]} /> */}
            
            {CORE_CONCEPTS.map((concept) => <CoreConcept title={concept.title} description={concept.description} image={concept.image} />)}
            
          </ul>
        </section>

    );
}
