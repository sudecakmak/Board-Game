# Board-Game
An oop project where user interaction and user data are collected in database.

## How to Play
If you have never registered, start by signed up. After signed up, you can start the game by entering your username and password.
From the menu option, you can change the game's settings(game size, game shapes...) and your user settings or you can access information about the game.
The game is played by bringing 5 shapes of the same color side by side and removing them from the game board. Select the shape you want to move and click on an empty area where you want to bring the shape. The game will end when there is no room left on the game board.

![z](https://user-images.githubusercontent.com/102357822/197343482-cfc722dc-e2a5-464d-912b-752c1d990824.png)

## Project Description

The system has pre-registered multiple users.
User types;
- Admin
- User

Default username and passwords are given below;
- admin/admin
- user/user

On the first screen (login), some components are required for username, password, and
log in.
- Username field entrance with only alphabetic characters: [A-Za-z].
- On startup, remembers the last successful login attempt’s username. If there is a
successful login, the username field filled by the last username.
- TThere is a button on the login screen to see the entered password as clear
text and vice versa.

The Password field shows the characters as ‘******’

The login button checks the entered information;
- If it fails, shows a warning message.
- If it passes, System hides the Login window and shows a new main game
window. 

Pressing the “Enter” key at the login screen has the same functionality as clicking on the
login button.

At the first run, the username field is focused.

Pressing the “Tab” key changes focus to the password field, next press focuses on login,
when no component is left, focuses on the username field again.

Sign up screen(window) to make users register;
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

Admin users manages other users by a manager screen(window);
- List all users
- Add a new user
- Update a user's information (except for the username)
- Delete a user permanently

All users have their profile screen to manage their user information except for the
username.

The main game window have a menu component to go to the Settings screen.

A difficulty level option is on the settings screen;
- Easy
- Normal
- Hard
- Custom (Custom options will gather 2 integer values to create the matrix for the game
board)

A shape option is required on the settings screen. Users need to be able to select one or
more of the;
- square
- triangle
- round 

A color option is required on the settings screen, and users need to be able to select 1 to 3
different colors;
- red
- blue
- green

The system saves all settings permanently when the user clicks the save button. On
the next run, saved settings remembered by the system.

About Screen;
- Game Name, Credits, Information about developers, Development date

Help Screen;
- Usage of the game
- Definition of the game components
- A button to see about screen

When the game starts, the game places a random colour and shape on three random
points (boxes) on the 9x9 board.
- The game forms a 9x9 chessboard when at the intermediate level.
- If the game level differs from intermediate, the game board adapts to the
level.

The user ables to select a shape placed on the game board and move it to the
desired point/empty box.
- The migration phase showns step-by-step by the program.

After the user makes move;
- If five same coloured and shaped boxes are side by side (vertically or
horizontally), these boxes (same shaped and coloured five boxes) will be emptied.

Give a point to the gamer.
- Custom Level: 2 points (?x?)
- Easy Level: 1 point (15x15)
- Intermediate Level: 3 points (9x9)
- Hard Level: 5 points (6x6)

The program will randomly fill three boxes with random colours and shapes and
wait for the user’s next move.

If there is no empty box to move, in other words, all boxes are filled, the
game is over and game will be scored.

If the user selects a different level, the game board recreated with new
dimensions.

The best score showns on the game board. The application stores user records
and selects the best score to show.

The delete operations shows a validation warning dialogue.

Admin needs to list users with their best scores and sort them by ascending or descending
scores.

When the user makes a move, game plays a sound for each step.
- At the end of the steps, if the user takes a score point, game plays a  different sound

Created a database to store all user data(name, password, scores etc. (not settings)).
