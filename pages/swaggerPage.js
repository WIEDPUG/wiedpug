import React, {useEffect} from 'react';
import SwaggerUI from 'swagger-ui-react';
import 'swagger-ui-react/swagger-ui.css';

const SwaggerPage = ({url}) => {
  const swaggerOptions = {
    url:url,
    defaultModelsExpandDepth: 1,  
    defaultModelExpandDepth: 2,    
    docExpansion:'full'          
  };

  useEffect(() => {
    // Set up an interval to check for the buttons
    const intervalId = setInterval(() => {
      // Select all buttons with the class 'model-box-control'
      const buttons = document.querySelectorAll('button.model-box-control');

      if (buttons.length > 0) {
        console.log('Found buttons:', buttons);

        // Programmatically click each button
        buttons.forEach((button) => {
          button.click();
        });

        // Clear the interval once buttons are found and clicked
        clearInterval(intervalId);
      }
    }, 500); // Check every 500ms

    // Clean up the interval when the component unmounts
    return () => clearInterval(intervalId);
  }, []);


  return <SwaggerUI {...swaggerOptions} />;
};

export default SwaggerPage;
