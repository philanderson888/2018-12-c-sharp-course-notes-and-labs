# C# #

These are the notes included from teaching a course in C# over a few days.  The notes are not very complete and were not originally intended for use on GitHub as a README, so the formatting may not be Markdown but just plain text in places.  Enjoy!

## What this repository includes

* [C# Course Notes](#visual-studio)

* [Trainer Prep Notes](#trainer-prep-notes)

* [C# Course Labs](/Labs)

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




	

```csharp
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
```

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

```csharp
	         // set default values
        public void DoThisAlso(int x = 5, string y = "hello"){
            Console.WriteLine("x is {0} and y is {1}",x,y);
        }
```

Out Parameters

	May be wish to return more than one parameter

```csharp
		MyMethod(out int x)
```

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

```csharp
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
```

### Sealed Class

```csharp
    class Mercedes { }

    class SClass : Mercedes { }

    class SLS : SClass { }

    // DON'T CHANGE ANY FURTHER
    sealed class SLSSport : SLS { }

    class enthusiasticEngineer : SLS { }		
```


## PolyMorphism

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




```charp
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
```


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







## Trainer Prep Notes

Below are a second copy of the notes above which include more detail and some topics not covered in the teaching.

They are in plain text format so not formatted for Markdown

<pre>

Resources

	98-361 easier   
	70-483 this (harder)

		Microsoft : Video Libraries of courses

	LINQPad : download : code snippets
	

Brainstorm 
function ==> Method  
Method   MyMethod01   Pascal Case
javascript  myFunction01   camelCase
CSC C Sharp Compiler
csc  myCSharpCode.cs    ==> run this & can output
	1) exe  application
	2) dll Dynamic Link Library  (contain classes etc to reference in your project)
		c:\Windows\System32\filled_with_DLL.
Visual Studio
	1) SOLUTION  .sln  UMBRELLA 
		
	2) PROJECTS .csproj   UMBRELLA FOR 1 PROJECT
	
		1 Solution contains 1 or more projects

Javascript : weakly typed  (types inferred at runtime)
C# : Strongly typed ==> types are known at compile time
Initialise int x = 10;
Initialise var x = 5.0;
'dynamic' keyword can apply to a data type ==>type is not inferred until runtime 
Strongly typed ==> types worked out at compile time ==> runtime environment is fast/clean
OOP Object Oriented : events attached to objects to drive code and structure.
Scripting language ==> top down
Types of VS Project
Console 
	.NET framework  MONOLITHIC (huge)
	.NET Core ==> 
Web
	MVC Model View Controller : structure the folders in a web app
		Model : DB
		View : GUI
		Controller : interface between
	ASP.NET Web Forms
		Active Server Pages
	ASPX 	XML equivalent
		<asp:...wrapper  runat="server">
			<table>...</table> (HTML)
		</asp>
		C# code-behind as well
	Azure
	
Windows
	Windows Form App   (older)
	WPF Windows Presentation Foundation  
		build apps in XML  (XAML)
	UWP Universal Windows Platform (mobile/phone)
		((Windows Store App))
Mobile
	Xamarin ==> IOS/Android

Cloud
	1	AWS Amazon Web Services
	2	Azure  Microsoft cloud services
	3	Google
	
Azure
	HOST web application online
	HOST database online (good test/production)
		((can do from local Visual Studio))
	Virtual Win10/Server16 with VS installed
		DEV : nightly shutdown 

OLEDB : Traditional DB access model 
LINQ => (Microsoft) QUERY DB
Entity (EF Entity Framework)  
	Code first
	Database first
		=> either : auto-'scaffold' your C# 
			code or DB
	EG : Create DB : Entity => New Project ==> 
		auto-create classes in project from DB






Visual Studio

	.sln SOLUTION
	.csproj PROJECT
		program.cs
			using System;
			myNamespace{
				void Main(args[]){
					//code
				}
			}
	
	.NET


	HIGH LEVEL	CIL		LOW LEVEL
			COMMON
			INTERMEDIATE
			LANGUAGE

	C# F# C++ VB	compiled code	  running code
			static code	   CLR
			ILDASM		   common 
			(inspect)	   language
					   runtime

					((optimise code
					for platform))

	Compiled unit of code

		"Assembly"  (standalone unit)

			WINDOWS EXE
			ANDROID APK
			IOS     APP

	
	(( VS command line tools ))

		
OOP

	Object oriented programming uses 'classes' 	
	as templates from which to create real objects

	REAL WORLD
	
	building plans		>>   construct building

	class (blueprint)	>>   objects

	mammal (generic)	>>   instance object
				       (dog, cat etc)
		warm blooded
		babies	



