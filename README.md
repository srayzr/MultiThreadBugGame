MultiThread Bug Game - C# Forms
This is a multithreaded bug game implemented in C# Forms. The objective of the game is to make bugs (represented by buttons) move towards a target location. This README file provides an overview of the game, instructions on how to run it, and an explanation of the code structure.

Game Description
The multithread bug game consists of bugs represented by buttons on a form. The bugs start from an initial position and need to move towards a target location. The movement is achieved using multithreading, where each bug has its own thread responsible for updating its position.

Prerequisites
To run this game, you need to have the following installed:

.NET Framework (version 4.5 or higher)
Visual Studio (or any C# compiler)
Getting Started
Clone this repository to your local machine or download it as a ZIP file and extract it.
bash
Copy code
git clone https://github.com/gbuniatyan/MultiThreadBugGame.git
Open the solution file (MultiThreadBugGame.sln) using Visual Studio or your preferred C# IDE.
Build the solution to ensure all dependencies are resolved and the project is compiled successfully.
Run the game by pressing the "Start" button or by hitting the "F5" key.

How to Play
Once the game is launched, you will see bugs (represented by buttons) at the initial positions on the form.
Click the "Start" button to initiate the movement of bugs towards the target location.
The bugs will start moving towards the target in a multithreaded manner. Each bug has its own thread responsible for updating its position.
The movement is done by gradually updating the position of each bug using a series of steps.
The bugs move horizontally towards the target location. The target location is represented by a specific X-coordinate value (targetX).
The bugs' movement is randomized using a random delay (between steps) to simulate varying speeds.
Once a bug reaches or surpasses the target location (targetX), it is considered the winner.
The game displays the winner's name on the label (label1) and stops all the bug threads.
You can reset the game at any time by clicking the "Start" button again.

Code Structure
The code provided consists of a Form class (Form1) that handles the game logic. Here's an overview of the main methods and their responsibilities:
ChangePlaceBtn(), ChangePlaceBtn1(), ChangePlaceBtn2(): These methods are called to update the positions of the bugs (buttons) to their initial locations.
Button4_Click(): This method is triggered when the "Start" button is clicked. It initializes the threads for each bug and starts their movement.
MoveButton(Button button, int targetX, int targetY): This method represents the movement logic for each bug. It calculates the step size for both X and Y coordinates based on the target location and updates the button's position gradually.
CheckWinner(): This method checks if any bug has reached or surpassed the target location. If a bug reaches the target, it updates the label (label1) with the winner's name, sets the winnerFound flag, and stops all bug threads.

Additional Notes
The game uses multithreading to achieve concurrent movement of bugs. Each bug has its own thread responsible for updating its position.
The game provides a basic graphical representation of bugs using C# Forms. You can modify the UI, add more bugs, or enhance the game's features as per your requirements.
This game serves as a simple example to demonstrate the concept of multithreading in C# Forms.

Acknowledgments
Feel free to modify, enhance, or distribute this game as per the terms of the MIT License. 
Contributions are welcome, and I encourage you to submit pull requests if you have any improvements to suggest. Enjoy the game!
