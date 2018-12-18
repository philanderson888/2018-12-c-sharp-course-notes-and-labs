# C# #

## What this repository includes

* C# Course Notes

* C# Course Labs

## Visual Studio

.NET

	First Windows computers --> Library is called .NET

		code can reference other code

			.exe 		application
			.dll		library (dynamic link library)

		Compile C# ==> either .exe or .dll

		Let's have a look !!

				C:\Windows\System32\

	What language is used??

		C original language  ((Windows + Linux + Unix))

			C++ today 

		Also be aware in same 'family'

			C#
			VB
			F#  (functional programming : immutable objects)


	Raw code			CIL 				CLR
						Common 
						Intermediate
						Language
						(half-way house)

	  C,C++,C# 			view this code 			Compiled 'runtime'
	  VB, F#			with tool ILDASM	code optimised for
	  										your architecture


.NET 4.7GB huge!!!

	Not compatible with Mac, Linux etc

	((Visual Studio for MAC))

	Open source now!!!

.NET CORE

	Stripped down version

		Run on any platform

IDE
	VSCode



Structure of application

	Solution .sln  : container for projects

		Project .csproj    build working code

			.cs   (text file)


Running application

	Two modes

		DEBUG		F5

		RELEASE		CONTROL + F5

	Permanently switch the build --> choose Build, Configuration manager


Referencing other libraries

	In your project we can reference other code!

		1) References, Add ==> Choose Libary
		2) using System.Data.EntityClient at top of code


Build own DLL library file!!!

	New Project ==> Library
	Create a PUBLIC CLASS WITH A PUBLIC FIELD
	Build => Compile to DLL

	We can now REFERENCE THIS PROJECT in another project!!!


Namespace

	Just a container for our code - NO FUNCTIONALITY!!!

	useful to keep naming under control with different projects

Main()

	Run application - this method gets called first

Main(string[] args)

	Argument ==> data which we PASS IN TO METHOD

	string[] array of strings

		[0] = ".."

	Display this at work!!!

	





OOP

Scripting

	First computers : ran code from top to bottom

	'Scripting'
.bat

.ps1

Linux BASH script

.bat
	echo 'hello world'
	create folder
				MKDIR
				MD
	move into folder 	CD
	create file
				TOUCH
				NANO MYFILE.TXT
				NOTEPAD MYFILE.TXT
				copy nul myfile.txt
	rename
		REN
		MV (linux)
	Put content in file
		CREATE OUTPUT > myfile.txt    OVERWRITE
			      >> myfile.txt   APPEND
	list processes and put them in file
		tasklist


Powershell .ps1

	Set-ExecutionPolicy unrestricted

Task 1 : batch file (above)

Task 2 : Powershell : impress me!!


Linux BASH : done!!!

OOP

	Object Oriented Programming

	GUI
		Click
		Type
		Hover
				on button, input field etc

		object has a 'listener' to listen for events

			click event
			keypress event

		'handler' = one or more methods to run

			onclick() handler

				handler +=  method

		OOP : code attached to OBJECT 

			easy to keep track of all code
			what it's doing 

Objects

Manually creating objects in C#


            Object object01 = new
            {
                name = "phil",
                age = 22
            };

            Console.WriteLine(object01);

Second way (similar to Javascript)

	'dynamic'  means DON'T FIX DATA TYPE!

	
            Object object01 = new
            {
                name = "phil",
                age = 22
            };

            Console.WriteLine(object01);


            dynamic object02 = new ExpandoObject();
            object02.name = "phil";
            object02.age = 22;
            Console.WriteLine(object02.name);


Classes

	Access Modifier
		default = private  visible in this class
		public		visible to any class
		protected	visible to this class and 
				child derived classes
		internal	compile code (to exe)
				visible from anywhere in
				that .exe !!!  (Assembly)
		protected internal = both above 




	


namespace Lab_05_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.age = 22;
            p.name = "Fred";
            Console.WriteLine(p.getCousins());
            p.setCousins(5);
            Console.WriteLine(p.getCousins());

            Child c = new Child();
            c.age = 1;
        }
    }
    class Parent {
        // field
        public int age = 0;
        // property get;set;
        public string name { get; set; }
        private int _numberOfCousins;
        // method
        public int getCousins()        {            return this._numberOfCousins;        }
        public void setCousins(int x)
        {
            if (x > 0)
            {
                this._numberOfCousins = x;
            }

        }
        // property expanded code
        public string employment
        {
            get
            {
                return this.employment;
            }
            set
            {
                this.employment = value;
            }
        }
    }

    class Child : Parent {

    }	


