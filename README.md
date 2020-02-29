# KnapsackProblem
This is a .NET Framework based Windows application for solving Knapsack Problem.

The algorithm used for solving the problem is based on [Branch and bound method](https://www.geeksforgeeks.org/0-1-knapsack-using-branch-and-bound/).

# Getting started

## Requirements
Since the application is poorly developed for deployment, currently it can be opened only as a Visual Studio project. For that you need to use Visual Studio 2015 or newer with installed .NET Framework 4.6.1 or newer.

## Installation

### Step 1
In order to open the project locally in your Visual Studio, you need to one for these:
*  Download the project, unzip it and open the solution file via Visual Studio.
*  Clone the project from the GitHub page or via Git commands.

### Step 2
Build the project using Visual Studio. Most likely the building will compelte successfully and you will be able to launch the program. If any problems occur, feel free to create a GitHub Issue.

# Usage
The main window of the program contains:
*  A field for the Quantity of available items,
*  A field for the Knapsack capacity,
*  A table for the Values and Weights of available Items (Items in the table are indexed so that they can be referenced in the answer),
*  A button to get the answer for given data.

In order to use the application get an answer, input your data into corresponding fields and press the Solve button.  
If the problem can be solved with given data, a new window will pop up. This window will contain indices of Items that have the highest total value while fitting into the Knapsack.


# Troubleshooting 
## FAQ
Q: Why is the quantity of available items limited to 40 items?  
A: It may take a lot of time to calculate the result if there are many available items. Besides, it is a university task, so input data with a high quantity of available items is not expected.

Q: Why the interface looks so inattractive?  
A: The program was implemented for our university task. The focus in the task was on the algorithm, not the GUI, so we weren't developing it much.

## Issues
If you face any errors or bugs while using the application, please create a GitHub Issue for them. 