Class


	field		public int x;
			note : no control so often use for private fields
			(encapsulation = hidden code)

	method		function : action code
	

		<<RETURN TYPE>> MyMethod(param1,param2)	

		void/int/string


	property	like a field but allows get; and set; to 
			control what people can do (read/write etc)

			public int x { get; }   // read only
                                     { get; set; }  //  r/w


Access modifiers : public, private, internal, protected

	internal : visible inside ASSEMBLY (EXE or DLL)

	protected : visible inside PARENT (BASE) AND ALL 
						CHILD (DERIVED) CLASS




Inheritance

	Class Mammal {	
		public string name;
		}

	Class Dog : Mammal {
		
	}       // inherits from 


		Dog will also have a name field


Constructors

	Class myClass{

		private int x;             // PROPERTIES
		private string y;
		public double z;

		public myClass(int a, string b, double b){ // constructor
			this.x = a;
			this.y = b;
			this.z = c;
		}

		public myClass(){}  // default

		~myClass(){}      // destructor / finalizer code when
					// object removed from memory

	}

	Create object with 
		myClass instance01 = new myClass(10,"hi", 4.567)

	


Constructor in child class

	In the child we can either
		a) Create custom constructor
		b) Invoke base class constructor
			public myChildClass : base(param1/2/3/)



Sealed Class

	Parent 

		sealed Child

			Don't now want any GrandChild classes to be created
			from our child


Polymorphism

	poly = many
	morph = type

		Polymorphism : same METHOD NAME but different EXECUTION
			CODE IN PARENT OR CHILD

	class Parent 

		public virtual void myMethod(){}


	class Child	

		public override/new void myMethod(){}


        static void Main(string[] args)
        {
            Parent p01 = new Parent();
            Child1 c01 = new Child1();
            Child2 c02 = new Child2();
            p01.HaveAParty();
            c01.HaveAParty();
        }
    }

    class Parent {
        public virtual void HaveAParty() { 
            Console.WriteLine("Parental posh dinner party");
        }
    }

    class Child1 : Parent {
        public override void HaveAParty()       {
            Console.WriteLine("Child fun time bouncy castle");
        }
    }

    class Child2 : Parent { }





Abstract class

	Great idea !!!   (missing details !!! (work out details later))

	Abstract class contain ONE OR MORE ABSTRACT METHODS

		Abstract method has NO CODE BODY  (IE NO CODE BRACES)

	
	class Polygon

		abstract GetArea();		ABSTRACT METHOD PARENT


	class Square : Polygon

		override GetArea()		OVERRIDE METHOD CHILD
		


Summary

	Class : blueprint

		Instantiate : create OBJECT FROM CLASS using NEW

	Sealed : no derived child classes

	Polymorphism : VIRTUAL marking PARENT METHOD
	 	       OVERRIDE        CHILD METHOD

	Abstract : 1 or more ABSTRACT METHODS
		   CAN HAVE NON-ABSTRACT METHODS

Inheritance

	Parent

		Child

			Child can only inherit from ONE PARENT


Interfaces

	Interfaces are fully PUBLIC
	Contain only members which are FULLY ABSTRACT !!!

		properties
		methods

			Also fully PUBLIC and ABSTRACT 

Using Interfaces

	Use them to create an environment where we know to expect a
	certain behaviour

	IEnumerable	Array : count over elements  GetNext()

	IQueryable	LINQ query output  : returns only subset of data
			needed

	IDisposable	Explicitly call Dispose() method when getting rid
			of (Finalize)

	IComparable	Sorting lists : must have way of comparison

				if (stringa>stringb)	 BOOLEAN

			CompareTo() method : states how compare!!!

				stringA.CompareTo(stringB)
					-1	A<B
					0	SAME
					1	A>B




Crazy 10 minute bucket list!!!
	From Scratch lab 10 : review
	PARENT/CHILD
		VIRTUAL/OVERRIDE METHOD
	SEALED
	ABSTRACT
	
	

Methods

	Optional parameters

		MyMethod01(int x, string y="default value")	

			!!! mandatory params FIRST !!!

	Out parameters
	
		string MyMethod(int x, out bool y){
			y = false;
			return "hi"
		}

	Named parameters

		Used when calling method (not declaring it)

		MyMethod01(int x, bool y, string z){}

		call with

		MyMethod01(10,true,"hi")   REGULAR CALL : ORDER CRITICAL
		MyMethod01(z:"hi",x:10,y:true)  CAN BE ANY ORDER
		MyMethod01(10,z:"hi",y:true)





