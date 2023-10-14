/*
####  Is the Die Loaded  ####

The Chi-Squared (χ²) goodness of fit test estimates if an empirical (observed) distribution fits a theoretical (expected) distribution within reasonable margins. For example, to figure out if a die is loaded you could roll it many times and note the results. Because of randomness, you can't expect to get the same frequency for all faces, but if one or more faces turn up much more frequently than some others, it is reasonable to assume the die is loaded.
The formula to calculate the Chi-Square parameter is:

Below is an example of a die rolled 600 times:

In this example, the Chi-Square parameter has a value of:
___
χ² = ((1)^2 + (16)^2 + (-11)^2 + (8)^2 + (-3)^2 + (-11)^2) / 100 = 5.72
_____

This parameter is then compared to a critical value, calculated taking into account the number of categories and the confidence level. Here, the critical value is 11.0705. Since 5.72 < 11.0705, it is safe to assume the die is unloaded.
Given a list with the six observed frequencies, write a function that returns true if a die is unloaded, or false if it is loaded. Take 11.0705 as the critical value for all cases.


[Examples]

___
FairDie([44, 52, 33, 40, 41, 30]) ➞ true
(χ² = 7.75) < 11.0705

FairDie([34, 27, 23, 20, 32, 28]) ➞ true
(χ² = 1.6) < 11.0705

FairDie([10, 20, 11, 5, 19, 16]) ➞ false
(χ² = 12.556) > 11.0705
_____



[Notes]

N/A


[math] [numbers] [validation] 



-------------------------------------------------------------------
[Resources]
_________
Math.pow() Method
https://docs.microsoft.com/en-us/dotnet/api/system.math.pow?view=net-5.0
Returns a specified number raised to the specified power.
_________

*/
//Your code should go here:

