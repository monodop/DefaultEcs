#### [DefaultEcs](DefaultEcs.md 'DefaultEcs')
### [DefaultEcs](DefaultEcs.md#DefaultEcs 'DefaultEcs').[Entity](Entity.md 'DefaultEcs.Entity')
## Entity.Disable() Method
Disables the current [Entity](Entity.md 'DefaultEcs.Entity') so it does not appear in [EntitySet](EntitySet.md 'DefaultEcs.EntitySet').  
This method is not thread safe.  
```csharp
public void Disable();
```
#### Exceptions
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
[Entity](Entity.md 'DefaultEcs.Entity') was not created from a [World](World.md 'DefaultEcs.World').