Data types

	INT is 32 bit

		1 bit for +/-

		31 bits for actual number





            const int x = 12;
            // x = 13;

            // SIGN +/-

            int num01 = 22;
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            uint num02 = 23;
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);

            // byte
            // 8 bits
            byte byte01 = 12;
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            byte byte02 = 0xff;  // ff  1111  1111 
            // buffer
            byte[] myBuffer01 = new byte[100];

            //  var x = 0b11111111;  // binary literal
            // int x = 100_000_000;
            // int x = 0b_1111_1111; 

            // Tick is a timespan of 10-7 seconds long
            var date01 = new DateTime();
            var date02 = DateTime.Now;  // WITH TIME
            var date03 = DateTime.Today;  // MIDNIGHT

            var date04 = date03.AddDays(5);

            var timespan01 = new TimeSpan(1);
            var timespan02 = new TimeSpan(date04.Ticks - date03.Ticks);



Reference and Value types

	Two types of computer memory

		STACK         

			FAST, IMMEDIATE PART OF MEMORY
		
				RUNNING CODE LIVES HERE  ALSO 
				    int,bool, char, byte, struct ((VALUE TYPES)
							     ((PRIMITIVES))


				k=20,l=3000             
				Array01[..<<content not stored here>>..]
				Method02()
				i=10, j=12, b=false
				Method01()
				MAIN()
				=================bottom of stack==========

		HEAP

			SLOWER, LARGER DATA STRUCTURES  (( REFERENCE TYPE ))

			Array01[10,20,30]


	Must remember!!
		Copy a VALUE TYPE (stack) then create fresh instance
			x=10
			copy => y=10 (new instance)

		Copy a REFERENCE TYPE : just creating new shortcut to same item
			


Strings

	Note : strings are COMPLEX OBJECTS BECAUSE THEY STORE DATA AS 

		ARRAY OF CHARACTERS

		string x = "hello"   

			char[] array   [h,e,l,l,o]

			x[3] ==> l

	Strings are IMMUTABLE

		IMMUTABLE ==> CANNOT CHANGE

		x = "hello";     ==> GET RID OF THIS ONE 
		x = "goodbye";   ==> NEW OBJECT CREATED


Structs

	Structs are like classes, just very simple though

	Members are PUBLIC

	If add constructor, keep default one also

	Treated as VALUE TYPE IE FAST, STORED ON STACK!!!

	Good for storing very small objects eg data points on graph
		
		

            // CREATE 2 POINTS
            Point p01 = new Point(); // DEFAULT NULL 
            Point p02 = new Point(10, 20);
            var p03 = new Point(30, 40);

        }
    }

    // STRUCT = MINI CLASS
    public struct Point
    {
        public int X;
        public int Y;
        public int? Z;
        // CONSTRUCTOR
        public Point(int x, int y, int? z = null)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

    }





Nullable type  int?

	int i = 0;   // OK
	int i = null;   // FAIL
	int? i = null;   // OK as int?  nullable type   -1,0,1,2,3,null
	bool?
	double?

            double? dd = 22;
            dd = null;


Pointer type

	
	int*

		DIRECTLY POINTS TO A HEXADECIMAL ADDRESS IN RAM MEMORY

		NOTHING LIKE TRADITIONAL DATA TYPE

	
	unsafe <<< MyMethod >>>(){

		fixed( int* = 0xfffffff   )
	}




Arrays

	     // ARRAY
            // FIXED SIZE : IMMUTABLE
            // FAST : READ DIRECTLY TO EACH 'PIGEON HOLE'

            int[] myArray01 = { 1, 2, 3 };  // filled, size 3
            int[] myArray02 = new int[10];  // blank, size 10
            Console.WriteLine(myArray01[2]); // output 3
            int[,] my2dArray = new int[10, 10];  //10x10 grid
            int[,,] myCubic = new int[10, 20, 10];
            int[][] myJaggedArray = new int[10][];
            // 10 arrays of as yet undetermined size
            myJaggedArray[0] = new int[1000];

            Console.WriteLine(string.Join(",", myArray01));
            // string.split can get from string to array
            string myCSVdata = "1111,2222,3333,4444";
            // to array
            string[] myCSVarray = myCSVdata.Split(',');
            Console.WriteLine(myCSVarray[0]);



Collections

	<T> Generics ==> T stands for ANY POSSIBLE DATA TYPE IN C#	
			A) C# TYPES B) CUSTOM WHICH YOU HAVE MADE EG 					MYCLASS/MYSTRUCT

		List<T>
		Queue<T>
		Stack<T>
		LinkedList<T>
		Dictionary<TKey,TValue>
		

	List
		Add/Remove 
		AddAt(2)   index 
		AddFirst/Last
	
	Queue
		FIFO First In, First Out
			((Printers, Emails, Polite bus queue!))
		
		10
		15,10		==> queue goes this way
		20,15,10	
				Peek() LOOKS AT FIRST ITEM (10)
				Dequeue()  REMOVE AND RETURN FIRST ITEM (10)
		Enqueue()
			return 10
			queue now look like
		20,15

		Enqueue() adds new item ((ONLY ON END))
		100,20,15


	Stack

		LIFO (Last in first out)   THINK RUGBY SCRUM

		Push()  item 	ONTO TOP
		Pop() item 	OFF TOP
		Contains()	seek for item

	

	          Stack<bool> myBooleanStack = new Stack<bool>();
            myBooleanStack.Push(true);
            myBooleanStack.Push(false);
            myBooleanStack.Pop();
            Console.WriteLine(myBooleanStack.Contains(true)); // true
            myBooleanStack.Pop();
            Console.WriteLine(myBooleanStack.Contains(true)); // false
  




