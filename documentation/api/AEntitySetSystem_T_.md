#### [DefaultEcs](DefaultEcs.md 'DefaultEcs')
### [DefaultEcs.System](DefaultEcs.md#DefaultEcs_System 'DefaultEcs.System')
## AEntitySetSystem&lt;T&gt; Class
Represents a base class to process updates on a given [EntitySet](EntitySet.md 'DefaultEcs.EntitySet') instance.  
Only [Get&lt;T&gt;()](Entity_Get_T_().md 'DefaultEcs.Entity.Get&lt;T&gt;()'), [Set&lt;T&gt;(T)](Entity_Set_T_(T).md 'DefaultEcs.Entity.Set&lt;T&gt;(T)') and [SetSameAs&lt;T&gt;(Entity)](Entity_SetSameAs_T_(Entity).md 'DefaultEcs.Entity.SetSameAs&lt;T&gt;(DefaultEcs.Entity)') operation on already present component type are safe.  
```csharp
public abstract class AEntitySetSystem<T> :
DefaultEcs.System.ISystem<T>,
System.IDisposable
```
#### Type parameters
<a name='DefaultEcs_System_AEntitySetSystem_T__T'></a>
`T`  
The type of the object used as state to update the system.
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; AEntitySetSystem&lt;T&gt;  

