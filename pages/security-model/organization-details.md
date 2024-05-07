#### 1. Roles

**Administrator:** owner who manages the system

**Member:** registed participant who is involved in the trading

#### 2. Operation actions

**read:** retrieve the resource data

**write:** create, update or delete the resource data

**limited-write:** create or update the information only related to the user from the resource data

#### 3. Permissions


|      Action                   | Administrator       | Member            | 
|-------------------------------|---------------------|-------------------|
| organization-details:read     | ✓                   | ✓                | 
| organization-details:write    | ✓                   |                   |  

**Administrator:** Full access (read/write) to OrganizationDetails.

**Member:** Read access to OrganizationDetails.