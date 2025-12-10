namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_SearchPlaces_Configs (EP+NKrOV+0arpHIdBuWwvQ)
///  <code>ST_b0933bf7957301c22e5d9229ad792ac0Structure</code> that represent
/// s <code>Internal_SearchPlaces_Configs</code> <p>Description: Structure to handle internal
///  configurations associated with search places.</p>
/// </summary>
// Name: Internal_SearchPlaces_Configs
public partial struct ST_b0933bf7957301c22e5d9229ad792ac0Structure : ITypedRecord<ST_b0933bf7957301c22e5d9229ad792ac0Structure> {
internal static readonly GlobalObjectKey IdInternal_to_provider_configs = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*sQKCI4TAO0Cu3zSEy7xlBQ");
internal static readonly GlobalObjectKey IdUniqueId = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*oFOaxni6ikO_ZFE4vO3Pzw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_configs")]
public ST_d4721898ae8c007cd938074f575e2979Structure ssInternal_to_provider_configs;

[System.Xml.Serialization.XmlElement("UniqueId")]
public string ssUniqueId;


public BitArray OptimizedAttributes;

public ST_b0933bf7957301c22e5d9229ad792ac0Structure() {
OptimizedAttributes = null;
ssInternal_to_provider_configs = new ST_d4721898ae8c007cd938074f575e2979Structure();
ssUniqueId = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssInternal_to_provider_configs.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssUniqueId = r.ReadText(index++, "Internal_SearchPlaces_Configs.UniqueId", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_b0933bf7957301c22e5d9229ad792ac0Structure r) {
this = r;
}


public static bool operator == (ST_b0933bf7957301c22e5d9229ad792ac0Structure a, ST_b0933bf7957301c22e5d9229ad792ac0Structure b) {
if (a.ssInternal_to_provider_configs != b.ssInternal_to_provider_configs) return false;
if (a.ssUniqueId != b.ssUniqueId) return false;
return true;
}

public static bool operator != (ST_b0933bf7957301c22e5d9229ad792ac0Structure a, ST_b0933bf7957301c22e5d9229ad792ac0Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b0933bf7957301c22e5d9229ad792ac0Structure)) return false;
return (this == (ST_b0933bf7957301c22e5d9229ad792ac0Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInternal_to_provider_configs.GetHashCode()
 ^ ssUniqueId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssInternal_to_provider_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssInternal_to_provider_configs.InternalRecursiveSave();
}


public ST_b0933bf7957301c22e5d9229ad792ac0Structure Duplicate() {
ST_b0933bf7957301c22e5d9229ad792ac0Structure t;
t.ssInternal_to_provider_configs = (ST_d4721898ae8c007cd938074f575e2979Structure)this.ssInternal_to_provider_configs.Duplicate();
t.ssUniqueId = this.ssUniqueId;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "internal_to_provider_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_configs")) variable.Value = ssInternal_to_provider_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_configs");
} else if (head == "uniqueid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UniqueId")) variable.Value = ssUniqueId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInternal_to_provider_configs) {
return ssInternal_to_provider_configs;
}
if (key == IdUniqueId) {
return ssUniqueId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_configs.Key.AsGuid) {
return ssInternal_to_provider_configs;
}
if (attributeKey == IdUniqueId.Key.AsGuid) {
return ssUniqueId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInternal_to_provider_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_configs));
ssUniqueId = (string) other.AttributeGet(IdUniqueId);
}
} // ST_b0933bf7957301c22e5d9229ad792ac0Structure
/// <summary>
/// RecordList type <code>Internal_SearchPlaces_ConfigsList</code> that represents a record list of
///  <code>Internal_SearchPlaces_Configs</code>
/// </summary>
public partial class RL_d34e57a0f3be3dcf5e6c2af78bbca9cd : GenericRecordList<ST_b0933bf7957301c22e5d9229ad792ac0Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_b0933bf7957301c22e5d9229ad792ac0Structure GetElementDefaultValue() {
return new ST_b0933bf7957301c22e5d9229ad792ac0Structure();
}

public T[] ToArray<T>(Func<ST_b0933bf7957301c22e5d9229ad792ac0Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d34e57a0f3be3dcf5e6c2af78bbca9cd recordList, Func<ST_b0933bf7957301c22e5d9229ad792ac0Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d34e57a0f3be3dcf5e6c2af78bbca9cd(ST_b0933bf7957301c22e5d9229ad792ac0Structure[] array) {
  RL_d34e57a0f3be3dcf5e6c2af78bbca9cd result = new RL_d34e57a0f3be3dcf5e6c2af78bbca9cd();
result.InnerFromArray(array);
    return result;
}

public static RL_d34e57a0f3be3dcf5e6c2af78bbca9cd ToList<T>(T[] array, Func <T, ST_b0933bf7957301c22e5d9229ad792ac0Structure> converter) {
  RL_d34e57a0f3be3dcf5e6c2af78bbca9cd result = new RL_d34e57a0f3be3dcf5e6c2af78bbca9cd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d34e57a0f3be3dcf5e6c2af78bbca9cd FromRestList<T>(RestList<T> restList, Func <T, ST_b0933bf7957301c22e5d9229ad792ac0Structure> converter) {
  RL_d34e57a0f3be3dcf5e6c2af78bbca9cd result = new RL_d34e57a0f3be3dcf5e6c2af78bbca9cd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d34e57a0f3be3dcf5e6c2af78bbca9cd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b0933bf7957301c22e5d9229ad792ac0Structure> NewList() {
return new RL_d34e57a0f3be3dcf5e6c2af78bbca9cd();
}


} // RL_d34e57a0f3be3dcf5e6c2af78bbca9cd
}

