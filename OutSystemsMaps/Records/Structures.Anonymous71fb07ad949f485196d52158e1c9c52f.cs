namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (rQf7cZ+UUUiW1SFY4cnFLw)
///  <code>RC_afeb3af87221b535eb5e95ea10936666</code> that represent
/// s <code>Internal_ConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_ConfigsRecord
public partial struct RC_afeb3af87221b535eb5e95ea10936666 : ITypedRecord<RC_afeb3af87221b535eb5e95ea10936666> {
internal static readonly GlobalObjectKey IdInternal_Configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+DrrryFyNbXrXpXqEJNmZg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_Configs")]
public ST_78d3133d124713193d703c2644ecd39bStructure ssSTInternal_Configs;


public static implicit operator ST_78d3133d124713193d703c2644ecd39bStructure( RC_afeb3af87221b535eb5e95ea10936666 r) {
return r.ssSTInternal_Configs;
}

public static implicit operator RC_afeb3af87221b535eb5e95ea10936666 (ST_78d3133d124713193d703c2644ecd39bStructure r) {
RC_afeb3af87221b535eb5e95ea10936666 res = new RC_afeb3af87221b535eb5e95ea10936666 ();
res.ssSTInternal_Configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_afeb3af87221b535eb5e95ea10936666() {
OptimizedAttributes = null;
ssSTInternal_Configs = new ST_78d3133d124713193d703c2644ecd39bStructure();
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
    ssSTInternal_Configs.OptimizedAttributes = value[0];
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
ssSTInternal_Configs.Read( r, ref index);
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
public void ReadIM(RC_afeb3af87221b535eb5e95ea10936666 r) {
this = r;
}


public static bool operator == (RC_afeb3af87221b535eb5e95ea10936666 a, RC_afeb3af87221b535eb5e95ea10936666 b) {
if (a.ssSTInternal_Configs != b.ssSTInternal_Configs) return false;
return true;
}

public static bool operator != (RC_afeb3af87221b535eb5e95ea10936666 a, RC_afeb3af87221b535eb5e95ea10936666 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_afeb3af87221b535eb5e95ea10936666)) return false;
return (this == (RC_afeb3af87221b535eb5e95ea10936666)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_Configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_Configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_Configs.InternalRecursiveSave();
}


public RC_afeb3af87221b535eb5e95ea10936666 Duplicate() {
RC_afeb3af87221b535eb5e95ea10936666 t;
t.ssSTInternal_Configs = (ST_78d3133d124713193d703c2644ecd39bStructure)this.ssSTInternal_Configs.Duplicate();
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
if (head == "internal_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_Configs")) variable.Value = ssSTInternal_Configs; else variable.Optimized = true;
variable.SetFieldName("internal_configs");
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
if (key == IdInternal_Configs) {
return ssSTInternal_Configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_Configs.Key.AsGuid) {
return ssSTInternal_Configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_Configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_Configs));
}
} // RC_afeb3af87221b535eb5e95ea10936666
/// <summary>
/// RecordList type <code>Internal_ConfigsRecordList</code> that represents a record list of
///  <code>Internal_Configs</code>
/// </summary>
public partial class RL_84ec52f14adbfe6a8b7f3f76b0cd788d : GenericRecordList<RC_afeb3af87221b535eb5e95ea10936666>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_afeb3af87221b535eb5e95ea10936666 GetElementDefaultValue() {
return new RC_afeb3af87221b535eb5e95ea10936666();
}

public T[] ToArray<T>(Func<RC_afeb3af87221b535eb5e95ea10936666, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_84ec52f14adbfe6a8b7f3f76b0cd788d recordList, Func<RC_afeb3af87221b535eb5e95ea10936666, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_84ec52f14adbfe6a8b7f3f76b0cd788d(RC_afeb3af87221b535eb5e95ea10936666[] array) {
  RL_84ec52f14adbfe6a8b7f3f76b0cd788d result = new RL_84ec52f14adbfe6a8b7f3f76b0cd788d();
result.InnerFromArray(array);
    return result;
}

public static RL_84ec52f14adbfe6a8b7f3f76b0cd788d ToList<T>(T[] array, Func <T, RC_afeb3af87221b535eb5e95ea10936666> converter) {
  RL_84ec52f14adbfe6a8b7f3f76b0cd788d result = new RL_84ec52f14adbfe6a8b7f3f76b0cd788d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_84ec52f14adbfe6a8b7f3f76b0cd788d FromRestList<T>(RestList<T> restList, Func <T, RC_afeb3af87221b535eb5e95ea10936666> converter) {
  RL_84ec52f14adbfe6a8b7f3f76b0cd788d result = new RL_84ec52f14adbfe6a8b7f3f76b0cd788d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_84ec52f14adbfe6a8b7f3f76b0cd788d() : base() {
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
protected override OSList<RC_afeb3af87221b535eb5e95ea10936666> NewList() {
return new RL_84ec52f14adbfe6a8b7f3f76b0cd788d();
}


} // RL_84ec52f14adbfe6a8b7f3f76b0cd788d
}

