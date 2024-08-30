const fs = require('fs');
const path = require('path');

// Function to count occurrences of direct property names
function countDirectPropertyNames(schema, propertyCounts = {}) {
    if (typeof schema === 'object' && schema !== null) {
        const properties = schema.properties
        // Check if the schema has properties at the top level
        if (properties) {
            for (let propName in properties) {
                const propSchema = properties[propName];

                // Only count properties with a type
                if (propSchema.type) {
                    if (propertyCounts[propName]) {
                        propertyCounts[propName] ++
                    } else {
                        propertyCounts[propName] = 1
                    }
                    
                }
            }

        }

    }

    return propertyCounts;
}

// Function to convert array to CSV format
function arrayToCSV(array) {
    return array.map(row => row.join(',')).join('\n');
}

// Function to save CSV to a file
function saveCSV(array, filename) {
    const csvContent = arrayToCSV(array);
    const filePath = path.join(__dirname, filename);

    fs.writeFile(filePath, csvContent, 'utf8', (err) => {
        if (err) {
            console.error('Error writing file:', err);
        } else {
            console.log('File saved successfully:', filePath);
        }
    });
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
        // for (const [propName, count] of Object.entries(counts)) {
        //     allCounts[propName] = (allCounts[propName] || 0) + count;
        // }
    }

    // sort the mao
    const sortedArray = Object.entries(allCounts).sort((a,b)=> b[1] - a[1])

    // Print results
    console.log(sortedArray)

    // Trigger CSV download
    saveCSV(sortedArray,'data.csv');
}

// Run the script
const filePath = 'public/openapi/api.json'; // Replace with the path to your OpenAPI JSON file
main(filePath);
