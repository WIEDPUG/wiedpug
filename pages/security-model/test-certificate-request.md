#### 1. Roles

**Administrator:** Owner who manages the system

**Member:** Registered participant who is involved in the trading

#### 2. Operation actions

**write:** Transmit resource data

**read:** Retrieve the resource data

#### 3. Permissions


|      Action                      | Administrator       | Member            |
|----------------------------------|---------------------|-------------------|
| test-certificate-request:write  | ✓                   | ✓                |
| test-certificate-reuqest:read   | ✓                   | ✓                |

**Administrator:** `read` and `write` access allows the administrator to read and request a Test Certificate.

**Member:** 
- `Read` access allows the member to send request for data to the endpoint. However, only resources the member has access to will be returned. 
- `Write` access allows the member to request a Test Certificate.