Implements [DefaultEcs.System.ISystem&lt;](ISystem_T_.md 'DefaultEcs.System.ISystem&lt;T&gt;')[T](AEntitySetSystem_T_.md#DefaultEcs_System_AEntitySetSystem_T__T 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.T')[&gt;](ISystem_T_.md 'DefaultEcs.System.ISystem&lt;T&gt;'), [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  

| Constructors | |
| :--- | :--- |
| [AEntitySetSystem(EntitySet)](AEntitySetSystem_T__AEntitySetSystem(EntitySet).md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.AEntitySetSystem(DefaultEcs.EntitySet)') | Initialise a new instance of the [AEntitySetSystem&lt;T&gt;](AEntitySetSystem_T_.md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;') class with the given [EntitySet](EntitySet.md 'DefaultEcs.EntitySet').<br/> |
| [AEntitySetSystem(EntitySet, bool)](AEntitySetSystem_T__AEntitySetSystem(EntitySet_bool).md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.AEntitySetSystem(DefaultEcs.EntitySet, bool)') | Initialise a new instance of the [AEntitySetSystem&lt;T&gt;](AEntitySetSystem_T_.md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;') class with the given [EntitySet](EntitySet.md 'DefaultEcs.EntitySet').<br/> |
| [AEntitySetSystem(EntitySet, IParallelRunner)](AEntitySetSystem_T__AEntitySetSystem(EntitySet_IParallelRunner).md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.AEntitySetSystem(DefaultEcs.EntitySet, DefaultEcs.Threading.IParallelRunner)') | Initialise a new instance of the [AEntitySetSystem&lt;T&gt;](AEntitySetSystem_T_.md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;') class with the given [EntitySet](EntitySet.md 'DefaultEcs.EntitySet') and [IParallelRunner](IParallelRunner.md 'DefaultEcs.Threading.IParallelRunner').<br/> |
| [AEntitySetSystem(EntitySet, IParallelRunner, int)](AEntitySetSystem_T__AEntitySetSystem(EntitySet_IParallelRunner_int).md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.AEntitySetSystem(DefaultEcs.EntitySet, DefaultEcs.Threading.IParallelRunner, int)') | Initialise a new instance of the [AEntitySetSystem&lt;T&gt;](AEntitySetSystem_T_.md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;') class with the given [EntitySet](EntitySet.md 'DefaultEcs.EntitySet') and [IParallelRunner](IParallelRunner.md 'DefaultEcs.Threading.IParallelRunner').<br/> |
| [AEntitySetSystem(World)](AEntitySetSystem_T__AEntitySetSystem(World).md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.AEntitySetSystem(DefaultEcs.World)') | Initialise a new instance of the [AEntitySetSystem&lt;T&gt;](AEntitySetSystem_T_.md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;') class with the given [World](World.md 'DefaultEcs.World').<br/>To create the inner [EntitySet](EntitySet.md 'DefaultEcs.EntitySet'), [WithAttribute](WithAttribute.md 'DefaultEcs.System.WithAttribute') and [WithoutAttribute](WithoutAttribute.md 'DefaultEcs.System.WithoutAttribute') attributes will be used.<br/> |
| [AEntitySetSystem(World, bool)](AEntitySetSystem_T__AEntitySetSystem(World_bool).md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.AEntitySetSystem(DefaultEcs.World, bool)') | Initialise a new instance of the [AEntitySetSystem&lt;T&gt;](AEntitySetSystem_T_.md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;') class with the given [World](World.md 'DefaultEcs.World').<br/>To create the inner [EntitySet](EntitySet.md 'DefaultEcs.EntitySet'), [WithAttribute](WithAttribute.md 'DefaultEcs.System.WithAttribute') and [WithoutAttribute](WithoutAttribute.md 'DefaultEcs.System.WithoutAttribute') attributes will be used.<br/> |
| [AEntitySetSystem(World, IParallelRunner)](AEntitySetSystem_T__AEntitySetSystem(World_IParallelRunner).md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.AEntitySetSystem(DefaultEcs.World, DefaultEcs.Threading.IParallelRunner)') | Initialise a new instance of the [AEntitySetSystem&lt;T&gt;](AEntitySetSystem_T_.md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;') class with the given [World](World.md 'DefaultEcs.World').<br/>To create the inner [EntitySet](EntitySet.md 'DefaultEcs.EntitySet'), [WithAttribute](WithAttribute.md 'DefaultEcs.System.WithAttribute') and [WithoutAttribute](WithoutAttribute.md 'DefaultEcs.System.WithoutAttribute') attributes will be used.<br/> |
| [AEntitySetSystem(World, IParallelRunner, int)](AEntitySetSystem_T__AEntitySetSystem(World_IParallelRunner_int).md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.AEntitySetSystem(DefaultEcs.World, DefaultEcs.Threading.IParallelRunner, int)') | Initialise a new instance of the [AEntitySetSystem&lt;T&gt;](AEntitySetSystem_T_.md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;') class with the given [World](World.md 'DefaultEcs.World').<br/>To create the inner [EntitySet](EntitySet.md 'DefaultEcs.EntitySet'), [WithAttribute](WithAttribute.md 'DefaultEcs.System.WithAttribute') and [WithoutAttribute](WithoutAttribute.md 'DefaultEcs.System.WithoutAttribute') attributes will be used.<br/> |
| [AEntitySetSystem(World, Func&lt;object,World,EntitySet&gt;, bool)](AEntitySetSystem_T__AEntitySetSystem(World_Func_object_World_EntitySet__bool).md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.AEntitySetSystem(DefaultEcs.World, System.Func&lt;object,DefaultEcs.World,DefaultEcs.EntitySet&gt;, bool)') | Initialise a new instance of the [AEntitySetSystem&lt;T&gt;](AEntitySetSystem_T_.md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;') class with the given [World](World.md 'DefaultEcs.World').<br/>To create the inner [EntitySet](EntitySet.md 'DefaultEcs.EntitySet'), [WithAttribute](WithAttribute.md 'DefaultEcs.System.WithAttribute') and [WithoutAttribute](WithoutAttribute.md 'DefaultEcs.System.WithoutAttribute') attributes will be used.<br/> |
| [AEntitySetSystem(World, Func&lt;object,World,EntitySet&gt;, IParallelRunner, int)](AEntitySetSystem_T__AEntitySetSystem(World_Func_object_World_EntitySet__IParallelRunner_int).md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.AEntitySetSystem(DefaultEcs.World, System.Func&lt;object,DefaultEcs.World,DefaultEcs.EntitySet&gt;, DefaultEcs.Threading.IParallelRunner, int)') | Initialise a new instance of the [AEntitySetSystem&lt;T&gt;](AEntitySetSystem_T_.md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;') class with the given [World](World.md 'DefaultEcs.World') and factory.<br/>The current instance will be passed as the first parameter of the factory.<br/> |

| Properties | |
| :--- | :--- |
| [IsEnabled](AEntitySetSystem_T__IsEnabled.md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.IsEnabled') | Gets or sets whether the current [AEntitySetSystem&lt;T&gt;](AEntitySetSystem_T_.md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;') instance should update or not.<br/> |
| [Set](AEntitySetSystem_T__Set.md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.Set') | Gets the [EntitySet](EntitySet.md 'DefaultEcs.EntitySet') instance on which this system operates.<br/> |
| [World](AEntitySetSystem_T__World.md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.World') | Gets the [World](World.md 'DefaultEcs.World') instance on which this system operates.<br/> |

| Methods | |
| :--- | :--- |
| [Dispose()](AEntitySetSystem_T__Dispose().md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.Dispose()') | Disposes of the inner [EntitySet](EntitySet.md 'DefaultEcs.EntitySet') instance.<br/> |
| [PostUpdate(T)](AEntitySetSystem_T__PostUpdate(T).md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.PostUpdate(T)') | Performs a post-update treatment.<br/> |
| [PreUpdate(T)](AEntitySetSystem_T__PreUpdate(T).md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.PreUpdate(T)') | Performs a pre-update treatment.<br/> |
| [Update(T)](AEntitySetSystem_T__Update(T).md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.Update(T)') | Updates the system once.<br/>Does nothing if [IsEnabled](AEntitySetSystem_T__IsEnabled.md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.IsEnabled') is false or if the inner [EntitySet](EntitySet.md 'DefaultEcs.EntitySet') is empty.<br/> |
| [Update(T, Entity)](AEntitySetSystem_T__Update(T_Entity).md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.Update(T, DefaultEcs.Entity)') | Update the given [Entity](Entity.md 'DefaultEcs.Entity') instance once.<br/> |
| [Update(T, ReadOnlySpan&lt;Entity&gt;)](AEntitySetSystem_T__Update(T_ReadOnlySpan_Entity_).md 'DefaultEcs.System.AEntitySetSystem&lt;T&gt;.Update(T, System.ReadOnlySpan&lt;DefaultEcs.Entity&gt;)') | Update the given [Entity](Entity.md 'DefaultEcs.Entity') instances once.<br/> |
