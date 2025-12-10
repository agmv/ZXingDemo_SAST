namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (KcPTgm0qEUGZKVAVhL+6oA)
///  <code>RC_0d7cc7bed68e0cd9bac246a9a398426e</code> that represent
/// s <code>Internal_DrawCircle_ShapeRecord</code> <p>Description: </p>
/// </summary>
// Name: Internal_DrawCircle_ShapeRecord
public partial struct RC_0d7cc7bed68e0cd9bac246a9a398426e : ITypedRecord<RC_0d7cc7bed68e0cd9bac246a9a398426e> {
internal static readonly GlobalObjectKey IdInternal_DrawCircle_Shape = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*vsd8DY7W2Qy6wkapo5hCbg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Internal_DrawCircle_Shape")]
public ST_b3f640c8758c66e2b436da510a8dfe3cStructure ssSTInternal_DrawCircle_Shape;


public static implicit operator ST_b3f640c8758c66e2b436da510a8dfe3cStructure( RC_0d7cc7bed68e0cd9bac246a9a398426e r) {
return r.ssSTInternal_DrawCircle_Shape;
}

public static implicit operator RC_0d7cc7bed68e0cd9bac246a9a398426e (ST_b3f640c8758c66e2b436da510a8dfe3cStructure r) {
RC_0d7cc7bed68e0cd9bac246a9a398426e res = new RC_0d7cc7bed68e0cd9bac246a9a398426e ();
res.ssSTInternal_DrawCircle_Shape = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_0d7cc7bed68e0cd9bac246a9a398426e() {
OptimizedAttributes = null;
ssSTInternal_DrawCircle_Shape = new ST_b3f640c8758c66e2b436da510a8dfe3cStructure();
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
    ssSTInternal_DrawCircle_Shape.OptimizedAttributes = value[0];
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
ssSTInternal_DrawCircle_Shape.Read( r, ref index);
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
public void ReadIM(RC_0d7cc7bed68e0cd9bac246a9a398426e r) {
this = r;
}


public static bool operator == (RC_0d7cc7bed68e0cd9bac246a9a398426e a, RC_0d7cc7bed68e0cd9bac246a9a398426e b) {
if (a.ssSTInternal_DrawCircle_Shape != b.ssSTInternal_DrawCircle_Shape) return false;
return true;
}

public static bool operator != (RC_0d7cc7bed68e0cd9bac246a9a398426e a, RC_0d7cc7bed68e0cd9bac246a9a398426e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0d7cc7bed68e0cd9bac246a9a398426e)) return false;
return (this == (RC_0d7cc7bed68e0cd9bac246a9a398426e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInternal_DrawCircle_Shape.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInternal_DrawCircle_Shape.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInternal_DrawCircle_Shape.InternalRecursiveSave();
}


public RC_0d7cc7bed68e0cd9bac246a9a398426e Duplicate() {
RC_0d7cc7bed68e0cd9bac246a9a398426e t;
t.ssSTInternal_DrawCircle_Shape = (ST_b3f640c8758c66e2b436da510a8dfe3cStructure)this.ssSTInternal_DrawCircle_Shape.Duplicate();
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
if (head == "internal_drawcircle_shape") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Internal_DrawCircle_Shape")) variable.Value = ssSTInternal_DrawCircle_Shape; else variable.Optimized = true;
variable.SetFieldName("internal_drawcircle_shape");
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
if (key == IdInternal_DrawCircle_Shape) {
return ssSTInternal_DrawCircle_Shape;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternal_DrawCircle_Shape.Key.AsGuid) {
return ssSTInternal_DrawCircle_Shape;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInternal_DrawCircle_Shape.FillFromOther((IRecord) other.AttributeGet(IdInternal_DrawCircle_Shape));
}
} // RC_0d7cc7bed68e0cd9bac246a9a398426e
/// <summary>
/// RecordList type <code>Internal_DrawCircle_ShapeRecordList</code> that represents a record list of
///  <code>Internal_DrawCircle_Shape</code>
/// </summary>
public partial class RL_13ca00363f7e33ac6324e85dfb3d658d : GenericRecordList<RC_0d7cc7bed68e0cd9bac246a9a398426e>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_0d7cc7bed68e0cd9bac246a9a398426e GetElementDefaultValue() {
return new RC_0d7cc7bed68e0cd9bac246a9a398426e();
}

public T[] ToArray<T>(Func<RC_0d7cc7bed68e0cd9bac246a9a398426e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_13ca00363f7e33ac6324e85dfb3d658d recordList, Func<RC_0d7cc7bed68e0cd9bac246a9a398426e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_13ca00363f7e33ac6324e85dfb3d658d(RC_0d7cc7bed68e0cd9bac246a9a398426e[] array) {
  RL_13ca00363f7e33ac6324e85dfb3d658d result = new RL_13ca00363f7e33ac6324e85dfb3d658d();
result.InnerFromArray(array);
    return result;
}

public static RL_13ca00363f7e33ac6324e85dfb3d658d ToList<T>(T[] array, Func <T, RC_0d7cc7bed68e0cd9bac246a9a398426e> converter) {
  RL_13ca00363f7e33ac6324e85dfb3d658d result = new RL_13ca00363f7e33ac6324e85dfb3d658d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_13ca00363f7e33ac6324e85dfb3d658d FromRestList<T>(RestList<T> restList, Func <T, RC_0d7cc7bed68e0cd9bac246a9a398426e> converter) {
  RL_13ca00363f7e33ac6324e85dfb3d658d result = new RL_13ca00363f7e33ac6324e85dfb3d658d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_13ca00363f7e33ac6324e85dfb3d658d() : base() {
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
protected override OSList<RC_0d7cc7bed68e0cd9bac246a9a398426e> NewList() {
return new RL_13ca00363f7e33ac6324e85dfb3d658d();
}


} // RL_13ca00363f7e33ac6324e85dfb3d658d
}

