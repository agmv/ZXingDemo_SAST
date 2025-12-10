namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (xmr80qkDUk6eC9nYJq_07w)
///  <code>RC_f5926d9764d9dfa431e4fc134e2e6a98</code> that represents <code>SearchAreaRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SearchAreaRecord
public partial struct RC_f5926d9764d9dfa431e4fc134e2e6a98 : ITypedRecord<RC_f5926d9764d9dfa431e4fc134e2e6a98> {
internal static readonly GlobalObjectKey IdSearchArea = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*l22S9dlkpN8x5PwTTi5qmA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("SearchArea")]
public ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure ssSTSearchArea;


public static implicit operator ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure( RC_f5926d9764d9dfa431e4fc134e2e6a98 r) {
return r.ssSTSearchArea;
}

public static implicit operator RC_f5926d9764d9dfa431e4fc134e2e6a98 (ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure r) {
RC_f5926d9764d9dfa431e4fc134e2e6a98 res = new RC_f5926d9764d9dfa431e4fc134e2e6a98 ();
res.ssSTSearchArea = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_f5926d9764d9dfa431e4fc134e2e6a98() {
OptimizedAttributes = null;
ssSTSearchArea = new ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure();
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
    ssSTSearchArea.OptimizedAttributes = value[0];
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
ssSTSearchArea.Read( r, ref index);
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
public void ReadIM(RC_f5926d9764d9dfa431e4fc134e2e6a98 r) {
this = r;
}


public static bool operator == (RC_f5926d9764d9dfa431e4fc134e2e6a98 a, RC_f5926d9764d9dfa431e4fc134e2e6a98 b) {
if (a.ssSTSearchArea != b.ssSTSearchArea) return false;
return true;
}

public static bool operator != (RC_f5926d9764d9dfa431e4fc134e2e6a98 a, RC_f5926d9764d9dfa431e4fc134e2e6a98 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f5926d9764d9dfa431e4fc134e2e6a98)) return false;
return (this == (RC_f5926d9764d9dfa431e4fc134e2e6a98)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTSearchArea.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTSearchArea.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTSearchArea.InternalRecursiveSave();
}


public RC_f5926d9764d9dfa431e4fc134e2e6a98 Duplicate() {
RC_f5926d9764d9dfa431e4fc134e2e6a98 t;
t.ssSTSearchArea = (ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure)this.ssSTSearchArea.Duplicate();
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
if (head == "searcharea") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SearchArea")) variable.Value = ssSTSearchArea; else variable.Optimized = true;
variable.SetFieldName("searcharea");
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
if (key == IdSearchArea) {
return ssSTSearchArea;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSearchArea.Key.AsGuid) {
return ssSTSearchArea;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTSearchArea.FillFromOther((IRecord) other.AttributeGet(IdSearchArea));
}
} // RC_f5926d9764d9dfa431e4fc134e2e6a98
/// <summary>
/// RecordList type <code>SearchAreaRecordList</code> that represents a record list of
///  <code>SearchArea</code>
/// </summary>
public partial class RL_d1a5d844f6dcfdf5c7e83e1504e1fd10 : GenericRecordList<RC_f5926d9764d9dfa431e4fc134e2e6a98>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_f5926d9764d9dfa431e4fc134e2e6a98 GetElementDefaultValue() {
return new RC_f5926d9764d9dfa431e4fc134e2e6a98();
}

public T[] ToArray<T>(Func<RC_f5926d9764d9dfa431e4fc134e2e6a98, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d1a5d844f6dcfdf5c7e83e1504e1fd10 recordList, Func<RC_f5926d9764d9dfa431e4fc134e2e6a98, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d1a5d844f6dcfdf5c7e83e1504e1fd10(RC_f5926d9764d9dfa431e4fc134e2e6a98[] array) {
  RL_d1a5d844f6dcfdf5c7e83e1504e1fd10 result = new RL_d1a5d844f6dcfdf5c7e83e1504e1fd10();
result.InnerFromArray(array);
    return result;
}

public static RL_d1a5d844f6dcfdf5c7e83e1504e1fd10 ToList<T>(T[] array, Func <T, RC_f5926d9764d9dfa431e4fc134e2e6a98> converter) {
  RL_d1a5d844f6dcfdf5c7e83e1504e1fd10 result = new RL_d1a5d844f6dcfdf5c7e83e1504e1fd10();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d1a5d844f6dcfdf5c7e83e1504e1fd10 FromRestList<T>(RestList<T> restList, Func <T, RC_f5926d9764d9dfa431e4fc134e2e6a98> converter) {
  RL_d1a5d844f6dcfdf5c7e83e1504e1fd10 result = new RL_d1a5d844f6dcfdf5c7e83e1504e1fd10();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d1a5d844f6dcfdf5c7e83e1504e1fd10() : base() {
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
protected override OSList<RC_f5926d9764d9dfa431e4fc134e2e6a98> NewList() {
return new RL_d1a5d844f6dcfdf5c7e83e1504e1fd10();
}


} // RL_d1a5d844f6dcfdf5c7e83e1504e1fd10
}

