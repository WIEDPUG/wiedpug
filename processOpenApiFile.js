const fs = require('fs-extra');
const YAML = require('yaml');
const path = require('path');

const SWAGGER_FILE_NAME = 'swagger'
const API_FILE_NAME = 'api'


/**
 * 
 * Used to process the openapi file generated by dot.net project. changes include:
 * - Remove undersocre in the enum values, eg change from "_12" to "12".
 * - Remove classes used for schema reference for oneOf relationships
 * - Modify CentreCode to oneOf relationships
 * - Update the values in the example for re-used dataTypes
 * 
 */
const processOpenApiFile = () => {
    const inputFile = `public/openapi/${SWAGGER_FILE_NAME}.json`; // Path to your input OpenAPI spec
    const outputFile = `public/openapi/${API_FILE_NAME}`; // Path to save the modified OpenAPI spec

    // Load the OpenAPI specification
    const openApiSpec = loadOpenApiSpec(inputFile);

    // Update enum values
    updateEnumValues(openApiSpec);
    console.log(`Enum values like "_23" are converted to "23".`);

    // update data example enum values
    const newSpec = replaceQuoteUnderscore(openApiSpec)

    const spec = AllOfReferenceToSchemaWitDescription(newSpec)

    HandleReferencedSchemas(spec)
    const replacedSpec = ReplaceDataExample(spec)

    const handledDoubleSpec = hanldeDoubleMultipleOf(replacedSpec)

    // Save the modified OpenAPI spec
    saveOpenApiSpec(outputFile, handledDoubleSpec);

    console.log('OpenAPI spec updated and saved to', outputFile);
};


// Load OpenAPI specification (swagger.json)
const loadOpenApiSpec = (filePath) => {
    return fs.readJsonSync(filePath);
};

// Save OpenAPI spec back to file
const saveOpenApiSpec = (filePath, openApiSpec) => {
    fs.writeJsonSync(`${filePath}.json`, openApiSpec, { spaces: 2 });

    // Convert to YAML and save as YAML
    const yamlData = YAML.stringify(openApiSpec, { indent: 2 });
    fs.writeFileSync(`${filePath}.yaml`, yamlData, 'utf8');
};

const saveApiToYaml= () => {
    const filePath = `public/openapi/${API_FILE_NAME}`
    const openApiSpec = loadOpenApiSpec(`${filePath}.json`);
    // Convert to YAML and save as YAML
    const yamlData = YAML.stringify(openApiSpec, { indent: 2 });
    fs.writeFileSync(`${filePath}.yaml`, yamlData, 'utf8');  
}


/**
 * 
 * Processing enum values that are generated as "_34", should change it into "34" 
 * 
 */
// Update enum values
const updateEnumValues = (openApiSpec) => {
    // Traverse all schemas
    if (openApiSpec.components && openApiSpec.components.schemas) {
        const schemas = openApiSpec.components.schemas;
        for (const schemaName in schemas) {
            const schema = schemas[schemaName];
            // Check for enums
            if (schema.enum) {
                console.log(schema.enum)
                schema.enum = schema.enum.map(value => {
                    if (`${value}`.startsWith('_')) {
                        console.log(schema.enum)
                        return `${value}`.substring(1); // Remove the leading '_'
                    }
                    return value;
                });
            }
            // Recursively check properties and items
            updateEnumValuesInSchema(schema);
        }
    }
};

// Recursively update enum values in schema properties and items
const updateEnumValuesInSchema = (schema) => {
    if (schema.properties) {
        for (const key in schema.properties) {
            updateEnumValues(schema.properties[key]);
        }
    }
    if (schema.items) {
        updateEnumValues(schema.items);
    }
    if (schema.oneOf || schema.anyOf || schema.allOf) {
        const subSchemas = schema.oneOf || schema.anyOf || schema.allOf;
        subSchemas.forEach(subSchema => updateEnumValues(subSchema));
    }
};


function replaceQuoteUnderscore(jsonObj) {
    // Iterate through each key in the object
    for (const key in jsonObj) {
        const jsonValue = jsonObj[key];
        if (typeof jsonValue === 'string' && jsonValue.startsWith('_')) {
            if (jsonValue == undefined) {
                console.log("undefined jsonValue with key:", key)
            }
            // Replace the underscore if the value is a string and starts with "_"
            jsonObj[key] = jsonValue.replace(/^_/, '');
            console.log(`Replaced ${jsonValue} with ${jsonObj[key]}.`)
        } else if (typeof jsonValue === 'object' && jsonValue !== null) {
            // If the value is an object or array, recursively process it
            replaceQuoteUnderscore(jsonValue);
        }
    }

    return jsonObj;
}