Casting, Boxing, Objects

	Casting converts from ONE TYPE TO ANOTHER EG int 1 to double 1.0

		IMPLICIT CAST (SAFE)

			int i = 10;               	//   10.0
			double d = i;     		//   10.0

		EXPLICIT CAST (UNSAFE, CAN LOSE DATA)
	
			double d = 1.8;
			int i = (int)d;          // LOSE DATA IE 0.8
						// CAST = TRUNCATION!!!!

	Boxing CONVERTS TO AND FROM generic object type 'o'

		ROOT OBJECT IS o

		int i = 10;
		object o = i;

		int ii = (int)o;

	
	
	Arraylist

		SINGLE LIST OF OBJECTS TYPE 'o' (IE NO FIXED TYPE)

	Hashtable

		LIST OF KEY/VALUE PAIRS WHERE KEYS NOT STRUCTURED, BUT TYPE 'o'



	Dictionary<TKey,TValue> is Key/Value pair structure

		1		apple
		2		orange
		3		pear
		4		banana



Enum

	If we are dealing with a fixed type of structure over and over again
	for example categories of steel we can create an ENUM instead of 
	remembering codes

	0	sunday		high carbon
	1	monday 		low carbon
	2	tuesday		silicon


	0 = first item
	1
	2


Exceptions

        {

            try {
                // DODGY CODE WHICH CAN FAIL
                int x = 10, y = 0, z;
                // DECLARED x, y, z 
                // INITIALISED x,y
                z = x / y;

                
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("OOOPS ! Snap ! Don't divide by ZERO!!!");
                Console.WriteLine(e);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.GetType());

            }

            catch (Exception e){
                Console.WriteLine("OOOPS ! Snap ! Something went wrong");
                Console.WriteLine(e);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.GetType());
                
            }

            finally {
                // ALWAYS RUN REGARDLESS IF EXCEPTION OR NOT
                // myDB01.close();
                // myFileHandle01.close();
            }

            try {
                throw (new Exception("hey steel is not looking good"));
            }
            catch (Exception e) {
                Console.WriteLine();
                Console.WriteLine(e.Message);
                Console.WriteLine("Who's to blame???");
                throw;
            }
            finally { }	



Delegates And Events

	Delegates

		Delegate is a PLACEHOLDER FOR HOLDING ONE OR MORE METHODS

		 	delegate void myDelegate(param01,param02)

	

			
Events

	Events can be linked to 
		User initiated eg 'click'
		System initiated 

	
	Typical pattern for a windows event is always to declare

			Event (object sender, eventArgs e)	


	Declaring an event

		1)  Decide when event fires which methods we want to fire
		2)  Create a DELEGATE OBJECT with the structure matching
			the methods we want to fire

			delegate int MyHandler(string x);  

		3)  Create the event 

		public	event <<delegate name>>  <<event name>>
		public	event  MyHandler          myEvent01


		4)  Add in any methods into myHandler 

			MyHandler += MyMethod01;
			MyHandler += MyMethod02;

		5)  Create methods

		6)  OK to run and fire event 



