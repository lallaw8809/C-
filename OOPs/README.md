# Class and Object

A class is a data structucture that contains a memberes (contants and field) and methods.  
A object is created from the class and can create a multiple object of a one class.

`class.cs`  Sample example code of class  and object

Here it is the detailed description of various data members and function methos used in the c# c.  

![](https://github.com/lallaw8809/c-Sharp/blob/main/imgs/class_object.png?raw=true)

 [Reference](https://www.tutlane.com/tutorial/csharp/csharp-classes-and-objects-with-examples#:~:text=In%20c%23%2C%20Classes%20and%20Objects%20are%20interrelated.%20The,class%20to%20access%20the%20defined%20properties%20and%20methods)  

# Constructors

- A construct is a special method that is used to intitialize objects.
- It is a member of the class. The name of the constructor is same as the class name.
- A constructor is used to set the initial values for fields.

### Constructor overloading

It supports to have a different set of parameters, written a sample code in `constructorOverlaod.cs`

### Calling constructor

It will execute the calling contructor first and followed by execute the constructor. 

 ### static constructor

- A static constructor is used to initialize any static data, or to perform a particular action that needs to be performed once only.
- A static constructor does not take access modifiers or have parameters
- A class can only have one static constructor.
- Static constructors cannot be inherited or overloaded.

`constructors.cs` Sample code of constructor class  
`constructorOverlaod.cs` Sample code for constructor overload or method overload, calling constructor and static contructor.

# Class modifier

Thease are the class modifiers in c#.

- public   
- protected  
- private  
- internal  

- abstarct   
- static   
- sealed   
- new  
- class_modifier_unsafe  

# Static class

- A static class cannot be instantiated.
- Can not use a new operator to create a variable type of the class type (No instance variable).
- Contains only static members.
- Cannot contain Instance Constructors.
- It is sealed so we can not inheritance the static class

`staticClass.cs`  Sample example static code of class  

# Abstract class

- Abstract class is marked as a keyword `abstract` in the class definition and `abstarct` means that the class is incomplete and can not initialized. 
- Can not created a instace of this class but can be used in drived class.
- An abstract class cannot be sealed.

`abstract.cs` Showed a sample code that how to use the abstract class in the drived class.  

# Inheritance

This method is used to inherit the field and method form one class to another.  
The inheritance symbol `:`    

Syntax
```sh
<access_modifier> class <base_class_name>
{
    // Base or parent class Implementation
}

<access_modifier> class <derived_class_name> : <base_class_name>
{
    // Derived or child class implementation
}
```

`inheritance.cs` Sample code of inheritance   
`multiInheritance.cs` Sample code of multi inheritance  

# Polymorphism 

Polymorphism means many form (more than one form) and it can be achieved by two way

1. Method overring
2. Method overloading

### 1. Method overloading
Two or more methods are in the same class by using same method name with different parameter.  
Example
```sh
class A
{
    public void function() {}
    public void function(int x) {}
}  
```

### 2. Method overring (virtual and override keyword is used)
Same method name is used in the diffent class that means that the same method name is used in the parent and child class.
```sh
class A
{
    public void function() {}
} 

class B : A
{
    public void function(int x) {}
}
```
virtual and override keywords are used to overide the base class.  

virtual: This means that the method is virtual and it will be overridden in the drived class. virtual is used in the abse class and override is used in the drived class.  
override: It is used to override the method in the drived class of the base class.    

### method hiding (virtual and new keyword is used)
In the method hiding a base class reference variable pointing to a child class object, will invole the hidden method in the abse class.  

`polymorphism.cs` Sample code shows that how to use the polymorphism (method overloading, method overriding and method hiding).  

# Prperties
- Properties is a memebr and its used to protect the fields.
- `get` and `set` accessor is used to implement the properties. `get` accessor is used to return the value and `set` is used to set the value.
- The `value` keyword is used to define the value being assigned by the `set` or init accessor.
- The properties can be read and write (if they have both `set` and `get`), write only (if its have only `set`) and read only (if its have `get` only).

Syntax
```sh
<acces_modifier> <return_type> <property_name>  
   {  
    get  
   {  
   }  
    set  
   {  
   }  
} 
```
`properties.cs` Sample code of property.  

# Interfaces
- Another way to acheive the abstarction is interfaces in c#
- Members of interface are abstarct and public by default.
- Interfaces can contains properties, methods and events, NOT fields
- Interface can not have a constructor
- Interface can contains only the member declarion and the derived class responsiblity to have the member definition.
- These access modifier (public/private/protected) is not valid in interceface members.
`interface.cs` Sample code of how to use interface

# sealed