/**
 * 
 * Remove property from Schema by providing the shcemaName and propertyName
 * 
 * 
 */
const RemovePropertyFromSchema = (openApiSpec, schemaName, propertyName) => {

    if (openApiSpec.components && openApiSpec.components.schemas) {
        const schemas = openApiSpec.components.schemas;

        if (schemas[schemaName]) {
            const schema = schemas[schemaName];

            if (schema.properties && schema.properties[propertyName]) {
                delete schema.properties[propertyName];
                console.log(`Property "${propertyName}" removed from schema "${schemaName}".`);
            } else {
                console.log(`Property "${propertyName}" not found in schema "${schemaName}".`);
            }
        } else {
            console.log(`Schema "${schemaName}" not found.`);
        }
    } else {
        console.log('No schemas found in the OpenAPI specification.');
    }
}




/**
 * 
 * Convert CentreCode into oneOf different Centres
 * 
 * 
 */
const modifyCentreSchema = (openApiSpec) => {
    const schemaName = 'Centre';

    if (openApiSpec.components && openApiSpec.components.schemas) {
        const schemas = openApiSpec.components.schemas;

        if (schemas[schemaName]) {
            const schema = schemas[schemaName];

            // Extract the properties
            const { properties } = schema;

            if (properties) {
                // Create the new centreCode property with oneOf
                const newCentreCodeProperty = {
                    oneOf: [
                        { "$ref": "#/components/schemas/CentreCodeAustralia" },
                        { "$ref": "#/components/schemas/CentreCodeChina" },
                        { "$ref": "#/components/schemas/CentreCodeGermany" },
                        { "$ref": "#/components/schemas/CentreCodeItaly" },
                        { "$ref": "#/components/schemas/CentreCodeNewZealand" },
                        { "$ref": "#/components/schemas/CentreCodeTaiwan" }
                    ]
                };

                // Replace the existing properties
                schema.properties = {
                    country: properties.country,
                    centreCode: newCentreCodeProperty
                };

                console.log(`Schema "${schemaName}" modified successfully.`);
            } else {
                console.log(`No properties found in schema "${schemaName}".`);
            }
        } else {
            console.log(`Schema "${schemaName}" not found.`);
        }
    } else {
        console.log('No schemas found in the OpenAPI specification.');
    }
}




/**
 * Generate individual openapi files by endpoints in both json and yaml format
 * 
 */
const generateOpenApiFilesByEndpoints = () => {
    const inputFile = `public/openapi/${API_FILE_NAME}.json`; // Path to your input OpenAPI spec
    const outputDir = 'public/openapi'; // Directory to save the output files
    // {groupName, fileName}
    const endpointGroups = {
        'catalogues': 'catalogues',
        'test-certificates': 'test-certificates',
        'dark-and-medullated-fibre-risk-verifications': 'dark-and-medullated-fibre-risk-verifications',
        'delivery-order-shipping-instructions': 'delivery-order-shipping-instructions',
        'lot-invoices': 'lot-invoices',
        'lot-price-and-buyers': 'lot-price-and-buyers',
        'payment-advices': 'payment-advices',
        'payment-confirmations': 'payment-confirmations',
        'organisation-details': 'organisation-details',
        'test-certificate-updates': 'test-certificate-updates',
        'test-certificate-requests': 'test-certificate-requests',
        'test-requests-verifications': 'test-requests-verifications',
        'test-status': 'test-status',
        'statements': 'statements',
        'postsale-printing-of-presale-certificates': 'postsale-printing-of-presale-certificates',
        'texts': 'texts',
        'keys': 'keys',
    };

    // Create output directory if it doesn't exist
    fs.ensureDirSync(outputDir);

    // Load the OpenAPI specification
    const openApiSpec = loadOpenApiSpec(inputFile);

    // Get all schemas
    const allSchemas = openApiSpec.components?.schemas || {};

    // Process each endpoint group
    for (const [groupName, baseFileName] of Object.entries(endpointGroups)) {
        const filteredPaths = filterPathsByGroup(openApiSpec, groupName);

        // Extract schemas used in filtered paths, including nested references
        const usedSchemas = extractUsedSchemas(filteredPaths, allSchemas);

        const filteredOpenApiSpec = createOpenApiDocument(openApiSpec, filteredPaths, usedSchemas);

        // Save as JSON
        saveOpenApiSpecJson(outputDir, `${baseFileName}.json`, filteredOpenApiSpec);

        // Save as YAML
        saveOpenApiSpecYaml(outputDir, `${baseFileName}.yaml`, filteredOpenApiSpec);
    }
};