Passing by REFERENCE and by VALUE

	int x = 100;
	MyMethod(int x){
		
	}



        {
            Dog Dog01 = new Dog("fido",700);
            Console.WriteLine(Dog01.height);  // x1
            MyDogManipulator(Dog01);
            Console.WriteLine(Dog01.height);  // x2
        }

        static void MyDogManipulator(Dog d)
        {
            d.height *= 2; // double
        }
    }

    class Dog
    {
        public string name { get; set; }
        public int height { get; set; }

        public Dog(string name, int height) {
            this.name = name;
            this.height = height;
        }





Operators

	





Checked


            Console.WriteLine(int.MaxValue);
            int num01 = int.MaxValue;
            int num02 = num01 + 1;
            Console.WriteLine(num01);
            Console.WriteLine(num02);
            Console.WriteLine(num02+11234);
            Console.WriteLine(num02+12343214);

            try
            {
                checked
                {
                    int num04;
                    unchecked
                    {
                         num04 = int.MaxValue * 100;

                    }

                    
                    int num03 = int.MaxValue;
                    Console.WriteLine(num03 * 100);
                }
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Hey too big");
            }




Threading And Tasks

	Application		run AFTER LOGON

	Service			run AFTER STARTUP 

	Process			running application / service  .exe 'live'

	Thread			CPU has to 'allocate' or block time for each
				application or service.  All code can be broken
				down into threads which are single blocks of code
				sent to CPU for execution as one block

	Task			Have main thread.  Call Task.  .NET / CPU will
				handle micro-management of thread creation/handling






        static void Main(string[] args)
        {
            // OLDER
            // LAMBDA IS ANONYMOUS METHOD
            Task task01 = new Task(() => {
                Console.WriteLine("in Task01");
            });
            task01.Start();

            // NEWER : Task.Run()  with Lambda ()=>{} inside
            var task02 = Task.Run(() => {
                Console.WriteLine("In Task02");
            });

           // OLDER : Action delegate
            var task03 = Task.Run(new Action(MyMethod01));
            

            // OLDER : Task.Factory
            // Task.Factory.StartNew()  .NET4
            var task04 = Task.Factory.StartNew(()=> {
                Console.WriteLine("In Task04");
            });

            // older : delegate instance
            // instantiate our delegate and add one method
            MyDelegate MyMethods = new MyDelegate(MyMethod02);
            //var task05 = Task.Run(MyMethods); - looking for Action Delegate

            Console.ReadLine();
        }

        public static void MyMethod01() {
            Console.WriteLine("In Method 01 running via Task 3");
        }
        public static void MyMethod02()
        {
            Console.WriteLine("In Method 02");
        }

    }



            var task01 = Task.Run(() => {
                Thread.Sleep(2000);
                Console.WriteLine("In Task 01");
            });
            var task02 = Task.Run(() => {
                Console.WriteLine("In Task 02");
            });
            var task03 = Task.Run(() => {
                Console.WriteLine("In Task 03");
            });

            Console.WriteLine("Waiting For One ArrayTask To Complete");

            // Create ARRAY OF TASKS
            Task[] taskArray = new Task[]
            {
                Task.Run(()=> { Thread.Sleep(3000);  Console.WriteLine("In task 04");  }),
                Task.Run(()=> { Thread.Sleep(5000);  Console.WriteLine("In task 05");  })
            };

            Task.WaitAny(taskArray);
            Console.WriteLine("Now waiting for all ArrayTasks to complete");
            Task.WaitAll(taskArray);

            Console.ReadLine();


Tasks are used to let the operating system handle backgound work



Parallel background tasks

	Even more useful than tasks are Parallel tasks!!!

	We can iterate over a large collection and have the CPU split each
	iteration into a separate task, to get the looping done as quickly
	as possible

	mySteelDatabase<TInt,TString>

		process collection and perform analysis on each item


	1) Parallel.Invoke(()=> <<directly put methods here>> )

	2) Parallel.For(0,10000,i=>{ // do something with i } )

	3) Parallel.ForEach(myArray, item {  // process array item here })

	4) Database LINQ query

		Standard LINQ query   - just add on 'AsParallel()' on end





Cancelling A Task

	Main Thread			Task Thread

			while task thread is running you don't have communication

			if you do need communication you have to specially create 
			it

			EG ability to cancel thread at will

			1) Create task cancellation token
			2) Cancel => invoke 'Throw' TaskCancellation exception

	

WPF Tasks

	Problem is that the GUI thread by definition is completely separate 
	from the Task thread.

	In the GUI this means how do we communicate from Task to Screen?

	Answer : Dispatcher object

		 Dispatcher.BeginInvoke ( Action Delegate ie method which can
				update the screen)

	1. Create GUI
	2. Click Button
		Create Task or Task[]
			if screen output ==> Dispatcher thread can talk back
				to screen



Streaming

	Take input/output data and BLOCK IT INTO BLOCKS OF FIXED SIZE

		BUFFER SIZE	byte[] myBufferArray = new byte[1000]

	MemoryStream

		putting data into raw sequence of 1 and 0

			TEXT FILE ==> ASCII => 1010101010011100 

		Know size

		Pointer at any point on data

	FileStream

		Traditional computing : getting data to/from files

		Text	ASCII / UNICODE UTF-8 UTF-16 
		Binary eg EXE, AVI, JPG, 

	NetworkStream

		\\SERVER\SHARE 	 	UNC PATH
		HTTP://SERVER/FOLDER/FILE.HTM 

		TEXT	
		BINARY  BLOB BINARY LARGE OBJECT  	

		Example
			async GetHttp(){
				await HttpGet....("http:///")
			}

	File types

		TXT  RAW ASCII

		JSON	{
				field1:"value1",
				field2:"value2"
				}
		XML
			<rootElement>
				<rowElement>
					<cellElement 						attribute="value">ValueData
					</cellElement>
				</rowElement>
			</rootElement>


	Methods to work with streams of data

	TEXT
		STREAMREADER/WRITER
		
	BINARY	
		BINARYREADER/WRITER

	METHODS EXPOSED

		Flush()   partial stream, get last data out
		Close()
		ReadToEnd()
		ReadAsync()
		

		
