const fs = require('fs-extra');
const path = require('path');
const yaml = require('js-yaml');
const $RefParser = require('json-schema-ref-parser');
const convert = require('openapi-schema-to-json-schema');

// Load and parse the OpenAPI file (YAML or JSON)
async function loadOpenApiFile(filePath) {
  const ext = path.extname(filePath).toLowerCase();
  const fileContent = await fs.readFile(filePath, 'utf8');
  if (ext === '.yaml' || ext === '.yml') {
    return yaml.load(fileContent);
  } else if (ext === '.json') {
    return JSON.parse(fileContent);
  } else {
    throw new Error('Unsupported file format. Please provide a JSON or YAML file.');
  }
}

// Convert OpenAPI schema to JSON Schema
async function convertToJSONSchema(schema) {
  return convert(schema, {
    cloneSchema: true, // Clone the schema so that it's not modified in place
    keepNotSupported: ['nullable'], // Keep OpenAPI specific keywords
  });
}

// Save schemas as individual JSON files
async function saveSchemas(schemas, outputDir) {
  await fs.ensureDir(outputDir);

  for (const [schemaName, schemaContent] of Object.entries(schemas)) {
    const jsonSchemaContent = await convertToJSONSchema(schemaContent);
    const schemaFilePath = path.join(outputDir, `${schemaName}.json`);
    await fs.writeJson(schemaFilePath, jsonSchemaContent, { spaces: 2 });
    console.log(`Schema saved to: ${schemaFilePath}`);
  }
}

// Main function to execute the conversion
async function convertOpenApiToJsonSchemas(openApiFilePath, outputDir) {
  try {
    // Load OpenAPI document
    const openApiDoc = await loadOpenApiFile(openApiFilePath);

    // Resolve $ref pointers
    const resolvedOpenApiDoc = await $RefParser.dereference(openApiDoc);

    // Check if there are any schemas in the OpenAPI document
    if (!resolvedOpenApiDoc.components || !resolvedOpenApiDoc.components.schemas) {
      throw new Error('No schemas found in the OpenAPI document.');
    }

    // Extract schemas
    const schemas = resolvedOpenApiDoc.components.schemas;

    // Save schemas as individual JSON Schema files
    await saveSchemas(schemas, outputDir);
    console.log('All schemas have been extracted and saved as JSON Schema.');
  } catch (error) {
    console.error('Error during conversion:', error.message);
  }
}

// Define the input OpenAPI file and output directory
const openApiFilePath = path.resolve(__dirname, 'public/openapi/api.json'); // Change this to your OpenAPI file path
const outputDir = path.resolve(__dirname, 'schemas');

// Run the conversion
convertOpenApiToJsonSchemas(openApiFilePath, outputDir);
