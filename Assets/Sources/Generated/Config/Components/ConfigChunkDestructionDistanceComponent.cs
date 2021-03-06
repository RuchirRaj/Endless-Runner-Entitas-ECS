//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigContext {

    public ConfigEntity chunkDestructionDistanceEntity { get { return GetGroup(ConfigMatcher.ChunkDestructionDistance).GetSingleEntity(); } }
    public ChunkDestructionDistanceComponent chunkDestructionDistance { get { return chunkDestructionDistanceEntity.chunkDestructionDistance; } }
    public bool hasChunkDestructionDistance { get { return chunkDestructionDistanceEntity != null; } }

    public ConfigEntity SetChunkDestructionDistance(float newValue) {
        if (hasChunkDestructionDistance) {
            throw new Entitas.EntitasException("Could not set ChunkDestructionDistance!\n" + this + " already has an entity with ChunkDestructionDistanceComponent!",
                "You should check if the context already has a chunkDestructionDistanceEntity before setting it or use context.ReplaceChunkDestructionDistance().");
        }
        var entity = CreateEntity();
        entity.AddChunkDestructionDistance(newValue);
        return entity;
    }

    public void ReplaceChunkDestructionDistance(float newValue) {
        var entity = chunkDestructionDistanceEntity;
        if (entity == null) {
            entity = SetChunkDestructionDistance(newValue);
        } else {
            entity.ReplaceChunkDestructionDistance(newValue);
        }
    }

    public void RemoveChunkDestructionDistance() {
        chunkDestructionDistanceEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigEntity {

    public ChunkDestructionDistanceComponent chunkDestructionDistance { get { return (ChunkDestructionDistanceComponent)GetComponent(ConfigComponentsLookup.ChunkDestructionDistance); } }
    public bool hasChunkDestructionDistance { get { return HasComponent(ConfigComponentsLookup.ChunkDestructionDistance); } }

    public void AddChunkDestructionDistance(float newValue) {
        var index = ConfigComponentsLookup.ChunkDestructionDistance;
        var component = CreateComponent<ChunkDestructionDistanceComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceChunkDestructionDistance(float newValue) {
        var index = ConfigComponentsLookup.ChunkDestructionDistance;
        var component = CreateComponent<ChunkDestructionDistanceComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveChunkDestructionDistance() {
        RemoveComponent(ConfigComponentsLookup.ChunkDestructionDistance);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ConfigMatcher {

    static Entitas.IMatcher<ConfigEntity> _matcherChunkDestructionDistance;

    public static Entitas.IMatcher<ConfigEntity> ChunkDestructionDistance {
        get {
            if (_matcherChunkDestructionDistance == null) {
                var matcher = (Entitas.Matcher<ConfigEntity>)Entitas.Matcher<ConfigEntity>.AllOf(ConfigComponentsLookup.ChunkDestructionDistance);
                matcher.componentNames = ConfigComponentsLookup.componentNames;
                _matcherChunkDestructionDistance = matcher;
            }

            return _matcherChunkDestructionDistance;
        }
    }
}