Serialisation

	
	Picture : Large Cardboard box for transport

		Easiest : flat pack & reassemble at the other end

	Begin with STRUCTURED OBJECT

		Class Customer ...... 

			fields
			properties
			??? methods ???


	If going to send 
			1) which items - all or some?
			2) which order ... 
			3) which streaming type (streaming context)



Serialiazation Types

    .NET classes

	IFormatter ==> root abstract class

		BinaryFormatter ==> to .bin

		SoapFormatter   ==> to .xml

	JavascriptSerializer    (older .NET)



   Web classes

	XMLSerializer          (older)



	DataContractSerializer		to XML
	DataContractJSONSerializer      to JSON
			
		(newer, faster)


	
Serializing Custom Class

	[Serializable]
	myClass

		[NonSerialized]
		private int _dontSerializeMeField


		private int _canSerializeMe


	XMLSerialier

		serialize everything

			[XMLIgnore] on top of opt-out fields



Assemblies

	Assemblies are COMPILED UNITS OF CODE

		C#	.exe
			.dll library

		ANDROID	.apk
		IOS	.app
		
		WINDOWS 10 UNIVERSAL WINDOWS APP	.appx
			(STORE APP)	
			((sideloading : manually install))


	Assemblies

		.exe/.dll  anywhere

	Global Assembly

		1) Create CERTIFICATE computer/domain
		2) Sign OUR ASSEMBLY
		3) Give ASSEMBLY A STRONG NAME which include VERSION NUMBER

		GACUTIL   Global Assembly Cache Utility

			/i  my.dll     INSTALL SIGNED ASSEMBLY INTO A GLOBAL 
					AREA WHERE WE CAN USE IT LIKE A WINDOWS
					DLL

		C:\Windows\Assembly

	Signing an assembly

		sn.exe  Strong Name .exe

		FIRST : GENERATE A KEY PAIR (TESTING)

		sn -k  KeyPair.snk

		SECOND : EXTRACT JUST PUBLIC KEY

		sn -p  KeyPair.snk   PublicKey.snk

		THIRD : VISUAL STUDIO : PROJECT PROPERTIES : SIGNING : BROWSE
				AND FIND THIS FILE

			use either key to 'SIGN' our dll
			
		FOURTH : VERIFY 

		sn -v  my.dll     YES HAS BEEN SIGNED


	Install into GAC GLOBAL ASSEMBLY CACHE area

		GACUTIL.EXE  /i  (INSTALL)  my.dll

		Installed NOT in c:\windows\assembly  (Microsoft)

		Installed INTO C:\Windows\Microsoft.NET\assembly\GAC_MSIL


	Bind to different versions of same DLL

		Version 1.0.0.0

		Version 1.0.0.1

		App.Config

		.NET RUNTIME SUPPORT
		<configuration>
			<startup>
				<supportedRuntime version="v4.0">


			<runtime>
				<assembly>
					<dependantAssembly>
						..Identity
						<bindingRedirect oldVersion="1.0"
								 newVersion="1.1"


	Al.exe  Assembly linker  can link/merge files/dlls into one assembly

			

Debugging : having extra code just for debugging

	1) REGIONS

		#REGION
		#REGION x


		#ENDREGION


				visually reduce code so not visible	



	2) CONDITIONAL COMPILING

		#define DEBUG  (first line)


		#if(DEBUG)

			// code in here only compiles when run in DEBUG mode

		#endif



Indexer

	string x = "abcdef";

		x is an array of characters
		
		x[1] = b


	myClass

		private int[100] myInternalArray;


		Instantiate : myClass instance01 = new myClass()

				instance01.myInternalArray[0]

	Indexer

		sugar syntax : now can access array via

				instance01[50]  ie item 50 in array



