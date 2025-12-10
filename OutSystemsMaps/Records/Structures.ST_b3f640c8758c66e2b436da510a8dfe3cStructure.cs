namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Internal_DrawCircle_Shape (Nz2Hp6_vIkeq41Y2qRc3zQ)
///  <code>ST_b3f640c8758c66e2b436da510a8dfe3cStructure</code> that represent
/// s <code>Internal_DrawCircle_Shape</code> <p>Description: Structure that helps defining the shape of
///  the Circle drawed (contains the location and radius), that is returned by the OnDrawingChang
/// e event.</p>
/// </summary>
// Name: Internal_DrawCircle_Shape
public partial struct ST_b3f640c8758c66e2b436da510a8dfe3cStructure : ITypedRecord<ST_b3f640c8758c66e2b436da510a8dfe3cStructure> {
internal static readonly GlobalObjectKey IdLocation = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*slG9QA3OAUCzobaVDK1SIw");
internal static readonly GlobalObjectKey IdRadius = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*BGEE5non70+5FOgGcL9BiA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Location")]
public string ssLocation;

[System.Xml.Serialization.XmlElement("Radius")]
public decimal ssRadius;


public BitArray OptimizedAttributes;

public ST_b3f640c8758c66e2b436da510a8dfe3cStructure() {
OptimizedAttributes = null;
ssLocation = "";
ssRadius = 0.0M;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssLocation = r.ReadText(index++, "Internal_DrawCircle_Shape.Location", "");
ssRadius = r.ReadDecimal(index++, "Internal_DrawCircle_Shape.Radius", 0.0M);
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
public void ReadIM(ST_b3f640c8758c66e2b436da510a8dfe3cStructure r) {
this = r;
}


public static bool operator == (ST_b3f640c8758c66e2b436da510a8dfe3cStructure a, ST_b3f640c8758c66e2b436da510a8dfe3cStructure b) {
if (a.ssLocation != b.ssLocation) return false;
if (a.ssRadius != b.ssRadius) return false;
return true;
}

public static bool operator != (ST_b3f640c8758c66e2b436da510a8dfe3cStructure a, ST_b3f640c8758c66e2b436da510a8dfe3cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b3f640c8758c66e2b436da510a8dfe3cStructure)) return false;
return (this == (ST_b3f640c8758c66e2b436da510a8dfe3cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLocation.GetHashCode()
 ^ ssRadius.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_b3f640c8758c66e2b436da510a8dfe3cStructure Duplicate() {
ST_b3f640c8758c66e2b436da510a8dfe3cStructure t;
t.ssLocation = this.ssLocation;
t.ssRadius = this.ssRadius;
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
if (head == "location") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Location")) variable.Value = ssLocation; else variable.Optimized = true;
} else if (head == "radius") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Radius")) variable.Value = ssRadius; else variable.Optimized = true;
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
if (key == IdLocation) {
return ssLocation;
}
if (key == IdRadius) {
return ssRadius;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLocation.Key.AsGuid) {
return ssLocation;
}
if (attributeKey == IdRadius.Key.AsGuid) {
return ssRadius;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssLocation = (string) other.AttributeGet(IdLocation);
ssRadius = (decimal) other.AttributeGet(IdRadius);
}
} // ST_b3f640c8758c66e2b436da510a8dfe3cStructure
/// <summary>
/// RecordList type <code>Internal_DrawCircle_ShapeList</code> that represents a record list of
///  <code>Internal_DrawCircle_Shape</code>
/// </summary>
public partial class RL_96898bc542883716a6d11da0115bf734 : GenericRecordList<ST_b3f640c8758c66e2b436da510a8dfe3cStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_b3f640c8758c66e2b436da510a8dfe3cStructure GetElementDefaultValue() {
return new ST_b3f640c8758c66e2b436da510a8dfe3cStructure();
}

public T[] ToArray<T>(Func<ST_b3f640c8758c66e2b436da510a8dfe3cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_96898bc542883716a6d11da0115bf734 recordList, Func<ST_b3f640c8758c66e2b436da510a8dfe3cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_96898bc542883716a6d11da0115bf734(ST_b3f640c8758c66e2b436da510a8dfe3cStructure[] array) {
  RL_96898bc542883716a6d11da0115bf734 result = new RL_96898bc542883716a6d11da0115bf734();
result.InnerFromArray(array);
    return result;
}

public static RL_96898bc542883716a6d11da0115bf734 ToList<T>(T[] array, Func <T, ST_b3f640c8758c66e2b436da510a8dfe3cStructure> converter) {
  RL_96898bc542883716a6d11da0115bf734 result = new RL_96898bc542883716a6d11da0115bf734();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_96898bc542883716a6d11da0115bf734 FromRestList<T>(RestList<T> restList, Func <T, ST_b3f640c8758c66e2b436da510a8dfe3cStructure> converter) {
  RL_96898bc542883716a6d11da0115bf734 result = new RL_96898bc542883716a6d11da0115bf734();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_96898bc542883716a6d11da0115bf734() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b3f640c8758c66e2b436da510a8dfe3cStructure> NewList() {
return new RL_96898bc542883716a6d11da0115bf734();
}


} // RL_96898bc542883716a6d11da0115bf734
}