Methods

	Naming Convention

		variables camelCase
		Classes	NounWithCapitalLetter(PascalCase)
		Methods VerbPascalCase 

	Create a method in 3 places

	1) inside same method!
	2) inside same class as STATIC METHOD 
			(ATTACHED TO CLASS)

		'static' keyword 
		static void DoThis(){}

		Refer with ClassName.MethodName()

	3) inside another class as INSTANCE METHOD
			(ATTACHED TO INSTANCE)

Overloading methods

	DoThis()
	DoThis(int x)
	DoThis(string y)

Default values

	         // set default values
        public void DoThisAlso(int x = 5, string y = "hello"){
            Console.WriteLine("x is {0} and y is {1}",x,y);
        }

Out Parameters

	May be wish to return more than one parameter

		MyMethod(out int x)
	
OOP

	Abstract Class

		These are common.  Think of them as 
			incomplete classes.

			(great idea for holiday, one or
				two ideas but not full 
				picture)

		Abstract class has INCOMPLETE CODE!!!

			One or more ABSTRACT METHODS

			 abstract GreatIdea();


    abstract class HolidayPlans
    {
        // OK
        void DoThis() { // CODE HERE EG VISIT VENICE
        }

        // INCOMPLETE TRAVEL PLANS
        public abstract void Travel();

    }

    class HolidayPlansComplete : HolidayPlans
    {
        public override void Travel()
        {
           // code here travel plans - COMPLETE!!!
        }


Sealed Class


    class Mercedes { }

    class SClass : Mercedes { }

    class SLS : SClass { }

    // DON'T CHANGE ANY FURTHER
    sealed class SLSSport : SLS { }

    class enthusiasticEngineer : SLS { }		


T
PolyMorphism
	Poly : many
	Morph : Type

	Think about Parent with 3 children

		Bob dad

		Rob

		Sue

		John

	Method : HaveAParty
		Bob : 
		Rob(18)
		Sue(6)





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12a_Polymorphism
{
    class Program
    {
        static void Main()
        {
            Parent p = new Parent();
            p.HaveAParty();
            Child Bobby = new Child();
            Bobby.HaveAParty();
            Teenager Rob = new Teenager();
            Rob.HaveAParty();
        }
    }


    class Parent {
        // parent IMPLEMENTATION
        // VIRTUAL MEANS 'can override'
        internal virtual void HaveAParty() {
            Console.WriteLine("having a dinner party!");
        }
    }
    class Child : Parent {
        internal override void HaveAParty()
        {
            Console.WriteLine("Child is having a party");
        }
    }
    class Teenager : Parent
    {
        internal override void HaveAParty()
        {
            Console.WriteLine("Teenager is having a party");
            base.HaveAParty();
        }
    }

}



Interfaces

	Classes can ONLY HAVE ONE PARENT

	class Child : Parent{}      // ONE PARENT ONLY

	If we want to use other code we can 'implement' other code like this:


	Declare structure : Interface

	Interface IDoThis{}		C# : Prefix with I : convention
		
		eg IDisposable		Manually dispose of object
		   IEnumerable          Enumerate : count : eg Array
		   IQueryable           LINQ query : response from database
	
	What does this mean for us???

	Interface IMustDoThis{    // declare	
		// one or more fully abstract methods
		// all implied public
		// all implied abstract
		void GottaDoThis();
		void AlsoGottaDoThis();
	}            


	class MyClass : IMustDoThis          // class must IMPLEMENT (USE) 
					     // interface and all its methods


Summary 

	Interfaces are FULLY ABSTRACT (no code whatsoever) - all METHODS ARE ABSTRACT  

	Abstract class can have combination of REAL METHODS and ABSTRACT METHODS


	Polymorphism : Parent class has 'virtual' keyword

			Child class has (optional) override keyword























Data types

	Signed integer

		32 bits

			31 bits for data
			1 bit for +/- sign

	Unsigned

		uint  full 32 bits 

... to be continued





LINQ

	Let's have a look at databases

	Northwind ==> Install via SQL script

	Project ==> Add ==> ADO.NET Entity Data Model to project

		Create classes for us eg Customer class

			Partial class : MANUALLY EXTEND THIS CLASS TO SUIT

	LINQ QUERY

		var customers = 
				FROM c in DBContext.customers
				SELECT c

			var : type : IQUERYABLE / IENUMERABLE

		var customers = ...
				FROM..
				where c.city="berlin"
				Select c	



Using Lambda Expressions to help create database queries

	var singleCustomer = DBContext.Customers.First(c => c.Country == "Finland");


Update single customer

	singleCustomer.ContactName += "Fred"

	DBContext.SaveChanges();


Project Pseudocode

	GRID 3X3
		Top 2 rows : Button : refresh from database
			     Text boxes : for input eg City
		Bottom columns
			1) TextBlock
			2) ListBox with STRINGS eg Customer.ContactName lives in ...City
			3) ListBox bound to a field
				ListBox.itemsSource = <<linq output variable>>


















