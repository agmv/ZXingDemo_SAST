namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (6z56daDDn0WQTRyP66OJtQ)
///  <code>RC_27d8031b19e05deba9a159874d88bc75</code> that represent
/// s <code>OptionalSearchPlacesConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: OptionalSearchPlacesConfigsRecord
public partial struct RC_27d8031b19e05deba9a159874d88bc75 : ITypedRecord<RC_27d8031b19e05deba9a159874d88bc75> {
internal static readonly GlobalObjectKey IdOptionalSearchPlacesConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GwPYJ+AZ612poVmHTYi8dQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("OptionalSearchPlacesConfigs")]
public ST_7cd861eaa819851d6fba6d8150ed8cc1Structure ssSTOptionalSearchPlacesConfigs;


public static implicit operator ST_7cd861eaa819851d6fba6d8150ed8cc1Structure( RC_27d8031b19e05deba9a159874d88bc75 r) {
return r.ssSTOptionalSearchPlacesConfigs;
}

public static implicit operator RC_27d8031b19e05deba9a159874d88bc75 (ST_7cd861eaa819851d6fba6d8150ed8cc1Structure r) {
RC_27d8031b19e05deba9a159874d88bc75 res = new RC_27d8031b19e05deba9a159874d88bc75 ();
res.ssSTOptionalSearchPlacesConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_27d8031b19e05deba9a159874d88bc75() {
OptimizedAttributes = null;
ssSTOptionalSearchPlacesConfigs = new ST_7cd861eaa819851d6fba6d8150ed8cc1Structure();
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
    ssSTOptionalSearchPlacesConfigs.OptimizedAttributes = value[0];
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
ssSTOptionalSearchPlacesConfigs.Read( r, ref index);
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
public void ReadIM(RC_27d8031b19e05deba9a159874d88bc75 r) {
this = r;
}


public static bool operator == (RC_27d8031b19e05deba9a159874d88bc75 a, RC_27d8031b19e05deba9a159874d88bc75 b) {
if (a.ssSTOptionalSearchPlacesConfigs != b.ssSTOptionalSearchPlacesConfigs) return false;
return true;
}

public static bool operator != (RC_27d8031b19e05deba9a159874d88bc75 a, RC_27d8031b19e05deba9a159874d88bc75 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_27d8031b19e05deba9a159874d88bc75)) return false;
return (this == (RC_27d8031b19e05deba9a159874d88bc75)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOptionalSearchPlacesConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOptionalSearchPlacesConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOptionalSearchPlacesConfigs.InternalRecursiveSave();
}


public RC_27d8031b19e05deba9a159874d88bc75 Duplicate() {
RC_27d8031b19e05deba9a159874d88bc75 t;
t.ssSTOptionalSearchPlacesConfigs = (ST_7cd861eaa819851d6fba6d8150ed8cc1Structure)this.ssSTOptionalSearchPlacesConfigs.Duplicate();
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
if (head == "optionalsearchplacesconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OptionalSearchPlacesConfigs")) variable.Value = ssSTOptionalSearchPlacesConfigs; else variable.Optimized = true;
variable.SetFieldName("optionalsearchplacesconfigs");
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
if (key == IdOptionalSearchPlacesConfigs) {
return ssSTOptionalSearchPlacesConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOptionalSearchPlacesConfigs.Key.AsGuid) {
return ssSTOptionalSearchPlacesConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOptionalSearchPlacesConfigs.FillFromOther((IRecord) other.AttributeGet(IdOptionalSearchPlacesConfigs));
}
} // RC_27d8031b19e05deba9a159874d88bc75
/// <summary>
/// RecordList type <code>OptionalSearchPlacesConfigsRecordList</code> that represents a record list of
///  <code>OptionalSearchPlacesConfigs</code>
/// </summary>
public partial class RL_bc2dda2039d1adf3e3d1dd13979b4dc2 : GenericRecordList<RC_27d8031b19e05deba9a159874d88bc75>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_27d8031b19e05deba9a159874d88bc75 GetElementDefaultValue() {
return new RC_27d8031b19e05deba9a159874d88bc75();
}

public T[] ToArray<T>(Func<RC_27d8031b19e05deba9a159874d88bc75, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bc2dda2039d1adf3e3d1dd13979b4dc2 recordList, Func<RC_27d8031b19e05deba9a159874d88bc75, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bc2dda2039d1adf3e3d1dd13979b4dc2(RC_27d8031b19e05deba9a159874d88bc75[] array) {
  RL_bc2dda2039d1adf3e3d1dd13979b4dc2 result = new RL_bc2dda2039d1adf3e3d1dd13979b4dc2();
result.InnerFromArray(array);
    return result;
}

public static RL_bc2dda2039d1adf3e3d1dd13979b4dc2 ToList<T>(T[] array, Func <T, RC_27d8031b19e05deba9a159874d88bc75> converter) {
  RL_bc2dda2039d1adf3e3d1dd13979b4dc2 result = new RL_bc2dda2039d1adf3e3d1dd13979b4dc2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bc2dda2039d1adf3e3d1dd13979b4dc2 FromRestList<T>(RestList<T> restList, Func <T, RC_27d8031b19e05deba9a159874d88bc75> converter) {
  RL_bc2dda2039d1adf3e3d1dd13979b4dc2 result = new RL_bc2dda2039d1adf3e3d1dd13979b4dc2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bc2dda2039d1adf3e3d1dd13979b4dc2() : base() {
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
protected override OSList<RC_27d8031b19e05deba9a159874d88bc75> NewList() {
return new RL_bc2dda2039d1adf3e3d1dd13979b4dc2();
}


} // RL_bc2dda2039d1adf3e3d1dd13979b4dc2
}

