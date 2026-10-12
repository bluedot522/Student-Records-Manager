# Student-Records-Manager
## Purpose
The purpose of this application is to display student records, search, and sort them through a variety of conditions.
## Creation
Student records are created by loading a JSON file. It belongs to the file path \bin\Debug\net10.0-windows. This file must be named 'students.json' and information for each student must be in the following structure:
{
    "StudentId": 1001,
    "FirstName": "Abigail",
    "LastName": "Johnson",
    "ProgramName": "Biology",
    "GPA": 3.5
  }
## Queries
The 'Show All' button returns a table of all student information, unsorted.
The 'Filter Program' button requires a text entry in the 'Program' drop down menu. It returns only the students in the matching program.
The 'Filter GPA' button requires a decimal value entered into the 'Minimum GPA' field. The minimum and default value is 0.0 while the maximum value is 4.0.
The 'Summary' button displays the total amount of students, the highest and lowest GPAs, and the number of students with 3.0 GPA or higher.
The 'Sort by Last Name' button sorts the table of students by last name in alphabetical order.
The 'Sort by GPA' button sorts the table of students by highest to lowest GPA values.
The 'Under X GPA By Program' button requires a program entry in the 'Program' box as well as a GPA value in the 'Minimum GPA' box. 
The 'Search' button requires a text entry of either a student ID or student name in the 'Student ID or Name" text box. When clicked, it displays a student matching the result.
The 'Quit' button exits the program.

## LINQ Operators
The following LINQ operators are included:
Where(), OrderByDescending(), ThenBy, Count(), Average(), Max(), and Min(). Summary information first receives the count of total students through Count(). The Average() operator calculates the average GPA, while Max() and Min() return the highest and lowest GPAs respectively. To find the number of students with a GPA of 3.0 or higher, the count of students is found through Count() and then filtered through a condition of GPA being 3.0 or higher.

## Limitations
This program does not make use of FirstOrDefault() due to errors. Theoretically, more than one result might be returned if two students shared the same last name, or else an ID number by accident. A JSON file must be loaded manually to the correct program directory or edited outside of the program. Entry fields must also be cleared manually. 
