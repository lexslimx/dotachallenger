 dotachallenger
A simple Dota profile and recent matches viewer.  Later on we'll have the ability to send friends in-game challenges to complete in timed periods and rank friends who complete the challenges for some competitive fun.

To Do
1. Create a simple dota app to view a player's profile with basic stats like k/d wins , losses and match history. 
2. create a GUI (web or desktop) interface to view the data. 
3. Create challenges for players that will be viewable on the app e.g (get 10 kills in a game )
4. Invite players to the app to complete challenges while playing dota.
5. Create a leaderboard for the challenges


Resources:
1. Dota's Open data API hosted at: https://docs.opendota.com/
2. You'll need your steamid later, get it from this tool: https://steamid.xyz/77735678
    Use the entry marked Steam32 ID.
    You must set your steam appunt to public for this to be visible
3. Api syntax 
    https://api.opendota.com/api/players/{accountid}   (try this in your browser first)

Things we'll learn
1. C# program flow
2. C# variable operators and data types
3. Objects - Classes and Interfaces
4. Http Communication in C#
5. Github - Commits, Pulls, Version Control


To Run The code:
1. Clone this repo to a folder on you pc
2. Open the folder using vscode
3. Bring up the terminal in vs code (Ctrl+~)
4. Build the project using dotnet build
5. Ensure the project builds successfully

ROADMAP

Chapter 1:
1. Methods - creating methods, returning values, void methods
2. Interfaces
3. Json formatting - scerializing, descerializing - NewtonSoft Library
4. Http Communication (System.net)

Chapter 2:
1. Get Player data
2. Get A player's recent games - Introduce arrays and lists
3. Calculate basic palyer stats k/d , win rate e.t.c base on the last n games
4. Get Multiple Players and their recent games

Chapter 3: Refactoring
1. Best practices - code organization
2. Core-reuse
3. Dependency injection (maybe)

Chapter 3 (USER INTERFACES):
1. Html syntax, styling and hosting
2. Bootstrap
3. JavaScript

Chapter 4.
1. Web API
2. Electron
3. UI Design/Prototyping with Adobe XD
