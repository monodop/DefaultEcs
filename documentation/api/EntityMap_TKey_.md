#### [DefaultEcs](DefaultEcs.md 'DefaultEcs')
### [DefaultEcs](DefaultEcs.md#DefaultEcs 'DefaultEcs')
## EntityMap&lt;TKey&gt; Class
Represents a collection of [Entity](Entity.md 'DefaultEcs.Entity') mapped to a [TKey](EntityMap_TKey_.md#DefaultEcs_EntityMap_TKey__TKey 'DefaultEcs.EntityMap&lt;TKey&gt;.TKey') component. Only one [Entity](Entity.md 'DefaultEcs.Entity') can be associated with a given [TKey](EntityMap_TKey_.md#DefaultEcs_EntityMap_TKey__TKey 'DefaultEcs.EntityMap&lt;TKey&gt;.TKey').  
```csharp
public sealed class EntityMap<TKey> :
System.IDisposable
```
#### Type parameters
<a name='DefaultEcs_EntityMap_TKey__TKey'></a>
`TKey`  
The type of the component used as key.
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EntityMap&lt;TKey&gt;  

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  

| Properties | |
| :--- | :--- |
| [Keys](EntityMap_TKey__Keys.md 'DefaultEcs.EntityMap&lt;TKey&gt;.Keys') | Gets the keys contained in the [EntityMap&lt;TKey&gt;](EntityMap_TKey_.md 'DefaultEcs.EntityMap&lt;TKey&gt;').<br/> |
| [this[TKey]](EntityMap_TKey__this_TKey_.md 'DefaultEcs.EntityMap&lt;TKey&gt;.this[TKey]') | Gets the [Entity](Entity.md 'DefaultEcs.Entity') associated with the specified key.<br/> |
| [World](EntityMap_TKey__World.md 'DefaultEcs.EntityMap&lt;TKey&gt;.World') | Gets the [World](World.md 'DefaultEcs.World') instance from which current [IEntityContainer](IEntityContainer.md 'DefaultEcs.IEntityContainer') originate.<br/> |

| Methods | |
| :--- | :--- |
| [Complete()](EntityMap_TKey__Complete().md 'DefaultEcs.EntityMap&lt;TKey&gt;.Complete()') | Clears current instance of its entities if it was created with some reactive filter ([WhenAdded&lt;T&gt;()](EntityQueryBuilder_WhenAdded_T_().md 'DefaultEcs.EntityQueryBuilder.WhenAdded&lt;T&gt;()'), [WhenChanged&lt;T&gt;()](EntityQueryBuilder_WhenChanged_T_().md 'DefaultEcs.EntityQueryBuilder.WhenChanged&lt;T&gt;()') or [WhenRemoved&lt;T&gt;()](EntityQueryBuilder_WhenRemoved_T_().md 'DefaultEcs.EntityQueryBuilder.WhenRemoved&lt;T&gt;()')).<br/>Does nothing if it was created from a static filter.<br/>This method need to be called after current instance content has been processed in a update cycle.<br/> |
| [Contains(Entity)](EntityMap_TKey__Contains(Entity).md 'DefaultEcs.EntityMap&lt;TKey&gt;.Contains(DefaultEcs.Entity)') | Determines whether the [IEntityContainer](IEntityContainer.md 'DefaultEcs.IEntityContainer') contains a specific [Entity](Entity.md 'DefaultEcs.Entity').<br/> |
| [ContainsKey(TKey)](EntityMap_TKey__ContainsKey(TKey).md 'DefaultEcs.EntityMap&lt;TKey&gt;.ContainsKey(TKey)') | Determines whether the [EntityMap&lt;TKey&gt;](EntityMap_TKey_.md 'DefaultEcs.EntityMap&lt;TKey&gt;') contains the specified key.<br/> |
| [Dispose()](EntityMap_TKey__Dispose().md 'DefaultEcs.EntityMap&lt;TKey&gt;.Dispose()') | Releases current [EntityMap&lt;TKey&gt;](EntityMap_TKey_.md 'DefaultEcs.EntityMap&lt;TKey&gt;') of its subscriptions, stopping it to get modifications on the [World](World.md 'DefaultEcs.World')'s [Entity](Entity.md 'DefaultEcs.Entity').<br/> |
| [TrimExcess()](EntityMap_TKey__TrimExcess().md 'DefaultEcs.EntityMap&lt;TKey&gt;.TrimExcess()') | Resizes inner storage to exactly the number of [Entity](Entity.md 'DefaultEcs.Entity') this [IEntityContainer](IEntityContainer.md 'DefaultEcs.IEntityContainer') contains.<br/> |
| [TryGetEntity(TKey, Entity)](EntityMap_TKey__TryGetEntity(TKey_Entity).md 'DefaultEcs.EntityMap&lt;TKey&gt;.TryGetEntity(TKey, DefaultEcs.Entity)') | Gets the [Entity](Entity.md 'DefaultEcs.Entity') associated with the specified key.<br/> |

| Events | |
| :--- | :--- |
| [EntityAdded](EntityMap_TKey__EntityAdded.md 'DefaultEcs.EntityMap&lt;TKey&gt;.EntityAdded') | Occurs when an [Entity](Entity.md 'DefaultEcs.Entity') is added in the current [IEntityContainer](IEntityContainer.md 'DefaultEcs.IEntityContainer').<br/> |
| [EntityRemoved](EntityMap_TKey__EntityRemoved.md 'DefaultEcs.EntityMap&lt;TKey&gt;.EntityRemoved') | Occurs when an [Entity](Entity.md 'DefaultEcs.Entity') is removed from the current [IEntityContainer](IEntityContainer.md 'DefaultEcs.IEntityContainer').<br/> |
