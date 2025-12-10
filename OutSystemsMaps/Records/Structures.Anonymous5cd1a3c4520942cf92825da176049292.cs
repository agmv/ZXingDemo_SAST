namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (xKPRXAlSz0KSgl2hdgSSkg)
///  <code>RC_a9d3f6b226a37f22bb219f2bf72cf852</code> that represent
/// s <code>Internal_DrawMarker_ConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_DrawMarker_ConfigsRecord
public partial struct RC_a9d3f6b226a37f22bb219f2bf72cf852 : ITypedRecord<RC_a9d3f6b226a37f22bb219f2bf72cf852> {
internal static readonly GlobalObjectKey IdInternal_DrawMarker_Configs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*svbTqaMmIn+7IZ8r9yz4Ug");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_DrawMarker_Configs")]
public ST_60018fad8b9768f5644ffadf96040a85Structure ssSTInternal_DrawMarker_Configs;


public static implicit operator ST_60018fad8b9768f5644ffadf96040a85Structure( RC_a9d3f6b226a37f22bb219f2bf72cf852 r) {
return r.ssSTInternal_DrawMarker_Configs;
}

public static implicit operator RC_a9d3f6b226a37f22bb219f2bf72cf852 (ST_60018fad8b9768f5644ffadf96040a85Structure r) {
RC_a9d3f6b226a37f22bb219f2bf72cf852 res = new RC_a9d3f6b226a37f22bb219f2bf72cf852 ();
res.ssSTInternal_DrawMarker_Configs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a9d3f6b226a37f22bb219f2bf72cf852() {
OptimizedAttributes = null;
ssSTInternal_DrawMarker_Configs = new ST_60018fad8b9768f5644ffadf96040a85Structure();
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
    ssSTInternal_DrawMarker_Configs.OptimizedAttributes = value[0];
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
ssSTInternal_DrawMarker_Configs.Read( r, ref index);
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
public void ReadIM(RC_a9d3f6b226a37f22bb219f2bf72cf852 r) {
this = r;
}


public static bool operator == (RC_a9d3f6b226a37f22bb219f2bf72cf852 a, RC_a9d3f6b226a37f22bb219f2bf72cf852 b) {
if (a.ssSTInternal_DrawMarker_Configs != b.ssSTInternal_DrawMarker_Configs) return false;
return true;
}

public static bool operator != (RC_a9d3f6b226a37f22bb219f2bf72cf852 a, RC_a9d3f6b226a37f22bb219f2bf72cf852 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a9d3f6b226a37f22bb219f2bf72cf852)) return false;
return (this == (RC_a9d3f6b226a37f22bb219f2bf72cf852)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_DrawMarker_Configs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_DrawMarker_Configs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_DrawMarker_Configs.InternalRecursiveSave();
}


public RC_a9d3f6b226a37f22bb219f2bf72cf852 Duplicate() {
RC_a9d3f6b226a37f22bb219f2bf72cf852 t;
t.ssSTInternal_DrawMarker_Configs = (ST_60018fad8b9768f5644ffadf96040a85Structure)this.ssSTInternal_DrawMarker_Configs.Duplicate();
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
if (head == "internal_drawmarker_configs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_DrawMarker_Configs")) variable.Value = ssSTInternal_DrawMarker_Configs; else variable.Optimized = true;
variable.SetFieldName("internal_drawmarker_configs");
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
if (key == IdInternal_DrawMarker_Configs) {
return ssSTInternal_DrawMarker_Configs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_DrawMarker_Configs.Key.AsGuid) {
return ssSTInternal_DrawMarker_Configs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_DrawMarker_Configs.FillFromOther((IRecord) other.AttributeGet(IdInternal_DrawMarker_Configs));
}
} // RC_a9d3f6b226a37f22bb219f2bf72cf852
/// <summary>
/// RecordList type <code>Internal_DrawMarker_ConfigsRecordList</code> that represents a record list of
///  <code>Internal_DrawMarker_Configs</code>
/// </summary>
public partial class RL_3c18a06a0b0cb2ff9323e9e683293f73 : GenericRecordList<RC_a9d3f6b226a37f22bb219f2bf72cf852>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_a9d3f6b226a37f22bb219f2bf72cf852 GetElementDefaultValue() {
return new RC_a9d3f6b226a37f22bb219f2bf72cf852();
}

public T[] ToArray<T>(Func<RC_a9d3f6b226a37f22bb219f2bf72cf852, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3c18a06a0b0cb2ff9323e9e683293f73 recordList, Func<RC_a9d3f6b226a37f22bb219f2bf72cf852, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3c18a06a0b0cb2ff9323e9e683293f73(RC_a9d3f6b226a37f22bb219f2bf72cf852[] array) {
  RL_3c18a06a0b0cb2ff9323e9e683293f73 result = new RL_3c18a06a0b0cb2ff9323e9e683293f73();
result.InnerFromArray(array);
    return result;
}

public static RL_3c18a06a0b0cb2ff9323e9e683293f73 ToList<T>(T[] array, Func <T, RC_a9d3f6b226a37f22bb219f2bf72cf852> converter) {
  RL_3c18a06a0b0cb2ff9323e9e683293f73 result = new RL_3c18a06a0b0cb2ff9323e9e683293f73();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3c18a06a0b0cb2ff9323e9e683293f73 FromRestList<T>(RestList<T> restList, Func <T, RC_a9d3f6b226a37f22bb219f2bf72cf852> converter) {
  RL_3c18a06a0b0cb2ff9323e9e683293f73 result = new RL_3c18a06a0b0cb2ff9323e9e683293f73();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3c18a06a0b0cb2ff9323e9e683293f73() : base() {
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
protected override OSList<RC_a9d3f6b226a37f22bb219f2bf72cf852> NewList() {
return new RL_3c18a06a0b0cb2ff9323e9e683293f73();
}


} // RL_3c18a06a0b0cb2ff9323e9e683293f73
}

