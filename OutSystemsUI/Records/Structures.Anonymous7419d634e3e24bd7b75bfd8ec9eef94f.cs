namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (NNYZdOLj10u3W_2Oye75Tw)
///  <code>RC_30bb0fd6be769d5d6630c4c9fbd19c43</code> that represent
/// s <code>DropdownServerSideItem_InternalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: DropdownServerSideItem_InternalConfigsRecord
public partial struct RC_30bb0fd6be769d5d6630c4c9fbd19c43 : ITypedRecord<RC_30bb0fd6be769d5d6630c4c9fbd19c43> {
internal static readonly GlobalObjectKey IdDropdownServerSideItem_InternalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1g+7MHa+XZ1mMMTJ+9GcQw");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DropdownServerSideItem_InternalConfigs")]
public ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure ssSTDropdownServerSideItem_InternalConfigs;


public static implicit operator ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure( RC_30bb0fd6be769d5d6630c4c9fbd19c43 r) {
return r.ssSTDropdownServerSideItem_InternalConfigs;
}

public static implicit operator RC_30bb0fd6be769d5d6630c4c9fbd19c43 (ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure r) {
RC_30bb0fd6be769d5d6630c4c9fbd19c43 res = new RC_30bb0fd6be769d5d6630c4c9fbd19c43 ();
res.ssSTDropdownServerSideItem_InternalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_30bb0fd6be769d5d6630c4c9fbd19c43() {
OptimizedAttributes = null;
ssSTDropdownServerSideItem_InternalConfigs = new ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure();
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
    ssSTDropdownServerSideItem_InternalConfigs.OptimizedAttributes = value[0];
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
ssSTDropdownServerSideItem_InternalConfigs.Read( r, ref index);
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
public void ReadIM(RC_30bb0fd6be769d5d6630c4c9fbd19c43 r) {
this = r;
}


public static bool operator == (RC_30bb0fd6be769d5d6630c4c9fbd19c43 a, RC_30bb0fd6be769d5d6630c4c9fbd19c43 b) {
if (a.ssSTDropdownServerSideItem_InternalConfigs != b.ssSTDropdownServerSideItem_InternalConfigs) return false;
return true;
}

public static bool operator != (RC_30bb0fd6be769d5d6630c4c9fbd19c43 a, RC_30bb0fd6be769d5d6630c4c9fbd19c43 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_30bb0fd6be769d5d6630c4c9fbd19c43)) return false;
return (this == (RC_30bb0fd6be769d5d6630c4c9fbd19c43)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDropdownServerSideItem_InternalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDropdownServerSideItem_InternalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDropdownServerSideItem_InternalConfigs.InternalRecursiveSave();
}


public RC_30bb0fd6be769d5d6630c4c9fbd19c43 Duplicate() {
RC_30bb0fd6be769d5d6630c4c9fbd19c43 t;
t.ssSTDropdownServerSideItem_InternalConfigs = (ST_6af81a2c1989c9b6ed62295dfa4c4e65Structure)this.ssSTDropdownServerSideItem_InternalConfigs.Duplicate();
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
if (head == "dropdownserversideitem_internalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DropdownServerSideItem_InternalConfigs")) variable.Value = ssSTDropdownServerSideItem_InternalConfigs; else variable.Optimized = true;
variable.SetFieldName("dropdownserversideitem_internalconfigs");
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
if (key == IdDropdownServerSideItem_InternalConfigs) {
return ssSTDropdownServerSideItem_InternalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDropdownServerSideItem_InternalConfigs.Key.AsGuid) {
return ssSTDropdownServerSideItem_InternalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDropdownServerSideItem_InternalConfigs.FillFromOther((IRecord) other.AttributeGet(IdDropdownServerSideItem_InternalConfigs));
}
} // RC_30bb0fd6be769d5d6630c4c9fbd19c43
/// <summary>
/// RecordList type <code>DropdownServerSideItem_InternalConfigsRecordList</code> that represents a
///  record list of <code>DropdownServerSideItem_InternalConfigs</code>
/// </summary>
public partial class RL_026daaa16d9a7c82ba45988292e548e6 : GenericRecordList<RC_30bb0fd6be769d5d6630c4c9fbd19c43>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_30bb0fd6be769d5d6630c4c9fbd19c43 GetElementDefaultValue() {
return new RC_30bb0fd6be769d5d6630c4c9fbd19c43();
}

public T[] ToArray<T>(Func<RC_30bb0fd6be769d5d6630c4c9fbd19c43, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_026daaa16d9a7c82ba45988292e548e6 recordList, Func<RC_30bb0fd6be769d5d6630c4c9fbd19c43, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_026daaa16d9a7c82ba45988292e548e6(RC_30bb0fd6be769d5d6630c4c9fbd19c43[] array) {
  RL_026daaa16d9a7c82ba45988292e548e6 result = new RL_026daaa16d9a7c82ba45988292e548e6();
result.InnerFromArray(array);
    return result;
}

public static RL_026daaa16d9a7c82ba45988292e548e6 ToList<T>(T[] array, Func <T, RC_30bb0fd6be769d5d6630c4c9fbd19c43> converter) {
  RL_026daaa16d9a7c82ba45988292e548e6 result = new RL_026daaa16d9a7c82ba45988292e548e6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_026daaa16d9a7c82ba45988292e548e6 FromRestList<T>(RestList<T> restList, Func <T, RC_30bb0fd6be769d5d6630c4c9fbd19c43> converter) {
  RL_026daaa16d9a7c82ba45988292e548e6 result = new RL_026daaa16d9a7c82ba45988292e548e6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_026daaa16d9a7c82ba45988292e548e6() : base() {
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
protected override OSList<RC_30bb0fd6be769d5d6630c4c9fbd19c43> NewList() {
return new RL_026daaa16d9a7c82ba45988292e548e6();
}


} // RL_026daaa16d9a7c82ba45988292e548e6
}

