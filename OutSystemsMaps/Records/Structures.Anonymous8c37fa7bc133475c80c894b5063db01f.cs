namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (e_o3jDPBXEeAyJS1Bj2wHw)
///  <code>RC_7c2c1d82e3a31f1ec5d5faa260c033b7</code> that represent
/// s <code>Internal_to_provider_drawNotFilledShape_configsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_to_provider_drawNotFilledShape_configsRecord
public partial struct RC_7c2c1d82e3a31f1ec5d5faa260c033b7 : ITypedRecord<RC_7c2c1d82e3a31f1ec5d5faa260c033b7> {
internal static readonly GlobalObjectKey IdInternal_to_provider_drawNotFilledShape_configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gh0sfKPjHh_F1fqiYMAztw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_to_provider_drawNotFilledShape_configs")]
public ST_86d2610e9625abf0ecb7241e6d8099fbStructure ssSTInternal_to_provider_drawNotFilledShape_configs;


public static implicit operator ST_86d2610e9625abf0ecb7241e6d8099fbStructure( RC_7c2c1d82e3a31f1ec5d5faa260c033b7 r) {
return r.ssSTInternal_to_provider_drawNotFilledShape_configs;
}

public static implicit operator RC_7c2c1d82e3a31f1ec5d5faa260c033b7 (ST_86d2610e9625abf0ecb7241e6d8099fbStructure r) {
RC_7c2c1d82e3a31f1ec5d5faa260c033b7 res = new RC_7c2c1d82e3a31f1ec5d5faa260c033b7 ();
res.ssSTInternal_to_provider_drawNotFilledShape_configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_7c2c1d82e3a31f1ec5d5faa260c033b7() {
OptimizedAttributes = null;
ssSTInternal_to_provider_drawNotFilledShape_configs = new ST_86d2610e9625abf0ecb7241e6d8099fbStructure();
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
    ssSTInternal_to_provider_drawNotFilledShape_configs.OptimizedAttributes = value[0];
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
ssSTInternal_to_provider_drawNotFilledShape_configs.Read( r, ref index);
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
public void ReadIM(RC_7c2c1d82e3a31f1ec5d5faa260c033b7 r) {
this = r;
}


public static bool operator == (RC_7c2c1d82e3a31f1ec5d5faa260c033b7 a, RC_7c2c1d82e3a31f1ec5d5faa260c033b7 b) {
if (a.ssSTInternal_to_provider_drawNotFilledShape_configs != b.ssSTInternal_to_provider_drawNotFilledShape_configs) return false;
return true;
}

public static bool operator != (RC_7c2c1d82e3a31f1ec5d5faa260c033b7 a, RC_7c2c1d82e3a31f1ec5d5faa260c033b7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7c2c1d82e3a31f1ec5d5faa260c033b7)) return false;
return (this == (RC_7c2c1d82e3a31f1ec5d5faa260c033b7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_to_provider_drawNotFilledShape_configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_to_provider_drawNotFilledShape_configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_to_provider_drawNotFilledShape_configs.InternalRecursiveSave();
}


public RC_7c2c1d82e3a31f1ec5d5faa260c033b7 Duplicate() {
RC_7c2c1d82e3a31f1ec5d5faa260c033b7 t;
t.ssSTInternal_to_provider_drawNotFilledShape_configs = (ST_86d2610e9625abf0ecb7241e6d8099fbStructure)this.ssSTInternal_to_provider_drawNotFilledShape_configs.Duplicate();
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
if (head == "internal_to_provider_drawnotfilledshape_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_to_provider_drawNotFilledShape_configs")) variable.Value = ssSTInternal_to_provider_drawNotFilledShape_configs; else variable.Optimized = true;
variable.SetFieldName("internal_to_provider_drawnotfilledshape_configs");
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
if (key == IdInternal_to_provider_drawNotFilledShape_configs) {
return ssSTInternal_to_provider_drawNotFilledShape_configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_to_provider_drawNotFilledShape_configs.Key.AsGuid) {
return ssSTInternal_to_provider_drawNotFilledShape_configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_to_provider_drawNotFilledShape_configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_to_provider_drawNotFilledShape_configs));
}
} // RC_7c2c1d82e3a31f1ec5d5faa260c033b7
/// <summary>
/// RecordList type <code>Internal_to_provider_drawNotFilledShape_configsRecordList</code> that
///  represents a record list of <code>Internal_to_provider_drawNotFilledShape_configs</code>
/// </summary>
public partial class RL_70b91cf4f57884d5f12e0e5564148afa : GenericRecordList<RC_7c2c1d82e3a31f1ec5d5faa260c033b7>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_7c2c1d82e3a31f1ec5d5faa260c033b7 GetElementDefaultValue() {
return new RC_7c2c1d82e3a31f1ec5d5faa260c033b7();
}

public T[] ToArray<T>(Func<RC_7c2c1d82e3a31f1ec5d5faa260c033b7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_70b91cf4f57884d5f12e0e5564148afa recordList, Func<RC_7c2c1d82e3a31f1ec5d5faa260c033b7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_70b91cf4f57884d5f12e0e5564148afa(RC_7c2c1d82e3a31f1ec5d5faa260c033b7[] array) {
  RL_70b91cf4f57884d5f12e0e5564148afa result = new RL_70b91cf4f57884d5f12e0e5564148afa();
result.InnerFromArray(array);
    return result;
}

public static RL_70b91cf4f57884d5f12e0e5564148afa ToList<T>(T[] array, Func <T, RC_7c2c1d82e3a31f1ec5d5faa260c033b7> converter) {
  RL_70b91cf4f57884d5f12e0e5564148afa result = new RL_70b91cf4f57884d5f12e0e5564148afa();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_70b91cf4f57884d5f12e0e5564148afa FromRestList<T>(RestList<T> restList, Func <T, RC_7c2c1d82e3a31f1ec5d5faa260c033b7> converter) {
  RL_70b91cf4f57884d5f12e0e5564148afa result = new RL_70b91cf4f57884d5f12e0e5564148afa();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_70b91cf4f57884d5f12e0e5564148afa() : base() {
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
protected override OSList<RC_7c2c1d82e3a31f1ec5d5faa260c033b7> NewList() {
return new RL_70b91cf4f57884d5f12e0e5564148afa();
}


} // RL_70b91cf4f57884d5f12e0e5564148afa
}