Review
Debugging 
Conditional Debugging
Step Over Line By Line F10
Step INTO Deeper methods
Compile code
.NET
C++
VB
F#
C#
C
Compile to half-way-house  CIL Common Intermediate Language
ILDASM Intermediate Language Disassembler 
CLR Commion language runtime
methods : function  PascalCase
Javascript   camelCase
Website page-like-this.html
SQL field_here
Method Verb
Class Noun#
field lowerCase
private _lowerCase
Abstract class contains ONE Abstract Method
Abstract Method   public abstract void DoThis();
      (Child class : must add override keyword)
void DoThis(){}
Reference library
Abstract class : Derive (get child class) ==> fill in all code ==> Concrete Class
Abstract class : CANNOT INSANTIATE!!
Concrete class : CAN INSTANTIATE
Methods 
	call in same Method!!!
	in same Class (use 'static' keyword)
	in another Class : instance method
			p.DoThis();
static
	fields Math.PI

Revision
Interfaces
	FORCE BEHAVIOUR
		IComparable : forces COMPARISON
			strings ==> sort 
			Must have CompareTo() method which permits 2 inputs and output 1, 0, -1
					if bigger/same/smaller  (first compared to second)
	FULLY ABSTRACT (NO CODE)
		PROPERTIES/MEHODS : FULLY PUBLIC 

	You can implement MANY INTERFACES

Abstract Class
		
	Applied as a parent
	
		Contain
			FIELDS  int x;
			PROPERTIES int y{get;set;}
			METHODS  DoThis(){}

		Either
			ABSTRACT eg Methods with no body
			REAL eg Methods with body
	Inherit from this class
			REAL : can ignore (inherit)
			ABSTRACT : empty : MUST CODE THEM OUT	

	Code read:
		 abstract void DoThis(); 				PARENT
		 override void DoThis(){  // code here }		CHILD
Polymorphism
	Parent 	virtual keyword				public virtual void DoThis(){}
	Child - override keyword on method		public override/new void DoThis(){}












== Tuesday 18 December review ==

Entity 
Northwind
DBContext object
LINQ
	from c in customers
	where c.city == textbox01.text
	groupby
	orderby
	
	select c

	select new { firstname=c.Forename, lastname=c.LastName  }
Foreach (customer c in DBContext.customers) ...

// select one record
Lambda to select eg First(c => c.City=="Berlin")

// Listbox : bind with Listbox01.itemSource = DBContext.Customer.ToList<Customer>();

Listbox01.displaymemberpath="city"  GUI
// display more than one : XML construct  *******************

Binding property as well 

CRUD 

Filtering : onkeypress ie filter on each keystroke (bonus) ....

OOP
Class : blueprint / template which is used to create (instantiate) REAL OBJECTS

	Class Dog{
		public string name;
		public int height;
		// constructor method
		Public Dog(string name, int height){
			this.name=name;
			this.height=height;
		}
	}
	
	Dog Fido = new Dog("fido",22);

Methods : functions
	PascalCase and 
	Verbs DoThis()  Accelerate()

Class : Noun, Pascal ie Class Dog, Class Engine

Field
	private string _internalField;

Property
	public string externalProperty {get;set;}

	get{
		return this._internalField;
	}

	set{
		this._internalField=value;	
	}

Events
	
Class Parent {}
Class Child : Parent {}

Sealed class Child {}  // cannot derive a grandchild object from this

Abstract class GrandParent {
	DoThis(){  // code goes here (code body) }  // regular method
	public abstract void DoThat();  // abstract method
	}

	class Parent : GrandParent{
		// inherit DoThis().... ( ignore here)
		public override void DoThat(){ // code here }
	}

Polymorphism
	Parent : keyword 
	Child : keyword 




Class MyClass{
	public static void DoThisNow(){}  // class method
	public void DoThisAlso(){}        // instance method
}

	...Main(){
		// calling static methods/props
		MyClass.DoThisNow();
		Math.Random();
		Math.PI;
		// call class method
		// instantiate
		var instance01 = new MyClass();
		instance01.DoThisAlso();
		
	}

overloading  : SAME NAME, DIFFERENT PARAMETERS
	DoThis();
	DoThis(10);
	DoThis(10,20);
	DoThis("hi");
override : SAME METHOD : DIFFERENT CODE BODY
	Parent : virtual
	Child : override
.base() from Child

Interface
	IComparable
		


    class Real : Child, IComparable
    {
        public int CompareTo(object real)
        {
            return 1;
        }
    }


Interface	FULLY PUBLIC, FULLY ABSTRACT (NO REAL CODE)
		Child : must override

Abstract	Class contains 1 or more ABSTRACT METHOD
		abstract method has NO CODE!!!
		child : must override

Polymorphism	Parent : virtual
		Child : optional override / new 


== end of Tuesday 18 December review ==

