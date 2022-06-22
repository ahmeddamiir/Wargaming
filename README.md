# Wargaming
Wargaming's internship tasks

# Internship task - A

Recently we organized running competition for our developers. Everyone saw that James won. But nobody noticed who finished the run on second place. Fortunately, we have logs with names and positions. The problem is that there were thousands of runners and we need you to write a program that can find a runner-up for us.

**Input Format**

A single file having name and place on each line. Name is separated from place with semicolon. Be careful list can be very long.

**Output Format**

Name of runner-up

**Sample Input**

```vim
Peter Hass;3

Julia Tiny;4

Tomas Novak;2

Tina Bell;5

James Hall;1
```

**Sample Output**
```vim
Tomas Novak
```

**Explanation**

According to input file Tomas finished the run on second place therefore we print Tomas to the output.

**Finish the program:**

https://www.online-python.com/tR485F3HhA

```python
def findRunnerUp(file):
    print("Tomas Novak")

if __name__ == "__main__":
    f = open('input.txt')
    findRunnerUp(f)
```


# Internship task - B

Let’s play a game with numbers. You are given sequence of numbers 1...n and a number x = 3.
Every round you will remove from the sequence numbers that fulfils following two conditions:
1. number is divisible by x

2. number contains digit sum of x

To get digit sum of number x you keep summing single digits until you get single digit number. For example: digit_sum(56) => 5+6 = 11 => 1+1 = 2

Initial value of x = 3.
Amount of removed numbers will be your x for next round.
Game ends when you remove 0 numbers (x==0).

```vim
0. 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 	x = 3 
1. 1 2 _ 4 5 _ 7 8 _ 10 11 _ _ 14 _ 16 17 _ 19 20 		x = 7, digit_sum = 7
2. 1 2 _ 4 5 _ _ 8 _ 10 11 _ _ _ _ 16 _ _ 19 20 		x = 3, digit_sum = 3 
3. 1 2 _ 4 5 _ _ 8 _ 10 11 _ _ _ _ 16 _ _ 19 20 		x = 0
```

The game ended after 3 rounds.
Write a program that works for any n. Test it for n = 9999999.
After how many round this game will end?

Finish the program:

https://www.online-python.com/8TGyERdwps

```python
def play(n, x):
    print("3")

if __name__ == "__main__":
    play(n=20, x=3)
```


# Internship task – C

Our marketing wants to create a logo for our top-secret project. They decided to base the logo on the three most common characters in the project name. They are now trying out various combinations and asked our developer for help.

Given a string, which is the project name in lowercase letters, your task is to find the top three most common characters in the string.

* Print the three most common characters along with their occurrence count.

* Sort in descending order of occurrence count.

* If the occurrence count is the same, sort the characters in alphabetical order.

For example, according to the conditions described above, **Wargaming** would have the logo made from letters A, G, I.

**Input Format**

A single string name.

**Constraints**

* len(name) < 107

* has at least 3 distinct characters

**Output Format**

Print the three most common characters along with their occurrence count each on a separate line.  
Sort output in descending order of occurrence count.  
If the occurrence count is the same, sort the characters in alphabetical order.

**Sample Input**
```
ahhcccdde
```

**Sample Output**

```
c 3
d 2
h 2
```

**Explanation**

Here, c occurs 3 times. It is printed first.  
Both d and h occur 2 times. So, d is printed in the second line and h in the third line because d comes before h in the alphabet.

**Finish the program:**

https://www.online-python.com/zwHZgC3v5V

```python
def countIt(name):
    print("c 3")
    print("d 2")
    print("h 2")

if __name__ == "__main__":
    countIt(name="ahhcccdde")
```