Encryption (chapter 13)

	Hashing

		MD5
		SHA1
		SHA256
		SHA512

			file	==> 		ASDU987SADF7SADF987SADF

							hash

						verifies INTEGRITY : no change

	Symmetric

		WIFI

		AES256	safe

			DES
			3DES
			RC4
					... unsafe

		ONE KEY : ENCRYPT & DECRYPT



		plain text    +   algorithm  +  wifi key  +   salt (IV)

				    WPA2     +  sugar22   +   AS98DSD98SAD

		
						===========>>> cipher text out


		!!!! SYMMETRIC RELATIVELY HACKABLE !!!!

			same key : encrypt and decrypt

		REAL LIFE : WEB BROWSING

			SESSION KEY ONLY VALID 10 MINUTES


	Asymmetric

		STRONGER BUT VERY SLOW !!!  NOT PRESENTLY HACKABLE 

		PRIVATE
		PUBLIC 

			one encrypt, one decrypt

		WEB SERVER : public/private key on web server

			CONNECT TO PAGE : SEND YOU (CLIENT) THE PUBLIC
					KEY/CERTIFICATE

			CLIENT : USE PUBLIC KEY TO GENERATE SESSION KEY
				SEND BACK TO SERVER



Managed vs Unmanaged Code

	Microsoft Word
	Files
	Databases

		c# can talk to Word, Files, DB


		C# clean compiled 			Unmanaged Code
							   C, C++
							   Files/Database

		
		Run code
		
			CLR Common Language Runtime

			   create/destroy variables
				STACK : FAST
				HEAP : SLOW, LARGER




			GC Garbage Collector

				CLR Runtime automatically
				handles cleanup

				Timing unpredictable 

				GC.Collect() FORCE Garbage Collection


		Weak reference

		Strong reference	no longer reference item


	DLR Dynamic Language Runtime

		HANDLES DYNAMIC (UNMANAGED) CODE

		Illustration

			dynamic keyword

				COMPILER DOES NOT FIX TYPES ETC TILL RUNTIME


		Real life

			invoke with

				try/catch/finally 

				using()  {  }



	Disposing of an item

		class
		
			Public MyClass 		CONSTRUCT

			~MyClass		DESTRUCTOR / FINALIZER


		GC call finalizer last thing before disposing

			Manually create 

				Dispose() method to actually do stuff when
				cleaning up

			Class : IDisposable to get this done




Extending a sealed class

	
Assemblies and Reflection

	Running computer : QUERY RUNNING ASSEMBLIES FOR

				ASSEMBLY (EXE)
					TYPES IN ASSEMBLY EG MyClass
						Methods/Properties in Type
						Values

					Instantiate a type

						Run an instance


	

















Project

	GUI : WPF

		size : auto or 1000x800

			WindowState="Maximized"
			WindowStyle="None"

	Create heading and logo?

	Create class   

	Create list    List<myclass>

	Instantiate your class a few times and add to list

	Display list on screen

	click on one item

		display details in text boxes

		update???

	
























Random
Access modifier : public 
		  private   (inside this class only)
	          internal  ( visible anywhere inside
			   compiled .exe/.dll assembly)
		  protected  (available in parent 
			    class and any child 
			    'derived' class
Equality of decimal numbers : test for difference less than given value



















Summary of OOP

Class : Blueprint for creating NEW objects
	Class x = new Class()  calls CONSTRUCTOR
Class contain
	Methods  DoThis(){}
	Properties   get;set;   string name {get;set;}
	Fields  int x;   
		int x=10;
		often private  int _privateField
Parent => Child
	Base => Derived class
Sealed class has no derived classes (can't be a base class)
Polymorphism
	Parent Method has virtual keyword
	Child  Method has override keyword  (also new)  
		(optional)
Abstract Class marked with ABSTRACT keyword 
	Parent has Method marked with
		1) ABSTRACT keyword 
		2) abstract MyMethod();    MISSING IMPLEMENTATION (BRACES)
	Child  has
		1) OVERRIDE keyword
		2) must complete code ie have IMPLEMENTATION !!!!
	Note : Abstract classes can have
		1) Abstract method
		2) Regular method
Interface : fully abstract structure
	1) PROPERTIES
	2) METHODS
		if you IMPLEMENT, must redeclare PROP/METHODS
Methods
	parameter : optional 
	          : out
	Call : named parameters

Override
	Polymorphism : Child Derived Class : method code will be different
			to the code in the parent


        static void Main(string[] args)
        {
            DoThis();
            DoThis(10);
            DoThis(10, "hi");
            DoThis(10, 20);
        }

        // OVERLOADED METHODS : SAME NAME + DIFFERENT PARAMS
        static void DoThis() { }
        static void DoThis(int x) { }
        static void DoThis(int x, string y) { }
        static void DoThis(int x, int y) { }

        // NAME + PARAMETERS ==> "SIGNATURE OF METHOD"



Wednesday morning : Critical review of OOP & Tuesday work
Class : reference type
String : array of characters : a) Immutable b) reference type
StringBuilder 
Heap Slower, Larger   
Stack Fast ==> Primitive ==> int, bool, char, doubles, structs
					(data stored with variable on stack)
