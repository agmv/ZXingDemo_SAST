namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (vYOSdAq8qE2Ws4NLjmhL5g)
///  <code>RC_1b25d6a078a2b54dc46acf86c7e61fc3</code> that represents <code>FillRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FillRecord
public partial struct RC_1b25d6a078a2b54dc46acf86c7e61fc3 : ITypedRecord<RC_1b25d6a078a2b54dc46acf86c7e61fc3> {
internal static readonly GlobalObjectKey IdFill = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*oNYlG6J4TbXEas+Gx+Yfww");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Fill")]
public ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure ssSTFill;


public static implicit operator ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure( RC_1b25d6a078a2b54dc46acf86c7e61fc3 r) {
return r.ssSTFill;
}

public static implicit operator RC_1b25d6a078a2b54dc46acf86c7e61fc3 (ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure r) {
RC_1b25d6a078a2b54dc46acf86c7e61fc3 res = new RC_1b25d6a078a2b54dc46acf86c7e61fc3 ();
res.ssSTFill = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_1b25d6a078a2b54dc46acf86c7e61fc3() {
OptimizedAttributes = null;
ssSTFill = new ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure();
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
    ssSTFill.OptimizedAttributes = value[0];
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
ssSTFill.Read( r, ref index);
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
public void ReadIM(RC_1b25d6a078a2b54dc46acf86c7e61fc3 r) {
this = r;
}


public static bool operator == (RC_1b25d6a078a2b54dc46acf86c7e61fc3 a, RC_1b25d6a078a2b54dc46acf86c7e61fc3 b) {
if (a.ssSTFill != b.ssSTFill) return false;
return true;
}

public static bool operator != (RC_1b25d6a078a2b54dc46acf86c7e61fc3 a, RC_1b25d6a078a2b54dc46acf86c7e61fc3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1b25d6a078a2b54dc46acf86c7e61fc3)) return false;
return (this == (RC_1b25d6a078a2b54dc46acf86c7e61fc3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFill.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFill.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFill.InternalRecursiveSave();
}


public RC_1b25d6a078a2b54dc46acf86c7e61fc3 Duplicate() {
RC_1b25d6a078a2b54dc46acf86c7e61fc3 t;
t.ssSTFill = (ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure)this.ssSTFill.Duplicate();
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
if (head == "fill") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Fill")) variable.Value = ssSTFill; else variable.Optimized = true;
variable.SetFieldName("fill");
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
if (key == IdFill) {
return ssSTFill;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFill.Key.AsGuid) {
return ssSTFill;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFill.FillFromOther((IRecord) other.AttributeGet(IdFill));
}
} // RC_1b25d6a078a2b54dc46acf86c7e61fc3
/// <summary>
/// RecordList type <code>FillRecordList</code> that represents a record list of <code>Fill</code>
/// </summary>
public partial class RL_f5728e3766cfe781fac6422ec4947dc0 : GenericRecordList<RC_1b25d6a078a2b54dc46acf86c7e61fc3>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_1b25d6a078a2b54dc46acf86c7e61fc3 GetElementDefaultValue() {
return new RC_1b25d6a078a2b54dc46acf86c7e61fc3();
}

public T[] ToArray<T>(Func<RC_1b25d6a078a2b54dc46acf86c7e61fc3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f5728e3766cfe781fac6422ec4947dc0 recordList, Func<RC_1b25d6a078a2b54dc46acf86c7e61fc3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f5728e3766cfe781fac6422ec4947dc0(RC_1b25d6a078a2b54dc46acf86c7e61fc3[] array) {
  RL_f5728e3766cfe781fac6422ec4947dc0 result = new RL_f5728e3766cfe781fac6422ec4947dc0();
result.InnerFromArray(array);
    return result;
}

public static RL_f5728e3766cfe781fac6422ec4947dc0 ToList<T>(T[] array, Func <T, RC_1b25d6a078a2b54dc46acf86c7e61fc3> converter) {
  RL_f5728e3766cfe781fac6422ec4947dc0 result = new RL_f5728e3766cfe781fac6422ec4947dc0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f5728e3766cfe781fac6422ec4947dc0 FromRestList<T>(RestList<T> restList, Func <T, RC_1b25d6a078a2b54dc46acf86c7e61fc3> converter) {
  RL_f5728e3766cfe781fac6422ec4947dc0 result = new RL_f5728e3766cfe781fac6422ec4947dc0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f5728e3766cfe781fac6422ec4947dc0() : base() {
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
protected override OSList<RC_1b25d6a078a2b54dc46acf86c7e61fc3> NewList() {
return new RL_f5728e3766cfe781fac6422ec4947dc0();
}


} // RL_f5728e3766cfe781fac6422ec4947dc0
}

