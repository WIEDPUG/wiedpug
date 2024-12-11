### Instructions

The build process will automatically replace the value of "example" under the matched request/response in the openapi file.

The example files should be under the this folder. 

The file name should match this pattern:  

{base_endpoint}.{sub_endpoint}-{httpMethod}-{request-or-response}-{status-code}.json

The file name should be all in lower case.

The system will only process json file for the replacement.

The api version number will not impact the processing.


### File name examples:

organisation-details.{id}_get_request.json       --> GET /organisation-details/{id} request example

organisation-details.{id}_get_response_200.json  --> GET /organisation-details/{id} response 200 example

organisation-details.data_post_request.json      --> POST /organisation-details/data request example

organisation-details.data_post_response_200.json --> POST /organisation-details/data response 200 example

organisation-details.data_post_response_400.json --> POST /organisation-details/data response 400 example

organisation-details.{id}_put_request.json       --> PUT /organisation-details/{id} request example

organisation-details.{id}_put_response_200.json  --> PUT /organisation-details/{id} response 200 example

statements_post_request.json                     --> POST /statments request example

statements_post_response_200.json                --> POST /statments response 200 example

statements.data_post_request.json                --> POST /statments/data request example

statements.data_post_response_400.json           --> POST /statments/data response 400 example
