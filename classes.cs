
/*
int - stores integers (whole numbers), without decimals, such as 123 or -123
double - stores floating point numbers, with decimals, such as 19.99 or -19.99
string - stores text, such as "Hello World". String values are surrounded by double quotes
bool - stores values with two states: true or false
*/


public bool a = false;

public class ConsoleClass {

    // field variable
    public int b;

    // member function or method
    public void display(string something, int number) {
        
        Console.WriteLine(something + " number: " + number);
        
    }
    
}

ConsoleClass console = new Console();

console.display("hello", 5); // > hello number: 5



// C# program to illustrate
// inheritance

class person {

	public string name;
	public int height;
  public int weight;
  public string job;
  
  // Constructor
  public person(int personName) {
    
    this.name = personName;
    
    Console.writeLine("I'm alive! My name is " + personName);
    
  }

	public void walk(string to) {
    
    // ~~~

	}

  public void eat(string food) {
    
    // ~~~

	}

}

class oldPerson : person {
  
  public string wrinkles;
  
  public void takeMedicine(string medicineName) {
    
    // ~~~

	}

}


Person father = new person("Kosta"); // > I'm alive! My name is Kosta


oldPerson grandpa = new oldPerson();

father.walk();
grandpa.walk();

gandpa.takeMedicine();

