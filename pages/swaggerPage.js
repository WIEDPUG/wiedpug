import React, {useEffect} from 'react';
import SwaggerUI from 'swagger-ui-react';
import 'swagger-ui-react/swagger-ui.css';

const SwaggerPage = ({url}) => {
  const swaggerOptions = {
    url:url,
    defaultModelsExpandDepth: 1,  
    defaultModelExpandDepth: 2,    
    docExpansion: "full"           
  };

  useEffect(() => {
    // This runs after the component is rendered
    const elements = document.querySelectorAll('aria-expanded');
    console.log(elements)
    elements.forEach((button) => {
      button.click(); // Programmatically click the button
    });
  }, []);

  return <SwaggerUI {...swaggerOptions} />;
};

export default SwaggerPage;
