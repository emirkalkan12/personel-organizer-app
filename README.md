Personal Organizer Application
The user needs a personal organizer application which can be used by multiple users. The application includes a phonebook, notes, personal information, reminders on the calendar and a salary calculator. Hold data for each module in a separate CSV file but do not forget to link a phone record and its owner who is stored in the user file.

User Management
The first registered user will be the administrator of the system.

Other users will be registered as normal users.

Admin users can change user types: Admin, User, Part-time-user.

A user management window is created and only accessible to admin users.

Phone Book
A detailed phone book is implemented with the following fields: name, surname, phone number, address, description, e-mail.

Data is stored in phonebook.csv.

The phone number input is formatted as (555) 555 55 55.

The email input is validated using a regular expression.

Numeric fields only accept numeric input.

Supported operations:

List records

Create a record

Update a record

Delete a record

Notes
Notes module supports plain text entries.

A user can create, update, delete and list multiple notes.

Data is stored in notes.csv.

Supported operations:

List notes

Create a note

Update a note

Delete a note

Personal Information
Users can view and update their profile including name, surname, phone number, address, e-mail, password, and photo.

Photo is stored as base64 in the user CSV file.

CTRL-Z and CTRL-Y support is implemented for undo and redo on each input field.

Password change functionality is available in the profile screen.

Salary Calculator
A screen is designed to calculate the user's minimum salary according to BMO rules.

Calculation considers parameters like education, foreign language, experience, location, job title, and family status.

The calculated salary is displayed on the profile screen.

Part-time users receive 50% of the calculated salary.

Fields are shown or hidden dynamically depending on the user type.

Reminder
Two types of reminders: meeting and task.

Each reminder has a date, time, summary and description.

The summary is shown on the window title when the reminder is triggered.

The window shakes for 2 seconds upon activation.

Message box alerts are used to notify the user.

Data is managed in CSV files per user.

Supported operations:

List reminders

Add reminder

Update reminder

Delete reminder

Additional Functionalities
Administrators can send a new password to users via email.

A progress bar is shown during the email sending process.

On close (X), the application prompts with a confirmation message asking if the user really wants to exit.
