C# Övning 1 - Personalregister

Bakgrund
Ett litet företag i restaurangbranschen kontaktar dig för att utveckla ett litet
personalregister. De har endast två krav:
1. Registret skall kunna ta emot och lagra anställda med namn och lön. (via inmatning
i konsolen, inget krav på persistent lagring)
2. Programmet skall kunna skriva ut registret i en konsol.

Uppgift 1
Vilka klasser bör ingå i programmet?

	Klass Menu
	 - Metoder för att skriva ut meny och läsa in val från användaren.

	klass för Employee.
	 - id (int) - autoincrement
	 - namn (string)
	 - lön (double)
	 - get / set metoder för namn och lön
	 
	 Klass för Register
	  - Singelton
	  - Lista av employee
	  - Metoder för att lägga till och skriva ut employee

Uppgift 2
Vilka attribut och metoder bör ingå i dessa klasser?
Menu
	- Metod för att skriva ut meny
	- Loop för att visa menyn och läsa in val från användaren
	- switch sats för att skriva ut en lista av employees och läsa in nya employees.

Employee
	- Namn (string) - get/set
	- Lön (double) - get/set

Register
	- Lista av employee 
	- Metod för att lägga till employee
	- Metod för att skriva ut employee

Uppgift 3
Skriv programmet

Försök göra programmet så robust och framtidssäkert som möjligt!
Bonus för att implementera test! 