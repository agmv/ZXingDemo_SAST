namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (KYwowmLo6EOmPWs6AyVyEw)
///  <code>RC_98ce383abd92f0f4c51d49a4fcc3bfcc</code> that represent
/// s <code>IsDisableIsRemoveItemsRecord</code> <p>Description: </p>
/// </summary>
// Name: IsDisableIsRemoveItemsRecord
public partial struct RC_98ce383abd92f0f4c51d49a4fcc3bfcc : ITypedRecord<RC_98ce383abd92f0f4c51d49a4fcc3bfcc> {
internal static readonly GlobalObjectKey IdIsDisable = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ih9aj+1st57eixE+gLZXRg");
internal static readonly GlobalObjectKey IdIsRemoveItems = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*b09K7xs_A9j0sPo5k4PIVA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("IsDisable")]
public bool ssIsDisable;

[System.Xml.Serialization.XmlElement("IsRemoveItems")]
public bool ssIsRemoveItems;


public BitArray OptimizedAttributes;

public RC_98ce383abd92f0f4c51d49a4fcc3bfcc() {
OptimizedAttributes = null;
ssIsDisable = false;
ssIsRemoveItems = false;
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
ssIsDisable = r.ReadBoolean(index++, "IsDisableIsRemoveItemsRecord.IsDisable", false);
ssIsRemoveItems = r.ReadBoolean(index++, "IsDisableIsRemoveItemsRecord.IsRemoveItems", false);
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
public void ReadIM(RC_98ce383abd92f0f4c51d49a4fcc3bfcc r) {
this = r;
}


public static bool operator == (RC_98ce383abd92f0f4c51d49a4fcc3bfcc a, RC_98ce383abd92f0f4c51d49a4fcc3bfcc b) {
if (a.ssIsDisable != b.ssIsDisable) return false;
if (a.ssIsRemoveItems != b.ssIsRemoveItems) return false;
return true;
}

public static bool operator != (RC_98ce383abd92f0f4c51d49a4fcc3bfcc a, RC_98ce383abd92f0f4c51d49a4fcc3bfcc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_98ce383abd92f0f4c51d49a4fcc3bfcc)) return false;
return (this == (RC_98ce383abd92f0f4c51d49a4fcc3bfcc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIsDisable.GetHashCode()
 ^ ssIsRemoveItems.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_98ce383abd92f0f4c51d49a4fcc3bfcc Duplicate() {
RC_98ce383abd92f0f4c51d49a4fcc3bfcc t;
t.ssIsDisable = this.ssIsDisable;
t.ssIsRemoveItems = this.ssIsRemoveItems;
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
if (head == "isdisable") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDisable")) variable.Value = ssIsDisable; else variable.Optimized = true;
} else if (head == "isremoveitems") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsRemoveItems")) variable.Value = ssIsRemoveItems; else variable.Optimized = true;
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
if (key == IdIsDisable) {
return ssIsDisable;
}
if (key == IdIsRemoveItems) {
return ssIsRemoveItems;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIsDisable.Key.AsGuid) {
return ssIsDisable;
}
if (attributeKey == IdIsRemoveItems.Key.AsGuid) {
return ssIsRemoveItems;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIsDisable = (bool) other.AttributeGet(IdIsDisable);
ssIsRemoveItems = (bool) other.AttributeGet(IdIsRemoveItems);
}
} // RC_98ce383abd92f0f4c51d49a4fcc3bfcc
/// <summary>
/// RecordList type <code>IsDisableIsRemoveItemsRecordList</code> that represents a record list of
///  <code>Boolean, Boolean</code>
/// </summary>
public partial class RL_8998aef405ae5fbccecf77293a72a28a : GenericRecordList<RC_98ce383abd92f0f4c51d49a4fcc3bfcc>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_98ce383abd92f0f4c51d49a4fcc3bfcc GetElementDefaultValue() {
return new RC_98ce383abd92f0f4c51d49a4fcc3bfcc();
}

public T[] ToArray<T>(Func<RC_98ce383abd92f0f4c51d49a4fcc3bfcc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8998aef405ae5fbccecf77293a72a28a recordList, Func<RC_98ce383abd92f0f4c51d49a4fcc3bfcc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8998aef405ae5fbccecf77293a72a28a(RC_98ce383abd92f0f4c51d49a4fcc3bfcc[] array) {
  RL_8998aef405ae5fbccecf77293a72a28a result = new RL_8998aef405ae5fbccecf77293a72a28a();
result.InnerFromArray(array);
    return result;
}

public static RL_8998aef405ae5fbccecf77293a72a28a ToList<T>(T[] array, Func <T, RC_98ce383abd92f0f4c51d49a4fcc3bfcc> converter) {
  RL_8998aef405ae5fbccecf77293a72a28a result = new RL_8998aef405ae5fbccecf77293a72a28a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8998aef405ae5fbccecf77293a72a28a FromRestList<T>(RestList<T> restList, Func <T, RC_98ce383abd92f0f4c51d49a4fcc3bfcc> converter) {
  RL_8998aef405ae5fbccecf77293a72a28a result = new RL_8998aef405ae5fbccecf77293a72a28a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8998aef405ae5fbccecf77293a72a28a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_98ce383abd92f0f4c51d49a4fcc3bfcc> NewList() {
return new RL_8998aef405ae5fbccecf77293a72a28a();
}


} // RL_8998aef405ae5fbccecf77293a72a28a
}

