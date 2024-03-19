#### 1. Roles

**Administrator:** owner who manages the system

**Member:** registed participant who involves in the trading

**Guest:** public user

#### 2. Operation actions

**read:** retrieve the resource data

**write:** create, update or delete the resource data

**limited-write:** create or update the information only related to the user from the resource data

**set-visibilities** set visibility of the part of the resource data

#### 3. Permissions


|      Action                   | Administrator       | Member            | 
|-------------------------------|---------------------|-------------------|
| organization-details:read     | ✓                   | ✓                | 
| organization-details:write    | ✓                   |                   |  
| organization-details:limited-write  |               | ✓                 |
| organization-details:set-visibilities| ✓            |                   |

**Administrator:** Full access (read/write/set-visibilities) to OrganizationDetails.

**Member:** Read access to OrganizationDetails, limited write access for member's own OrganizationDetails information.