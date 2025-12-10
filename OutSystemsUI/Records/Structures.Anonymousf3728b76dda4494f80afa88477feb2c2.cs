namespace ssOutSystemsUI {
/// <summary>
/// [AnonymousStructure] Record (doty86TdT0mAr6iEd_6ywg)
///  <code>RC_40ff37b8719fa708a2bb67c839d296b2</code> that represent
/// s <code>AnimatedLabel_InternalConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: AnimatedLabel_InternalConfigRecord
public partial struct RC_40ff37b8719fa708a2bb67c839d296b2 : ITypedRecord<RC_40ff37b8719fa708a2bb67c839d296b2> {
internal static readonly GlobalObjectKey IdAnimatedLabel_InternalConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uDf_QJ9xCKeiu2fIOdKWsg");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("AnimatedLabel_InternalConfig")]
public ST_52888c3e6f33b11b7d6288dd268a26dcStructure ssSTAnimatedLabel_InternalConfig;


public static implicit operator ST_52888c3e6f33b11b7d6288dd268a26dcStructure( RC_40ff37b8719fa708a2bb67c839d296b2 r) {
return r.ssSTAnimatedLabel_InternalConfig;
}

public static implicit operator RC_40ff37b8719fa708a2bb67c839d296b2 (ST_52888c3e6f33b11b7d6288dd268a26dcStructure r) {
RC_40ff37b8719fa708a2bb67c839d296b2 res = new RC_40ff37b8719fa708a2bb67c839d296b2 ();
res.ssSTAnimatedLabel_InternalConfig = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_40ff37b8719fa708a2bb67c839d296b2() {
OptimizedAttributes = null;
ssSTAnimatedLabel_InternalConfig = new ST_52888c3e6f33b11b7d6288dd268a26dcStructure();
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
    ssSTAnimatedLabel_InternalConfig.OptimizedAttributes = value[0];
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
ssSTAnimatedLabel_InternalConfig.Read( r, ref index);
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
public void ReadIM(RC_40ff37b8719fa708a2bb67c839d296b2 r) {
this = r;
}


public static bool operator == (RC_40ff37b8719fa708a2bb67c839d296b2 a, RC_40ff37b8719fa708a2bb67c839d296b2 b) {
if (a.ssSTAnimatedLabel_InternalConfig != b.ssSTAnimatedLabel_InternalConfig) return false;
return true;
}

public static bool operator != (RC_40ff37b8719fa708a2bb67c839d296b2 a, RC_40ff37b8719fa708a2bb67c839d296b2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_40ff37b8719fa708a2bb67c839d296b2)) return false;
return (this == (RC_40ff37b8719fa708a2bb67c839d296b2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTAnimatedLabel_InternalConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTAnimatedLabel_InternalConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTAnimatedLabel_InternalConfig.InternalRecursiveSave();
}


public RC_40ff37b8719fa708a2bb67c839d296b2 Duplicate() {
RC_40ff37b8719fa708a2bb67c839d296b2 t;
t.ssSTAnimatedLabel_InternalConfig = (ST_52888c3e6f33b11b7d6288dd268a26dcStructure)this.ssSTAnimatedLabel_InternalConfig.Duplicate();
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
if (head == "animatedlabel_internalconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AnimatedLabel_InternalConfig")) variable.Value = ssSTAnimatedLabel_InternalConfig; else variable.Optimized = true;
variable.SetFieldName("animatedlabel_internalconfig");
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
if (key == IdAnimatedLabel_InternalConfig) {
return ssSTAnimatedLabel_InternalConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAnimatedLabel_InternalConfig.Key.AsGuid) {
return ssSTAnimatedLabel_InternalConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTAnimatedLabel_InternalConfig.FillFromOther((IRecord) other.AttributeGet(IdAnimatedLabel_InternalConfig));
}
} // RC_40ff37b8719fa708a2bb67c839d296b2
/// <summary>
/// RecordList type <code>AnimatedLabel_InternalConfigRecordList</code> that represents a record list
///  of <code>AnimatedLabel_InternalConfig</code>
/// </summary>
public partial class RL_597a3a552f76dc5968860b549203fa96 : GenericRecordList<RC_40ff37b8719fa708a2bb67c839d296b2>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_40ff37b8719fa708a2bb67c839d296b2 GetElementDefaultValue() {
return new RC_40ff37b8719fa708a2bb67c839d296b2();
}

public T[] ToArray<T>(Func<RC_40ff37b8719fa708a2bb67c839d296b2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_597a3a552f76dc5968860b549203fa96 recordList, Func<RC_40ff37b8719fa708a2bb67c839d296b2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_597a3a552f76dc5968860b549203fa96(RC_40ff37b8719fa708a2bb67c839d296b2[] array) {
  RL_597a3a552f76dc5968860b549203fa96 result = new RL_597a3a552f76dc5968860b549203fa96();
result.InnerFromArray(array);
    return result;
}

public static RL_597a3a552f76dc5968860b549203fa96 ToList<T>(T[] array, Func <T, RC_40ff37b8719fa708a2bb67c839d296b2> converter) {
  RL_597a3a552f76dc5968860b549203fa96 result = new RL_597a3a552f76dc5968860b549203fa96();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_597a3a552f76dc5968860b549203fa96 FromRestList<T>(RestList<T> restList, Func <T, RC_40ff37b8719fa708a2bb67c839d296b2> converter) {
  RL_597a3a552f76dc5968860b549203fa96 result = new RL_597a3a552f76dc5968860b549203fa96();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_597a3a552f76dc5968860b549203fa96() : base() {
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
protected override OSList<RC_40ff37b8719fa708a2bb67c839d296b2> NewList() {
return new RL_597a3a552f76dc5968860b549203fa96();
}


} // RL_597a3a552f76dc5968860b549203fa96
}

