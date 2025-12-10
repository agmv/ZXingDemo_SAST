namespace ssZXingLibDemo.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (klhePyX8K0CmO7aezGr06w)
///  <code>RC_53f0d7ad72d5d8edb7688d7ec561c618</code> that represents <code>ContactRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ContactRecord
public partial struct RC_53f0d7ad72d5d8edb7688d7ec561c618 : ITypedRecord<RC_53f0d7ad72d5d8edb7688d7ec561c618>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdContact = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rdfwU9Vy7di3aI1+xWHGGA");

[System.Xml.Serialization.XmlElement("Contact")]
public ST_10cb4adb0f851163080c748983a654c9Structure ssSTContact;


public static implicit operator ST_10cb4adb0f851163080c748983a654c9Structure( RC_53f0d7ad72d5d8edb7688d7ec561c618 r) {
return r.ssSTContact;
}

public static implicit operator RC_53f0d7ad72d5d8edb7688d7ec561c618 (ST_10cb4adb0f851163080c748983a654c9Structure r) {
RC_53f0d7ad72d5d8edb7688d7ec561c618 res = new RC_53f0d7ad72d5d8edb7688d7ec561c618 ();
res.ssSTContact = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_53f0d7ad72d5d8edb7688d7ec561c618() {
OptimizedAttributes = null;
ssSTContact = new ST_10cb4adb0f851163080c748983a654c9Structure();
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
    ssSTContact.OptimizedAttributes = value[0];
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
ssSTContact.Read( r, ref index);
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
public void ReadIM(RC_53f0d7ad72d5d8edb7688d7ec561c618 r) {
this = r;
}


public static bool operator == (RC_53f0d7ad72d5d8edb7688d7ec561c618 a, RC_53f0d7ad72d5d8edb7688d7ec561c618 b) {
if (a.ssSTContact != b.ssSTContact) return false;
return true;
}

public static bool operator != (RC_53f0d7ad72d5d8edb7688d7ec561c618 a, RC_53f0d7ad72d5d8edb7688d7ec561c618 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_53f0d7ad72d5d8edb7688d7ec561c618)) return false;
return (this == (RC_53f0d7ad72d5d8edb7688d7ec561c618)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTContact.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTContact.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTContact.InternalRecursiveSave();
}


public RC_53f0d7ad72d5d8edb7688d7ec561c618 Duplicate() {
RC_53f0d7ad72d5d8edb7688d7ec561c618 t;
t.ssSTContact = (ST_10cb4adb0f851163080c748983a654c9Structure)this.ssSTContact.Duplicate();
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
if (head == "contact") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Contact")) variable.Value = ssSTContact; else variable.Optimized = true;
variable.SetFieldName("contact");
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
if (key == IdContact) {
return ssSTContact;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdContact.Key.AsGuid) {
return ssSTContact;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTContact.FillFromOther((IRecord) other.AttributeGet(IdContact));
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSTContact.CopyFrom((OutSystems.Application.Extensibility.DataTypes.IRecord) other.GetAttribute(IdContact.Key.AsGuid));
}
} // RC_53f0d7ad72d5d8edb7688d7ec561c618
/// <summary>
/// RecordList type <code>ContactRecordList</code> that represents a record list of
///  <code>Contact</code>
/// </summary>
public partial class RL_28cbc3340315d84f4374a7ff9a84f74b : GenericRecordList<RC_53f0d7ad72d5d8edb7688d7ec561c618>, IEnumerable, IEnumerator {

protected override RC_53f0d7ad72d5d8edb7688d7ec561c618 GetElementDefaultValue() {
return new RC_53f0d7ad72d5d8edb7688d7ec561c618();
}

public T[] ToArray<T>(Func<RC_53f0d7ad72d5d8edb7688d7ec561c618, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_28cbc3340315d84f4374a7ff9a84f74b recordList, Func<RC_53f0d7ad72d5d8edb7688d7ec561c618, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_28cbc3340315d84f4374a7ff9a84f74b(RC_53f0d7ad72d5d8edb7688d7ec561c618[] array) {
  RL_28cbc3340315d84f4374a7ff9a84f74b result = new RL_28cbc3340315d84f4374a7ff9a84f74b();
result.InnerFromArray(array);
    return result;
}

public static RL_28cbc3340315d84f4374a7ff9a84f74b ToList<T>(T[] array, Func <T, RC_53f0d7ad72d5d8edb7688d7ec561c618> converter) {
  RL_28cbc3340315d84f4374a7ff9a84f74b result = new RL_28cbc3340315d84f4374a7ff9a84f74b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_28cbc3340315d84f4374a7ff9a84f74b FromRestList<T>(RestList<T> restList, Func <T, RC_53f0d7ad72d5d8edb7688d7ec561c618> converter) {
  RL_28cbc3340315d84f4374a7ff9a84f74b result = new RL_28cbc3340315d84f4374a7ff9a84f74b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_28cbc3340315d84f4374a7ff9a84f74b() : base() {
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
protected override OSList<RC_53f0d7ad72d5d8edb7688d7ec561c618> NewList() {
return new RL_28cbc3340315d84f4374a7ff9a84f74b();
}


} // RL_28cbc3340315d84f4374a7ff9a84f74b
}

