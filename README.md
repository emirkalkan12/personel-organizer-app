# Personal Organizer Application

The user needs a personal organizer application which can be used by multiple users. The application includes a phonebook, notes, personal information, reminders on the calendar, and a salary calculator. Data for each module is stored in a separate CSV file, and phone records are linked to their owners stored in the user file.

## User Management

- The first registered user is assigned as the administrator.
- Other users are registered as normal users.
- Admin users can change user types: Admin, User, Part-time-user.
- A user management window is provided and is accessible only by admin users.

## Phone Book

- Stores: name, surname, phone number, address, description, email.
- Data is stored in `phonebook.csv`.
- Phone number is formatted as (555) 555 55 55.
- Email is validated using a regular expression.
- Numeric fields accept only numbers.

**Supported operations:**
- List records  
- Create a record  
- Update a record  
- Delete a record

## Notes

- Notes module supports plain text entries.
- Users can create, update, delete and list multiple notes.
- Data is stored in `notes.csv`.

**Supported operations:**
- List notes  
- Create a note  
- Update a note  
- Delete a note

## Personal Information

- Users can view and update profile information: name, surname, phone number, address, email, password, and photo.
- Profile photo is stored as Base64 in the CSV file.
- Undo (CTRL+Z) and Redo (CTRL+Y) are implemented for all input fields.
- Users can change their password within the profile screen.

## Salary Calculator

- Salary is calculated based on BMO rules.
- Factors include education, language, experience, location, title, and family status.
- Part-time users receive 50% of the full salary.
- Fields are dynamically shown/hidden based on user type.
- Salary is displayed on the profile screen.

## Reminder

- Two types: meeting and task.
- Each reminder includes date, time, summary, and description.
- When triggered:
  - Summary appears in the window title.
  - Active window shakes for 2 seconds.
  - A message box appears to notify the user.
- Data is managed per user in CSV format.

**Supported operations:**
- List reminders  
- Add reminder  
- Update reminder  
- Delete reminder

## Additional Functionalities

- Admins can send new passwords via email.
- A progress bar is shown during email sending.
- On application close (X), the system prompts:  
  `"Do you really want to exit?"`
