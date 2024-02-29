import TabButton from './TabButton.jsx';
import {useState} from 'react';
import {EXAMPLES} from '../data.js';
import Section from './Section.jsx';
import Tabs from './Tabs.jsx';

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
        <Section title="Examples" id="examples">
          <Tabs 
            buttonsContainer="menu" 
              buttons={
              <><TabButton isSelected={valueDynamic == "components"} onClick={() => handleClick('components')}>Components</TabButton>
              <TabButton isSelected={valueDynamic == "jsx"} onClick={() => handleClick('jsx')}>JSX</TabButton>
              <TabButton isSelected={valueDynamic == "props"} onClick={() => handleClick('props')}>Props</TabButton>
              <TabButton isSelected={valueDynamic == "state"} onClick={() => handleClick('state')}>State</TabButton></>}>
            {message}
          </Tabs>
            
          </Section>
</>
    );
}