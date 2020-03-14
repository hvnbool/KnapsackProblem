# Knapsack Problem Solver
Knapsack Problem Solver is a Windows application for solving [Knapsack Problem](https://en.wikipedia.org/wiki/Knapsack_problem).
The algorithm used for solving the problem is based on [Branch and bound method](https://www.geeksforgeeks.org/0-1-knapsack-using-branch-and-bound/).

# Contents

# Getting started

## Requirements
> :warning: **Currently the application can be used only as a Visual Studio project.**

In order to use the application you need: 
*  Visual Studio 2015 or newer.
*  .NET Framework 4.6.1 or newer.

## Installation

1. In order to open the project locally in your Visual Studio, you need to use one for these methods:
    *  If on the GitHub page there is an "Open in Visual Studio" option, use it.  
    *  Download the project as a zip archive, unzip it and open the solution file in Visual Studio.
    *  Clone the project using Git commands and open cloned solution in Visual Studio.

2. Build the project using Visual Studio. Once the building is fished, launch the program.

# Usage
The main window of the program contains:
*  A field for the Quantity of available items (Note: not more than 40),
*  A field for the Knapsack capacity (natural number, units according to your task),
*  A table for the info about available items:
    *  Index - generated automatically, used for referring to the item in the answer.
    *  Weight - natural number, same units as Knapsack capacity - shows how much of the capacity it takes.
    *  Value - natural number, units according to your task - shows how important the item is.
*  A button "Get the answer!" to get the answer for given data.

**Note**: Quantity of available items is limited to 40. All input data is natural numbers, i.e. 1, 2, 3 and so on.

![alt text](https://github.com/hvnbool/KnapsackProblem/blob/master/img/Main%20window.png "Main Window")  

In order to get the answer, input your data into corresponding fields and press the "Get the answer!" button.  
This will open a new window with indices of Items for which total value is the highest while total weight does not exceed the Knapsack capacity.  

![alt text](https://github.com/hvnbool/KnapsackProblem/blob/master/img/Answer%20window.png "Answer Window")


# FAQ
Q: Why is the quantity of available items limited to 40 items?  
A: It may take a lot of time to calculate the result if there are many available items. Besides, it is a university task, so input data with a high quantity of available items is not expected.

Q: Why is the interface so inattractive?  
A: The program was implemented for our university task. The focus of the task was on the algorithm, not the GUI, so we did not spend much time on the interface.

# Troubleshooting
If any errors or bugs occur while you use the application, please create a Pull Request for them. 