// Filter paths by group
const filterPathsByGroup = (openApiSpec, groupName) => {
    const filteredPaths = {};
    for (const [path, pathItem] of Object.entries(openApiSpec.paths)) {
        if (path.includes(groupName)) {
            filteredPaths[path] = pathItem;
        }
    }
    return filteredPaths;
};

// Recursively extract all referenced schemas
const extractReferencedSchemas = (schema, allSchemas, usedSchemas) => {
    if (schema.$ref) {
        const ref = schema.$ref;
        const schemaName = ref.split('/').pop();
        if (allSchemas[schemaName] && !usedSchemas[schemaName]) {
            usedSchemas[schemaName] = allSchemas[schemaName];
            // Recursively check for nested references
            extractReferencedSchemas(allSchemas[schemaName], allSchemas, usedSchemas);
        }
    } else if (schema.properties) {
        for (const key of Object.keys(schema.properties)) {
            extractReferencedSchemas(schema.properties[key], allSchemas, usedSchemas);
        }
    } else if (schema.items) {
        extractReferencedSchemas(schema.items, allSchemas, usedSchemas);
    } else if (schema.oneOf || schema.anyOf || schema.allOf) {
        const subSchemas = schema.oneOf || schema.anyOf || schema.allOf;
        subSchemas.forEach(subSchema => extractReferencedSchemas(subSchema, allSchemas, usedSchemas));
    }
};

// Extract schemas used in filtered paths
const extractUsedSchemas = (filteredPaths, allSchemas) => {
    const usedSchemas = {};
    Object.values(filteredPaths).forEach(pathItem => {
        Object.values(pathItem).forEach(operation => {
            if (operation.requestBody && operation.requestBody.content) {
                Object.values(operation.requestBody.content).forEach(content => {
                    if (content.schema) {
                        extractReferencedSchemas(content.schema, allSchemas, usedSchemas);
                    }
                });
            }
            if (operation.responses) {
                Object.values(operation.responses).forEach(response => {
                    if (response.content) {
                        Object.values(response.content).forEach(content => {
                            if (content.schema) {
                                extractReferencedSchemas(content.schema, allSchemas, usedSchemas);
                            }
                        });
                    }
                });
            }
        });
    });
    return usedSchemas;
};

// Create OpenAPI document with filtered paths and schemas
const createOpenApiDocument = (openApiSpec, filteredPaths, schemas) => {
    if (openApiSpec.components && openApiSpec.components.securitySchemes) {
        return {
            ...openApiSpec,
            paths: filteredPaths,
            components: {
                schemas: schemas,
                securitySchemes: openApiSpec.components.securitySchemes,
            },
        };
    }

    return {
        ...openApiSpec,
        paths: filteredPaths,
        components: {
            schemas: schemas,
        },
    };
};

// Save OpenAPI spec to JSON file
const saveOpenApiSpecJson = (outputDir, fileName, openApiSpec) => {
    const outputPath = path.join(outputDir, fileName);
    fs.writeJsonSync(outputPath, openApiSpec, { spaces: 2 });
};

// Save OpenAPI spec to YAML file
const saveOpenApiSpecYaml = (outputDir, fileName, openApiSpec) => {
    const outputPath = path.join(outputDir, fileName);
    const yamlData = YAML.stringify(openApiSpec, { indent: 2 });
    fs.writeFileSync(outputPath, yamlData, 'utf8');
};


// Function to convert schemas with `allOf` to `schema`
const convertAllOfToSchema = (schema) => {
    if (schema.allOf) {
        // Create a new schema object to hold the converted schema
        const newSchema = { ...schema };

        // Move the `allOf` content to `schema`
        newSchema.schema = { ...schema.allOf[0] };

        // If there is a description in the original schema, move it under the new `schema`
        if (schema.description) {
            newSchema.schema.description = schema.description;
        }

        // Remove the `allOf` and `description` from the outer schema
        delete newSchema.allOf;
        delete newSchema.description;

        // Copy additional properties from the original schema
        Object.keys(schema).forEach((key) => {
            if (key !== 'allOf' && key !== 'description') {
                newSchema[key] = schema[key];
            }
        });
        return newSchema;
    }

    // Recursively convert nested schemas
    if (schema.properties) {
        Object.keys(schema.properties).forEach((key) => {
            schema.properties[key] = convertAllOfToSchema(schema.properties[key]);
        });
    }

    return schema;
}


