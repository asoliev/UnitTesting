# UnitTesting
 
## The FizzBuzz Kata

* Write a program that prints the numbers from 1 to 100.
* But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz".
* For numbers which are multiples of both three and five print "FizzBuzz".

#### Steps:

Lets divide this into different steps so, we can easily write and test this.

* Print numbers from 1 to 100
* Print "Fizz" instead of number which is divisible by 3
* Print "Buzz" instead of number which is divisible by 5
* Print "FizzBuzz" instead of number which is divisible by both 3 and 5

#### Make more test for accept numbers and provide results

* Create a method to accept single number
* Create test to verify supplied number within the range 1 to 100
* Create test to verify number and return result Fizz or Buzz or FizzBuzz per above criteria



## OddEven Kata

#### Goal

Write a program that prints numbers within specified range lets say 1 to 100.
If number is odd print 'Odd' instead of the number.
If number is even print 'Even' instead of number.
Else print number [hint - if number is Prime].

#### Steps

Lets divide into following steps:
* Prints numbers from 1 to 100
* Print "Even" instead of number, if the number is even, means divisible by 2
* Print "Odd" instead of number, if the number is odd, means not divisible by 2 but not divisible by itself too [hint - it should not be Prime]
* Print number, if it does not meet above two conditions, means if number is Prime
* Make method to accept any number of range [currently  we have 1 to 100]
* Create a new method to check Odd/Even/Prime of a single supplied method



## PrimeComposite Kata

Write a program that prints numbers within specified range lets say 1 to 100.
If number is <em>prime</em> print 'prime' instead of the number.
If number is <em>composite</em> but not <em>even</em> print 'composite' instead of number.
Else print number.

### Steps

* Prints numbers from 1 to 100.
* Print "Prime" instead of number, if the number is prime, means <em>number greater than 1 that has no positive divisors other than 1 and itself</em>.
* Print "Composite" instead of number, if the number is composite, means <em>number has at least one positive divisor other than one or the number itself. In other words, a composite number is any integer greater than one that is not a prime number</em> but not a <em>even number</em>.
* An even number is <em>an integer is even if it is 'evenly divisible' by two</em>.
* Print number, if it does not meet above two conditions.
* Make method to accept any number of range [currently  we have 1 to 100].
* Create a new method to check Prime/Composite of a single supplied method.

#### Reference

* [Prime numbers](https://en.wikipedia.org/wiki/Prime_number)
* [Composite numbers](https://en.wikipedia.org/wiki/Composite_number)
* [odd even](https://en.wikipedia.org/wiki/Parity_(mathematics))
