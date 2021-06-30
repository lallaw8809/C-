### IEmuarable

### IEnuarable

### in vs ref vs out [parameter keyword]
`ref` : It is used as a parameter passed and can be modified by the method.  
`in` : It is used as a parameter passed and can NOT be modified by the method.  
`out` : It is used as a parameter passed and MUST be modified by the method.  
`ref` and `in`, both require the parameter has to initialize before pass into the method.

### Readonly vs constant

- Both (Readonly and constats) of them  are contant.
- `contant` is compile time constant
- `readonly` is run time constant. 

### global

global refers to the global namespace, it can be used to solve problems whereby you may redefine types. For example:
```sh
class foo
{
    class System
    {

    }
}
```
If you were to use System where it would be locally scoped in the foo class, you could use 
`global::System.Console.WriteLine("foobar")` to access the global namespace.
`global.cs` Sample code to show taht how to use the global in c#.  

### Nullable

It is special type of  datatypes in c# and we can store a range of the value from -2,147,483,648 to 2,147,483,647 or null.  
```sh
Syntex
< data_type> ? <variable_name> = null;
```

The Null Coalescing Operator (??)  
If the value is not assigned to variable then its assing the value (5) into the number.  
```sh
number = variable ?? 5;
```
`class.cs` Sample code to show taht how to use the nullable in c#.  

## Delegate 
It is function callback/pointer to functions in c#. 
```sh
Syntex
[access modifier] delegate [return type] [delegate name]([parameter list])
```
`Delegate` This folder contains a sample code of delegates.


## event

## using


### Contextual keywords in c#


https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/introduction
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/default

