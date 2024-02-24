import TabButton from './TabButton.jsx'
import {useState} from 'react';
import {EXAMPLES} from '../data.js'

export default function Examples(){
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
        <>
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
</>
    );
}