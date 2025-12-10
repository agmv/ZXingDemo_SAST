namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (HEQPlQJDM0GrmAY8afd9ew)
///  <code>RC_2d18bab1b72b271dc15dda249e871290</code> that represents <code>MarkerEventRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: MarkerEventRecord
public partial struct RC_2d18bab1b72b271dc15dda249e871290 : ITypedRecord<RC_2d18bab1b72b271dc15dda249e871290> {
internal static readonly GlobalObjectKey IdMarkerEvent = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sboYLSu3HSfBXdoknocSkA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("MarkerEvent")]
public EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord ssENMarkerEvent;


public static implicit operator EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord( RC_2d18bab1b72b271dc15dda249e871290 r) {
return r.ssENMarkerEvent;
}

public static implicit operator RC_2d18bab1b72b271dc15dda249e871290 (EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord r) {
RC_2d18bab1b72b271dc15dda249e871290 res = new RC_2d18bab1b72b271dc15dda249e871290 ();
res.ssENMarkerEvent = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENMarkerEvent.ChangedAttributes = value;
}
get {
    return ssENMarkerEvent.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_2d18bab1b72b271dc15dda249e871290() {
OptimizedAttributes = null;
ssENMarkerEvent = new EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENMarkerEvent.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENMarkerEvent.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENMarkerEvent.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENMarkerEvent.Read( r, ref index);
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
public void ReadIM(RC_2d18bab1b72b271dc15dda249e871290 r) {
this = r;
}


public static bool operator == (RC_2d18bab1b72b271dc15dda249e871290 a, RC_2d18bab1b72b271dc15dda249e871290 b) {
if (a.ssENMarkerEvent != b.ssENMarkerEvent) return false;
return true;
}

public static bool operator != (RC_2d18bab1b72b271dc15dda249e871290 a, RC_2d18bab1b72b271dc15dda249e871290 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2d18bab1b72b271dc15dda249e871290)) return false;
return (this == (RC_2d18bab1b72b271dc15dda249e871290)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENMarkerEvent.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENMarkerEvent.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENMarkerEvent.InternalRecursiveSave();
}


public RC_2d18bab1b72b271dc15dda249e871290 Duplicate() {
RC_2d18bab1b72b271dc15dda249e871290 t;
t.ssENMarkerEvent = (EN_7595bf81d0b29040f5ad1b9eff7896b0EntityRecord)this.ssENMarkerEvent.Duplicate();
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
if (head == "markerevent") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MarkerEvent")) variable.Value = ssENMarkerEvent; else variable.Optimized = true;
variable.SetFieldName("markerevent");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENMarkerEvent.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENMarkerEvent.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdMarkerEvent) {
return ssENMarkerEvent;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMarkerEvent.Key.AsGuid) {
return ssENMarkerEvent;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENMarkerEvent.FillFromOther((IRecord) other.AttributeGet(IdMarkerEvent));
}
} // RC_2d18bab1b72b271dc15dda249e871290
/// <summary>
/// RecordList type <code>MarkerEventRecordList</code> that represents a record list of
///  <code>MarkerEvent</code>
/// </summary>
public partial class RL_e9ed364f1c303a6ee96cf13dc37248d6 : GenericRecordList<RC_2d18bab1b72b271dc15dda249e871290>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_2d18bab1b72b271dc15dda249e871290 GetElementDefaultValue() {
return new RC_2d18bab1b72b271dc15dda249e871290();
}

public T[] ToArray<T>(Func<RC_2d18bab1b72b271dc15dda249e871290, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e9ed364f1c303a6ee96cf13dc37248d6 recordList, Func<RC_2d18bab1b72b271dc15dda249e871290, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e9ed364f1c303a6ee96cf13dc37248d6(RC_2d18bab1b72b271dc15dda249e871290[] array) {
  RL_e9ed364f1c303a6ee96cf13dc37248d6 result = new RL_e9ed364f1c303a6ee96cf13dc37248d6();
result.InnerFromArray(array);
    return result;
}

public static RL_e9ed364f1c303a6ee96cf13dc37248d6 ToList<T>(T[] array, Func <T, RC_2d18bab1b72b271dc15dda249e871290> converter) {
  RL_e9ed364f1c303a6ee96cf13dc37248d6 result = new RL_e9ed364f1c303a6ee96cf13dc37248d6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e9ed364f1c303a6ee96cf13dc37248d6 FromRestList<T>(RestList<T> restList, Func <T, RC_2d18bab1b72b271dc15dda249e871290> converter) {
  RL_e9ed364f1c303a6ee96cf13dc37248d6 result = new RL_e9ed364f1c303a6ee96cf13dc37248d6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e9ed364f1c303a6ee96cf13dc37248d6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_2d18bab1b72b271dc15dda249e871290> NewList() {
return new RL_e9ed364f1c303a6ee96cf13dc37248d6();
}


} // RL_e9ed364f1c303a6ee96cf13dc37248d6
}

