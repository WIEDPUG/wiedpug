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
| keys:read     | ✓                   | ✓                | 
| keys:write    | ✓                   |                   |  
| lot-invoices:limited-write  |                    | ✓                |

**Administrator:** `read` and `write` access allows the administrator to transmit and read the encryption key.

**Member:** 
- `Read` access allows the member to send request for data to the endpoint. However, only resources the member has access to will be returned. 
- `Write` limited write access for member's own encryption key.