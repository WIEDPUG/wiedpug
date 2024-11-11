
### Catelogue

#### 1. Roles

**Administrator:** Owner who manages the system

**Member:** Registered participant who is involved in the trading

#### 2. Operation actions

**write:** Transmit resource data

**read:** Retrieve the resource data

**limited-write:** create or update the information only related to the user from the resource data

#### 3. Permissions


|      Action                      | Administrator       | Member            |
|----------------------------------|---------------------|-------------------|
| catalogue:write  | ✓                   |                |
| catalogue:read   | ✓                   | ✓                |
| catalogue:limited-write  |                   | ✓                |

**Administrator:** `read` and `write` access allows the administrator to transmit Auction Catalogue, Private Catalogue and Auction Catalogue Updates to the network, as well as request for data.

**Member:** 
- `Read` access allows the member to send request for data to the endpoint. However, only resources the member has access to will be returned. 
- `Write` limited write access for member's own Auction Catalogue, Private Catalogue and Auction Catalogue Updates.