const AllOfReferenceToSchemaWitDescription = (openApiSpec) => {
    // Convert all schemas in the OpenAPI spec
    openApiSpec.components && openApiSpec.components.schemas
    if (openApiSpec.components && openApiSpec.components.schemas) {
        Object.keys(openApiSpec.components.schemas).forEach((schemaName) => {
            convertAllOfToSchema(openApiSpec.components.schemas[schemaName]);
        });
    }

    return openApiSpec;
}


const HandleReferencedSchemas = (openApiSpec) => {
    // Check if the schemas section exists
    if (openApiSpec.components && openApiSpec.components.schemas) {
        // Check if the LiteralDate schema exists
        if (openApiSpec.components.schemas.LiteralDate) {
            // Remove the additionalProperties field
            delete openApiSpec.components.schemas.LiteralDate.additionalProperties;
        }

        if (openApiSpec.components.schemas.UtcDateTime) {
            // Remove the additionalProperties field
            delete openApiSpec.components.schemas.UtcDateTime.additionalProperties;
        }

        if (openApiSpec.components.schemas.Season) {
            // Remove the additionalProperties field
            delete openApiSpec.components.schemas.Season.additionalProperties;
        }

        if (openApiSpec.components.schemas.NumberOfBales) {
            // Remove the additionalProperties field
            delete openApiSpec.components.schemas.NumberOfBales.additionalProperties;
        }

        if (openApiSpec.components.schemas.LotIdentity) {
            // Remove the additionalProperties field
            delete openApiSpec.components.schemas.LotIdentity.additionalProperties;
        }

        if (openApiSpec.components.schemas.BaleDescription) {
            // Remove the additionalProperties field
            delete openApiSpec.components.schemas.BaleDescription.additionalProperties;
        }
    }
}

const ReplaceDataExample = (openApiSpec) => {
    // Convert object to a JSON string for replacement
    let jsonString = JSON.stringify(openApiSpec);

    // Use a regular expression to find patterns like {"dateTime": "value"} and convert to "value"
    jsonString = jsonString.replace(/{"dateTime":"([^"]+)"}?/g, (match, p1, offset) => {
        console.log(`Found match at position ${offset}: ${match}`);
        console.log(`Replaced by "${p1}"`);
        // Replace the object with just the datetime value
        return `"${p1}"`;
    });

    // Use a regular expression to find patterns like {"date": "value"} and convert to "value"
    jsonString = jsonString.replace(/{"date":"([^"]+)"}?/g, (match, p1, offset) => {
        console.log(`Found match at position ${offset}: ${match}`);
        console.log(`Replaced by "${p1}"`);
        // Replace the object with just the date value
        return `"${p1}"`;
    });

    // Use a regular expression to find patterns like {"identity": "value"} and convert to "value"
    jsonString = jsonString.replace(/{"identity":"([^"]+)"}?/g, (match, p1, offset) => {
        console.log(`Found match at position ${offset}: ${match}`);
        console.log(`Replaced by "${p1}"`);
        // Replace the object with just the date value
        return `"${p1}"`;
    });

    // Use a regular expression to find patterns like {"seasonValue": "value"} and convert to value
    jsonString = jsonString.replace(/{"seasonValue":(\d+)}/g, (match, p1, offset) => {
        console.log(`Found match at position ${offset}: ${match}`);
        console.log(`Replaced by ${p1}`);
        // Replace the object with just the date value
        return p1;
    });

    // Use a regular expression to find patterns like {"balesCount": "value"} and convert to value
    jsonString = jsonString.replace(/{"balesCount":(\d+)}/g, (match, p1, offset) => {
        console.log(`Found match at position ${offset}: ${match}`);
        console.log(`Replaced by ${p1}`);
        // Replace the object with just the date value
        return p1;
    });

    
    // Use a regular expression to find patterns like {"baleDescriptionContent": "value"} and convert to "value"
    jsonString = jsonString.replace(/{"baleDescriptionContent":"([^"]+)"}?/g, (match, p1, offset) => {
        console.log(`Found match at position ${offset}: ${match}`);
        console.log(`Replaced by "${p1}"`);
        // Replace the object with just the date value
        return `"${p1}"`;
    });

    // Convert the updated string back to a JavaScript object
    return JSON.parse(jsonString);
}


