namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (Xf8Phqj6vE6mNvhyjSRNvw)
///  <code>RC_e3b67119e4a2ce2c95244e08a29b21aa</code> that represent
/// s <code>DropdownTags_InternalConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: DropdownTags_InternalConfigsRecord
public partial struct RC_e3b67119e4a2ce2c95244e08a29b21aa : ITypedRecord<RC_e3b67119e4a2ce2c95244e08a29b21aa> {
internal static readonly GlobalObjectKey IdDropdownTags_InternalConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GXG246LkLM6VJE4Iopshqg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("DropdownTags_InternalConfigs")]
public ST_f2d4817754eec123207470e41d7a01d7Structure ssSTDropdownTags_InternalConfigs;


public static implicit operator ST_f2d4817754eec123207470e41d7a01d7Structure( RC_e3b67119e4a2ce2c95244e08a29b21aa r) {
return r.ssSTDropdownTags_InternalConfigs;
}

public static implicit operator RC_e3b67119e4a2ce2c95244e08a29b21aa (ST_f2d4817754eec123207470e41d7a01d7Structure r) {
RC_e3b67119e4a2ce2c95244e08a29b21aa res = new RC_e3b67119e4a2ce2c95244e08a29b21aa ();
res.ssSTDropdownTags_InternalConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e3b67119e4a2ce2c95244e08a29b21aa() {
OptimizedAttributes = null;
ssSTDropdownTags_InternalConfigs = new ST_f2d4817754eec123207470e41d7a01d7Structure();
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
    ssSTDropdownTags_InternalConfigs.OptimizedAttributes = value[0];
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
ssSTDropdownTags_InternalConfigs.Read( r, ref index);
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
public void ReadIM(RC_e3b67119e4a2ce2c95244e08a29b21aa r) {
this = r;
}


public static bool operator == (RC_e3b67119e4a2ce2c95244e08a29b21aa a, RC_e3b67119e4a2ce2c95244e08a29b21aa b) {
if (a.ssSTDropdownTags_InternalConfigs != b.ssSTDropdownTags_InternalConfigs) return false;
return true;
}

public static bool operator != (RC_e3b67119e4a2ce2c95244e08a29b21aa a, RC_e3b67119e4a2ce2c95244e08a29b21aa b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e3b67119e4a2ce2c95244e08a29b21aa)) return false;
return (this == (RC_e3b67119e4a2ce2c95244e08a29b21aa)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDropdownTags_InternalConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDropdownTags_InternalConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDropdownTags_InternalConfigs.InternalRecursiveSave();
}


public RC_e3b67119e4a2ce2c95244e08a29b21aa Duplicate() {
RC_e3b67119e4a2ce2c95244e08a29b21aa t;
t.ssSTDropdownTags_InternalConfigs = (ST_f2d4817754eec123207470e41d7a01d7Structure)this.ssSTDropdownTags_InternalConfigs.Duplicate();
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
if (head == "dropdowntags_internalconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DropdownTags_InternalConfigs")) variable.Value = ssSTDropdownTags_InternalConfigs; else variable.Optimized = true;
variable.SetFieldName("dropdowntags_internalconfigs");
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
if (key == IdDropdownTags_InternalConfigs) {
return ssSTDropdownTags_InternalConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDropdownTags_InternalConfigs.Key.AsGuid) {
return ssSTDropdownTags_InternalConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDropdownTags_InternalConfigs.FillFromOther((IRecord) other.AttributeGet(IdDropdownTags_InternalConfigs));
}
} // RC_e3b67119e4a2ce2c95244e08a29b21aa
/// <summary>
/// RecordList type <code>DropdownTags_InternalConfigsRecordList</code> that represents a record list
///  of <code>DropdownTags_InternalConfigs</code>
/// </summary>
public partial class RL_a5b4786090b04fa97abef703025f0e41 : GenericRecordList<RC_e3b67119e4a2ce2c95244e08a29b21aa>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_e3b67119e4a2ce2c95244e08a29b21aa GetElementDefaultValue() {
return new RC_e3b67119e4a2ce2c95244e08a29b21aa();
}

public T[] ToArray<T>(Func<RC_e3b67119e4a2ce2c95244e08a29b21aa, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a5b4786090b04fa97abef703025f0e41 recordList, Func<RC_e3b67119e4a2ce2c95244e08a29b21aa, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a5b4786090b04fa97abef703025f0e41(RC_e3b67119e4a2ce2c95244e08a29b21aa[] array) {
  RL_a5b4786090b04fa97abef703025f0e41 result = new RL_a5b4786090b04fa97abef703025f0e41();
result.InnerFromArray(array);
    return result;
}

public static RL_a5b4786090b04fa97abef703025f0e41 ToList<T>(T[] array, Func <T, RC_e3b67119e4a2ce2c95244e08a29b21aa> converter) {
  RL_a5b4786090b04fa97abef703025f0e41 result = new RL_a5b4786090b04fa97abef703025f0e41();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a5b4786090b04fa97abef703025f0e41 FromRestList<T>(RestList<T> restList, Func <T, RC_e3b67119e4a2ce2c95244e08a29b21aa> converter) {
  RL_a5b4786090b04fa97abef703025f0e41 result = new RL_a5b4786090b04fa97abef703025f0e41();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a5b4786090b04fa97abef703025f0e41() : base() {
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
protected override OSList<RC_e3b67119e4a2ce2c95244e08a29b21aa> NewList() {
return new RL_a5b4786090b04fa97abef703025f0e41();
}


} // RL_a5b4786090b04fa97abef703025f0e41
}

