# Board-Game
An oop project where user interaction and user data are collected in database.

## Table of Contents
- [How to Play](#how-to-play)
- [Project Description](#project-description)
- [Game Screens(#game-screens)
  - [Login Screen](#login-screen)
  - [Profile Screen](#profile-screen)
  - [Manager Screen](#manager-screen)
  - [Setting Screen](#setting-screen)
  - [Sign up Screen](#sign-up-screen)
  - [Help Screen](#help-screen)
  - [About Screen](#about-screen)
  - [Password Screen](#password-screen)
- [Other Creator](#other-creator)

# How to Play
If you have never registered, start by signed up. After signed up, you can start the game by entering your username and password.
From the menu option, you can change the game's settings(game size, game shapes...) and your user settings or you can access information about the game.
The game is played by bringing 5 shapes of the same color side by side and removing them from the game board. Select the shape you want to move and click on an empty area where you want to bring the shape. The game will end when there is no room left on the game board.

![z](https://user-images.githubusercontent.com/102357822/197343482-cfc722dc-e2a5-464d-912b-752c1d990824.png)

# Project Description

1. The system has pre-registered multiple users.
User types;
- Admin
- User

2. Default username and passwords are given below;
- admin/admin
- user/user

3. On the first screen (login), some components are required for username, password, and
log in.
- Username field entrance with only alphabetic characters: [A-Za-z].
- On startup, remembers the last successful login attempt’s username. If there is a
successful login, the username field filled by the last username.
- TThere is a button on the login screen to see the entered password as clear
text and vice versa.

4. The Password field shows the characters as ‘******’

5. The login button checks the entered information;
- If it fails, shows a warning message.
- If it passes, System hides the Login window and shows a new main game
window. 

6. Pressing the “Enter” key at the login screen has the same functionality as clicking on the
login button.

7. At the first run, the username field is focused.

8. Pressing the “Tab” key changes focus to the password field, next press focuses on login,
when no component is left, focuses on the username field again.

9. Sign up screen(window) to make users register;
- Signed up users' types are 'User'
- Users' passwords are stored as hash equivalents.
i. Uses SHA2 to create the hash of the user's password.
- User information;
i. Username,
ii. Password,
iii. Name-Surname
iv. Phone Number
v. Address
vi. City
vii. Country
viii. E-mail

10. Admin users manages other users by a manager screen(window);
- List all users
- Add a new user
- Update a user's information (except for the username)
- Delete a user permanently

11. All users have their profile screen to manage their user information except for the
username.

12. The main game window have a menu component to go to the Settings screen.

13. A difficulty level option is on the settings screen;
- Easy
- Normal
- Hard
- Custom (Custom options will gather 2 integer values to create the matrix for the game
board)

14. A shape option is required on the settings screen. Users need to be able to select one or
more of the;
- square
- triangle
- round 

15. A color option is find on the settings screen, and users be able to select 1 to 3
different colors;
- red
- blue
- green

16. The system saves all settings permanently when the user clicks the save button. On
the next run, saved settings remembered by the system.

17. About Screen;
- Game Name, Credits, Information about developers, Development date

18. Help Screen;
- Usage of the game
- Definition of the game components
- A button to see about screen

19. When the game starts, the game places a random colour and shape on three random
points (boxes) on the 9x9 board.
- The game forms a 9x9 chessboard when at the intermediate level.
- If the game level differs from intermediate, the game board adapts to the
level.

20. The user ables to select a shape placed on the game board and move it to the
desired point/empty box.
- The migration phase showns step-by-step by the program.

21. After the user makes move;
- If five same coloured and shaped boxes are side by side (vertically or
horizontally), these boxes (same shaped and coloured five boxes) will be emptied.

22. Point for the gamer:
- Custom Level: 2 points (?x?)
- Easy Level: 1 point (15x15)
- Intermediate Level: 3 points (9x9)
- Hard Level: 5 points (6x6)

23. The program will randomly fill three boxes with random colours and shapes and
wait for the user’s next move.

24. If there is no empty box to move, in other words, all boxes are filled, the
game is over and game will be scored.

25. If the user selects a different level, the game board recreated with new
dimensions.

26. The best score showns on the game board. The application stores user records
and selects the best score to show.

27. The delete operations shows a validation warning dialogue.

28. Admin needs to list users with their best scores and sort them by ascending or descending
scores.

29. When the user makes a move, game plays a sound for each step.
- At the end of the steps, if the user takes a score point, game plays a  different sound

30. Created a database to store all user data(name, password, scores etc. (not settings)).

# Game Screens

## Login Screen
![Screenshot 2022-11-20 161719](https://user-images.githubusercontent.com/102357822/202904566-76ed84c8-f9c8-4e25-8384-28b704c22e4d.png)


## Profile Screen
![Screenshot 2022-11-20 161933](https://user-images.githubusercontent.com/102357822/202905019-44ea1d05-0053-4710-83c0-bd5ca426d832.png)


## Manager Screen
![Screenshot 2022-11-20 161907](https://user-images.githubusercontent.com/102357822/202904613-9c2a4f14-506d-4380-a51a-763e4b540a92.png)


## Setting Screen
![Screenshot 2022-11-20 162231](https://user-images.githubusercontent.com/102357822/202905026-a87e4272-8971-4b2b-9279-494a5e684624.png)


## Sign up Screen
![Screenshot 2022-11-20 162253](https://user-images.githubusercontent.com/102357822/202905042-247c9728-9142-42eb-b972-b5ad363c0a39.png)


## Help Screen
![Screenshot 2022-11-20 162149](https://user-images.githubusercontent.com/102357822/202905056-7a6260c3-8a45-4d02-b3d0-dcbc489a4456.png)


## About Screen
![Screenshot 2022-11-20 162107](https://user-images.githubusercontent.com/102357822/202905050-9a1054aa-b72a-4946-8a73-403e02bdc3d7.png)


## Password Screen
![Screenshot 2022-11-20 162042](https://user-images.githubusercontent.com/102357822/202905069-a6bf79ee-046d-48f5-8572-0ee7810800db.png)


# Other Creator

- [Cihan Barış Turgut](https://github.com/CihanBarisTurgut)