const hanldeDoubleMultipleOf = (openApiSpec) => {

    function processSchema(schema) {
        // Iterate over the keys in the current schema
        for (let key in schema) {
            let field = schema[key];

            // Check if this field is an object and recurse if necessary
            if (typeof field === 'object' && field !== null) {
                // If the field is a number with double format, calculate multipleOf
                if (field.type === "number" && field.format === "double" && typeof field.maximum === 'number') {
                    const maxValueStr = field.maximum.toString();
                    const decimalPart = maxValueStr.split('.')[1];
                    
                    if (decimalPart) {
                        const decimalDigits = decimalPart.length;
                        field.multipleOf = 1 / Math.pow(10, decimalDigits);
                    } else {
                        field.multipleOf = 1; // No decimal part, treat as integer
                    }

                    console.log(`Added multipleOf to field: ${key}, multipleOf: ${field.multipleOf}`);
                }

                // Recurse into nested objects or properties
                processSchema(field);
            }
        }
    }

    // Apply the function to the 'components.schemas' or the root object of your openApiSpec
    processSchema(openApiSpec.components.schemas);

    return openApiSpec
}

const generateSchemaOnlyFile = () =>{
    const inputFile = `public/openapi/${API_FILE_NAME}.json`; // Path to your input OpenAPI spec
    const outputDir = 'public/openapi'; // Directory to save the output files

    // Create output directory if it doesn't exist
    fs.ensureDirSync(outputDir);

    // Load the OpenAPI specification
    let openApiSpec = loadOpenApiSpec(inputFile);

    // Remove the "paths" section
    delete openApiSpec.paths;

    saveOpenApiSpecJson(outputDir, `schema.json`, openApiSpec);
}


const updateApiVersion = ()=>{    
    // Paths to your config and API files
    const configFilePath = path.join(__dirname, 'openapi-config.json');
    const apiFilePath = path.join(__dirname, '/public/openapi/api.json');
 
    
    // Step 1: Read the version from openapi-config.json
    const configData = JSON.parse(fs.readFileSync(configFilePath, 'utf-8'));
    const newVersion = configData.version; // e.g., "0.0.0"
    
    // Extract the major version from the version string
    const majorVersion = newVersion.split('.')[0]; // Gets the major version (e.g., "0")
    
    // Step 2: Read and parse the OpenAPI JSON file
    let apiData = JSON.parse(fs.readFileSync(apiFilePath, 'utf-8'));

    //     // Function to replace the version in path string
    // const replaceVersionInPath = (path, oldVersion) => {
    //     if (path.startsWith(`/${oldVersion}`)) {
    //         return path.replace(`/${oldVersion}`, `/v${newVersion}`);
    //     }
    //     return path;
    //     };

    // // Update the version in the paths
    // if (apiData.paths) {
    //     Object.keys(apiData.paths).forEach((path) => {
    //     const pathSegments = path.split('/'); // Split path into segments
    //     const oldVersion = pathSegments[1]; // Assuming version is the second segment (e.g., 'v0')
    //     // Replace the old version with the new version
    //     if (oldVersion && oldVersion.startsWith('v')) {
    //         const newPath = replaceVersionInPath(path, oldVersion);
    //         apiData.paths[newPath] = apiData.paths[path];
    //         delete apiData.paths[path];
    //     }
    //     });
    // }

    
    // Step 3: Update the version in the info section
    apiData.info.version = newVersion; // Keep the full version in info
    
    // Step 4: Update the endpoints with the new major version in the paths
    const oldVersionPattern = /\/v[0-9]+/g; // Match /v1 or /v0
    Object.keys(apiData.paths).forEach((endpoint) => {
        const newEndpoint = endpoint.replace(oldVersionPattern, `/v${majorVersion}`);
        if (newEndpoint !== endpoint) {
            apiData.paths[newEndpoint] = apiData.paths[endpoint];
            delete apiData.paths[endpoint];
        }
    });
    
    // Step 5: Write the updated JSON back to api.json
    fs.writeFileSync(apiFilePath, JSON.stringify(apiData, null, 2));
    
    console.log(`Updated OpenAPI spec with version: v${newVersion}`);
    
}


const main = () => {
    
    processOpenApiFile()  // If you start from api.json file directly, comment out this line

    updateApiVersion() // Uncomment it if you want to overwrite the version number being defined by the dotnet project
    saveApiToYaml()
    generateOpenApiFilesByEndpoints()
    generateSchemaOnlyFile()
}

main()