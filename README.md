# 🦖 T-Rex Runner Game

A classic side-scrolling endless runner game built with Windows Forms (C#), inspired by the hidden Chrome Dinosaur Game.  
This project includes user authentication, difficulty levels, score tracking, and a high-score leaderboard.


##  Features

- User Authentication: Secure login system with encrypted password storage  
- Customizable Difficulty: Three difficulty levels (Easy, Medium, Hard) that affect obstacle speed and scoring  
- Real-time Gameplay: Smooth jumping mechanics and randomly generated obstacles  
- Score & Leaderboard: Tracks top 3 high scores with player names  
- Password Management: Allows users to change passwords with validation  
- Responsive UI: Interactive buttons with hover effects and clear navigation  


##  Prerequisites

- .NET Framework: 4.7.2 or later  
- IDE: Visual Studio 2019 or later (recommended)  
- OS: Windows 10 / 11  


##  Installation

### 1. Clone the repository

    git clone https://github.com/FongFus/T-Rex-Runner.git
    cd T-Rex-Runner

### 2. Open the project

Open `BTL_WindowsForms.sln` in Visual Studio.

### 3. Build the project

Press `Ctrl + Shift + B` or use the **Build** menu.

### 4. Run the game

Press `F5` to start debugging.


##  Quick Start

### Launch

- Run the game  
- Log in using the default credentials (stored in `account.txt`)

### Main Menu

- **Start** – Play the game  
- **Level** – Adjust difficulty  
- **Record** – View high scores  
- **Account** – Change your password  

### In-game Controls

- **Spacebar** – Jump  
- **Avoid obstacles** to score points  
- **R** – Restart after game over  

If you achieve a high score, you will be prompted to enter your name for the leaderboard.


##  Project Structure

    T-Rex-Runner/
    │
    ├── Forms/
    │   ├── Login_39_Phu.cs           # Login screen
    │   ├── Form1_39_Phu.cs          # Main menu
    │   ├── PlayGame_39_Phu.cs       # Gameplay form
    │   ├── Level_39_Phu.cs          # Difficulty selection
    │   ├── Record_39_Phu.cs         # Leaderboard view
    │   ├── Account_39_Phu.cs        # Password change
    │   └── SubRecord_39_Phu.cs      # High-score entry
    │
    ├── Data/
    │   ├── account.txt              # User credentials
    │   ├── level.txt                # Stored difficulty setting
    │   └── record.txt               # High-score records
    │
    └── Resources/                   # Game images (T-Rex, obstacles, etc.)


##  Game Logic Overview

- **Jump Mechanics**: Uses force and gravity simulation for smooth jumps  
- **Obstacle Generation**: Randomly spawned with speed increasing based on score and difficulty  
- **Scoring**: Points increase when obstacles are passed; higher difficulty gives bonus points  
- **Collision Detection**: Uses `Bounds.IntersectsWith()` for hit detection  
- **Leaderboard**: Stores only the top 3 scores, sorted in descending order  




##  Author

Nguyễn Phong Phú  
Student ID: 2251050057  
Course: GUI Programming  
University: Ho Chi Minh City Open University  


##  Acknowledgments

- Inspired by the Chrome Dinosaur Game  
- Built as a semester project for GUI Programming