Array
	int[]
	int[,]
	int[,,]
	int[][]  array of arrays where initially the length of individual array
			not set yet
	Good Fixed size, to reach data know exactly memory address so can read/
			write super quickly
	Bad  Immutable - cannot resize
	Clone()
	CopyTo()

Overload
	DoThis()
	DoThis(int x)
	DoThis(string y)
				note : parameters only, can't change return type	

Polymorphism = override
Override
	Base Class = Parent 		virtual MyMethod { parent code}
	Derived Class = Child		override MyMethod { child code, override}

Collection
	<T> 	Generics means <T> standing for any TYPE
			C# 	int/string/bool
			own	MyClass

Queue
	FIFO 
	Enqueue/Dequeue
	Peek() first item
	Contains()
Stack
	LIFO
	Push()
	Pop()	

List
	Add/Remove/Insert/RemoveAt(index, item)

LinkedList	

Dictionary<TKey,TValue>   Index = TKey   Data = TValue	


Ignore unless desperate because deal with generic object 'o' ie mixed types

	ArrayList (1D)

	Hashtable (2D key/value) 

Enum = named collection 
	0,1,2,3.. unless you specify otherwise
	[Flags] above enum ((Decorator))
Delegate
	Link to one or more methods
	Declare delegate
	Instantiate : add first method
	     subsequently :  +=  add second method
	      myHandler += Method02
		        -= Method02
Event
	public event MyDelegate  MyEvent

using( item need to 'clean up' eg DB read ){}

try{
	throw (new Exception ...)
}
catch (Exception e){ }
finally{}

try{

	try{ xx }
	catch{
			throw;  // bounce to level above
	}
	finally{}
}

catch{

}






Thursday morning Tech Review : Critical Terms and Concepts

LINQ Language Independent Query
IEnumerable = QUERY ARRAY LOCAL
IQueryable which Implements IEnumerable WHEN QUERY DATABASE REMOTELY
var LINQoutput = 
	from c in Customers
	where c.City = "London"
	orderby c.LastName
	
	groupby c.Age
	into new CustomerObject { City = c.City, Age = c.Age ...  }
	select CustomerObject

JSON {
	city: "London",
	age : 22
     }

for
foreach
Parallel.For(0,100,i=>{})
Parallel.ForEach(customer,item=>{  })
checked for runtime overflow exception
unchecked 
Process => CPU handle individual threads
Threads ==> dangerous to handle manually
Main Thread
	Task.Run(   ()=>{}    )
	new Task()
	TaskFactory.Start
	Task[] array of tasks
		WaitAny/All
	WhenAll ==> return Task
Operator
	&& short circuit
	% modulus remainder
	x++  ++x
	+=
	^  xor
	!
	  ? :  ternary short for if then else
	??     null??b  returns    b       b?c returns b
	if(Customer?.Name=="fred")   ?.  return null rather than give exception
					if Customer null
	||
	
\'  escape (make available for screen printing)
\\
\"
\n  new line
($"some text here {myVariable} here")
@"literal c:\real\paths\"	 
while  0+ loops
do..while  1+ loops




Friday morning : term crash

LINQ query : c# query independent of DB connection behind so can use same
	code for different DB connections/types
LINQ 
	immediate	RETURN SCALAR EG AVERAGE
	deferred	DEFAULT
	forced		.ToList<int>()  forces query straight away
LINQ   from c in customers where c.name="fred" orderby c.date select new {   }
XAML   XML Extensible Application Markup Language
		Old WinForms
ASPX   (older ASP) : Microsoft custom website
WPF uses XAML
EF Entity Framework : import DB classes
	DB first
	Code first
F5		DEBUG
Ctrl F5		No debug
DEBUG OR RELEASE MODE
Console.WriteLine  to application 
Debug.WriteLine ==> output to ...  VS output window (debug mode)
Trace.WriteLine ==> output to ...  Visual Studio OUTPUT window  (production&debug)
Tasks        SAFE WAY OF GETTING OS TO HANDLE BACKGROUND THREADS FOR US
Threads	     INDIVIDUAL BLOCKS OF CODE SENT TO CPU FOR EXECUTION
Process	     RUNNING .EXE : CPU ALLOCATE TIME TO IT 
exe	     APPLICATION
dll	     LIBRARY OF CODE EG CLASS/METHOD TO USE (IMPORT)
Application  USER INITIATED AFTER LOGIN
Service      STARTUP OR CAN BE USER INITIATED
Putting in Action delegate in task  (Action is null delegate which returns nothing)
t = new Task(); t.Start()
Task.Factory.StartNew()
Task.Run()
Parallel.For/ForEach()
Stream
	FileStream
	MemoryStream
	NetworkStream to http or \\server\share UNC 
Http
async MyMethodAsync(){
	await ...ReadFileAsync()
}
Serialiazation








































</pre>
