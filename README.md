# DrinksApp-Http

Fourth console application in a series for learning .net. 

Application is meant for flashcard studying

## Requirements: 
 - [x] You were hired by restaurant to create a solution for their drinks menu.
 - [x] Their drinks menu is provided by an external company. All the data about the drinks is in the companies database, accessible through an API.
 - [x] Your job is to create a system that allows the restaurant employee to pull data from any drink in the database.
 - [x] You don't need SQL here, as you won't be operating the database. All you need is to create an user-friendly way to present the data to the users (the restaurant employees)
 - [x] When the users open the application, they should be presented with the Drinks Category Menu and invited to choose a category. Then they'll have the chance to choose a drink and see information about it.
 - [x] When the users visualise the drink detail, there shouldn't be any properties with empty values

## Features
- SQL connection
  - The program uses a SQL connection to store and read information.
  - If database or table do not exist they will be crated on startup.

- Console main menu
  - ![MainMenu](Images/MainMenu.PNG)

- Edit flashcards
  - ![EditMenu](Images/DrinksMenu.PNG)
  - User can crate a new stack of cards

- Study
  - User has option to list all previus study session or start a new study session
  - ![Study](Images/DrinksInfo.PNG)
  - Image shows english study session. Card shows 1 on one side and answer is one as written below 

- Display reports
  -

- Reporting is done for all the tables with different information, depending on request
  - "ConsoleTableExt" library was used for table display 

## Tech stack:
- Sql Server
- Sql data reader
- SQL
- .net 6.0

Special thanks to [Cappuccinocodes](https://github.com/cappuccinocodes) for help and advice.
