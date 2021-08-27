### IEmuarable

### IEnuarable

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
Syntex  
```sh
[access modifier] delegate [return type] [delegate name]([parameter list])
```
`Delegate` This folder contains a sample code (Delagate parameter, Generic type (single and multiple), multicating and instanting delagate) of delegates.

## Multiple Generic Type.
`MultipleGenericType.cs`: Shows a smaple example of how to use the multi gerneric typr in c#  

## Lambda expression (=>)
- It is used to creatre an anonymous function
- There are two types of lambda expression.
1. Expression lambda
    ```sh
    (input parameters) => expression
    ```
2. Statement lambda
    ```sh
    (input-parameters) => { <sequence-of-statements> }
    ```

## event

## using

# Thread

# Task

# async : Asynchronous method
# await : suspension point
// https://www.c-sharpcorner.com/article/async-and-await-in-c-sharp/

### Contextual keywords in c#


https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/introduction
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/default

