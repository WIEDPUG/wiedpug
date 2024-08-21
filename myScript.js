const fs = require('fs');

// Function to count occurrences of direct property names
function countDirectPropertyNames(schema, propertyCounts = {}) {
    if (typeof schema === 'object' && schema !== null) {
        // Check if the schema has properties at the top level
        if (schema.properties) {
            for (const propName in schema) {
                const propSchema = schema[propName];
                // Only count properties with a type
                if (propSchema.type) {
                    propertyCounts[propName] = (propertyCounts[propName] || 0) + 1;
                }
            }

        }

        // // Process additional schemas if any, but only at the top level
        // for (const value of Object.values(schema)) {
        //     if (typeof value === 'object') {
        //         // Check if the value is a schema and has properties
        //         if (value.properties) {
        //             countDirectPropertyNames(value, propertyCounts);
        //         }
        //     }
        // }
    }

    return propertyCounts;
}

// Main function to load the JSON file and count property names
function main(filePath) {
    const data = JSON.parse(fs.readFileSync(filePath, 'utf8'));
    
    // Extract schemas from OpenAPI
    const schemas = data.components && data.components.schemas ? data.components.schemas : {};
    
    const allCounts = {};

    // Iterate through schemas and count property names
    for (const schemaName in schemas) {
        const schema = schemas[schemaName];
        const counts = countDirectPropertyNames(schema, allCounts);
        for (const [propName, count] of Object.entries(counts)) {
            allCounts[propName] = (allCounts[propName] || 0) + count;
        }
    }

    // Print results
    for (const [propName, count] of Object.entries(allCounts)) {
        console.log(`Property Name: ${propName}, Count: ${count}`);
    }
}

// Run the script
const filePath = 'public/openapi/api.json'; // Replace with the path to your OpenAPI JSON file
main(filePath);
