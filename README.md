# Webform_DK_QL
Bài tập 1 – Xây dựng Web Form Đăng ký & Quản lý người dùng

### Features Implemented
1. **User Registration Form**:
   - Fields: FullName, Email, DateOfBirth, PhoneNumber
   - Validation: Required fields, Email format, Phone format
   - Responsive design with Bootstrap 5
   - Screenshot: [Insert screenshot of Create form]

2. **User List**:
   - Displays all users in a table
   - Columns: FullName, Email, DateOfBirth, PhoneNumber, Actions (Edit/Delete)
   - Responsive table
   - Screenshot: [Insert screenshot of Index page]

3. **Edit User**:
   - Form to update user details
   - Same validations as Create
   - Screenshot: [Insert screenshot of Edit form]

4. **Delete User**:
   - Confirmation page before deletion
   - Screenshot: [Insert screenshot of Delete confirmation]

### Technologies Used
- **Framework**: .NET 9, ASP.NET Core MVC
- **Database**: SQLite
- **ORM**: Entity Framework Core
- **Frontend**: Bootstrap 5 (CDN)
- **Packages**:
  - Microsoft.EntityFrameworkCore.Sqlite
  - Microsoft.EntityFrameworkCore.Design

### Screenshots

- Home page: friendly UI home
<table>
  <tr>
    <td align="center">
      <img src="Screenshots/1.jpg" width="400"/><br/>
      <i>Home Screen</i>
    </td>
    <td align="center">
      <img src="Screenshots/1-2.jpg" width="200"/><br/>
      <i>Home Screen (Phone view)</i>
    </td>
    <td align="center">
      <img src="Screenshots/1-3.jpg" width="200"/><br/>
      <i>Setting in Phone view</i>
    </td>
  </tr>
</table>

- Index page: Shows user list in a table
<table>
  <tr>
    <td align="center">
      <img src="Screenshots/2.jpg" width="400"/><br/>
      <i>List of registered user</i>
    </td>
    <td align="center">
      <img src="Screenshots/2-2.jpg" width="200"/><br/>
      <i>List of registered user 1 (Phone view)</i>
    </td>
    <td align="center">
      <img src="Screenshots/2-3.jpg" width="200"/><br/>
      <i>List of registered user 2 (Phone view)</i>
    </td>
  </tr>
</table>


- Register form: Shows pre-filled user data
<table>
  <tr>
    <td align="center">
      <img src="Screenshots/3.jpg" width="400"/><br/>
      <i>Register user</i>
    </td>
    <td align="center">
      <img src="Screenshots/3-2.jpg" width="200"/><br/>
      <i>Registered user (Phone view)</i>
    </td>
  </tr>
</table>


- Edit form: Shows pre-filled user data
<table>
  <tr>
    <td align="center">
      <img src="Screenshots/4.jpg" width="400"/><br/>
      <i>Editing user info</i>
    </td>
    <td align="center">
      <img src="Screenshots/4-2.jpg" width="200"/><br/>
      <i>Editing user info (Phone view)</i>
    </td>
  </tr>
</table>


- Delete page: Shows confirmation dialog
<table>
  <tr>
    <td align="center">
      <img src="Screenshots/5.jpg" width="400"/><br/>
      <i>Deleting User</i>
    </td>
    <td align="center">
      <img src="Screenshots/5-2.jpg" width="200"/><br/>
      <i>Deleting User (Phone view)</i>
    </td>
  </tr>
</table>


### Limitations
- No user authentication (as not required).
- Basic styling; can be enhanced with custom CSS.
- SQLite used for simplicity; can switch to SQL Server LocalDB by updating connection string and package.
