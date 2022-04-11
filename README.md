This is my solution for Deliverable 1 for the Grand Circus Full Stack C# .NET After-Hours Bootcamp, beginning April 11, 2022.

# Deliverable1 - Feed The Neighborhood

## Task
Write a program that calculates how many loaves of bread, jars of peanut butter, and jars of jelly are needed to feed X amount of people. Ask the user how many people are being fed, calculate the amount of ingredients needed, and then print the results out to the console.


### Build Specifications
- Each sandwich requires **2 slices of bread, 2 tablespoons of peanut butter, and 4 teaspoons of jelly**
- Assume 1 sandwich per person
- Assume 1 loaf of bread contains exactly **28 slices**
- Assume 1 jar of peanut butter contains exactly **32 tablespoons**
- Assume 1 jar of jelly contains exactly **48 teaspoons**
First, ask the user, “How many people are we making PB&J sandwiches for?” Expect the user to enter a number. You’ll need to parse the input and store it in a number variable.
You can now calculate the total amount of slices, tablespoons, and teaspoons needed. Print out these values to the console (see the console example below). 

Next, calculate how many loaves are needed. The formula is totalLoavesNeeded = totalSlicesNeeded / slicesPerLoaf. But since we can't buy partial loaves, round up the answer. For example, if 1.3 loaves are needed, we need to round that up and get 2 loaves. (Hint: search online how to round numbers up in C#.)
Do the same calculation for jars of peanut butter and jars of jelly. These also require rounding up.

Print out all three of these totals. (again, see the console example below)

After printing out all of the results, ask the user if they would like to start the program over. If yes, loop through the program again. If the user answers anything other than ‘y’ or “yes”, print "Goodbye" and exit the program.

### Console Output Example
`How many people are we making PB and J sandwiches for?`

`861`

`You need:`

    	1722 slices of bread
    	1722 tablespoons of peanut butter
    	3444 teaspoons of jelly

    	which is...

    	62 loaves of bread
    	54 jars of peanut butter
    	72 jars of jelly

`Would you like to restart? Enter yes or y to continue, or enter any other key to exit.`

`no`

`Goodbye!`

## Grading Criteria: 10 points total

- Ask the user to input a number and store that number in a variable. Assume the user will type a valid number.
- Total slices of bread is correctly calculated and printed to the console.
- Total tablespoons of peanut butter is correctly calculated and printed to the console.
- Total teaspoons of jelly is correctly calculated and printed to the console.
- Total amount of loaves is correctly calculated and printed to console (even if not correctly rounded).
- Total amount of peanut butter jars and jelly jars is correctly calculated and printed to console (even if not correctly rounded).
- All three amounts of loaves and jars are correctly rounded up.
- If the user responds ‘y’ to restart, loop back to the top of the program.
- If the user responds ‘yes’ to restart, loop back to the top of the program.
- If the user responds with anything else, print "Goodbye" and let the program end.
