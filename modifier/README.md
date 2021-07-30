### async

- It's referred to as an async method (asynchronous)

### constant vs Readonly

- Both (Readonly and constats) of them are contant.
- `contant` is compile time constant
- `readonly` is run time constant. 
`constVsreadonly.c` Shows a sample example of constant vs readonly.  

### event

### extern
 
### in vs ref vs out [parameter keyword]

`ref`
- It is used as a parameter passed and can be modified by the method.  
- It is MUST be initialized before passing to the method.  

`out`
- It is used as a parameter passed and MUST be modified by the method.  
- It is MUST NOT be initialized before passing to the method.  

`in` (readonly) : It is used as a parameter passed and can NOT be modified by the method. 

`ref` and `in`, both require the parameter has to initialize before pass into the method.
We can not use these modifier in methods with `async` modifier as well as `yield return` or `yield break`.

`ref_out_in` Folder has an example of `ref`vs `out` vs `in`

### volatile

# Note
`abstract`, `override`, `sealed`, `virtual`, `new` and `unsafe` these modifier sample code are written in `../OOPs`      