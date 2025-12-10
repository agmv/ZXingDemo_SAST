namespace ssOutSystemsMaps {
/// <summary>
/// [AnonymousStructure] Record (5QAx99KfCUu5pSra1hdNlg)
///  <code>RC_dfb836f467b00be2b3ce838401b340cc</code> that represent
/// s <code>OptionalPopupMarkerConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: OptionalPopupMarkerConfigsRecord
public partial struct RC_dfb836f467b00be2b3ce838401b340cc : ITypedRecord<RC_dfb836f467b00be2b3ce838401b340cc> {
internal static readonly GlobalObjectKey IdOptionalPopupMarkerConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9Da437Bn4guzzoOEAbNAzA");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("OptionalPopupMarkerConfigs")]
public ST_bbc1ca6a16af45dbf463953c280f2bf7Structure ssSTOptionalPopupMarkerConfigs;


public static implicit operator ST_bbc1ca6a16af45dbf463953c280f2bf7Structure( RC_dfb836f467b00be2b3ce838401b340cc r) {
return r.ssSTOptionalPopupMarkerConfigs;
}

public static implicit operator RC_dfb836f467b00be2b3ce838401b340cc (ST_bbc1ca6a16af45dbf463953c280f2bf7Structure r) {
RC_dfb836f467b00be2b3ce838401b340cc res = new RC_dfb836f467b00be2b3ce838401b340cc ();
res.ssSTOptionalPopupMarkerConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_dfb836f467b00be2b3ce838401b340cc() {
OptimizedAttributes = null;
ssSTOptionalPopupMarkerConfigs = new ST_bbc1ca6a16af45dbf463953c280f2bf7Structure();
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
    ssSTOptionalPopupMarkerConfigs.OptimizedAttributes = value[0];
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
ssSTOptionalPopupMarkerConfigs.Read( r, ref index);
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
public void ReadIM(RC_dfb836f467b00be2b3ce838401b340cc r) {
this = r;
}


public static bool operator == (RC_dfb836f467b00be2b3ce838401b340cc a, RC_dfb836f467b00be2b3ce838401b340cc b) {
if (a.ssSTOptionalPopupMarkerConfigs != b.ssSTOptionalPopupMarkerConfigs) return false;
return true;
}

public static bool operator != (RC_dfb836f467b00be2b3ce838401b340cc a, RC_dfb836f467b00be2b3ce838401b340cc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_dfb836f467b00be2b3ce838401b340cc)) return false;
return (this == (RC_dfb836f467b00be2b3ce838401b340cc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOptionalPopupMarkerConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOptionalPopupMarkerConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOptionalPopupMarkerConfigs.InternalRecursiveSave();
}


public RC_dfb836f467b00be2b3ce838401b340cc Duplicate() {
RC_dfb836f467b00be2b3ce838401b340cc t;
t.ssSTOptionalPopupMarkerConfigs = (ST_bbc1ca6a16af45dbf463953c280f2bf7Structure)this.ssSTOptionalPopupMarkerConfigs.Duplicate();
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
if (head == "optionalpopupmarkerconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OptionalPopupMarkerConfigs")) variable.Value = ssSTOptionalPopupMarkerConfigs; else variable.Optimized = true;
variable.SetFieldName("optionalpopupmarkerconfigs");
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
if (key == IdOptionalPopupMarkerConfigs) {
return ssSTOptionalPopupMarkerConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOptionalPopupMarkerConfigs.Key.AsGuid) {
return ssSTOptionalPopupMarkerConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOptionalPopupMarkerConfigs.FillFromOther((IRecord) other.AttributeGet(IdOptionalPopupMarkerConfigs));
}
} // RC_dfb836f467b00be2b3ce838401b340cc
/// <summary>
/// RecordList type <code>OptionalPopupMarkerConfigsRecordList</code> that represents a record list of
///  <code>OptionalPopupMarkerConfigs</code>
/// </summary>
public partial class RL_5c878fa9fbf73778d7e6e41024ae4f84 : GenericRecordList<RC_dfb836f467b00be2b3ce838401b340cc>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override RC_dfb836f467b00be2b3ce838401b340cc GetElementDefaultValue() {
return new RC_dfb836f467b00be2b3ce838401b340cc();
}

public T[] ToArray<T>(Func<RC_dfb836f467b00be2b3ce838401b340cc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5c878fa9fbf73778d7e6e41024ae4f84 recordList, Func<RC_dfb836f467b00be2b3ce838401b340cc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5c878fa9fbf73778d7e6e41024ae4f84(RC_dfb836f467b00be2b3ce838401b340cc[] array) {
  RL_5c878fa9fbf73778d7e6e41024ae4f84 result = new RL_5c878fa9fbf73778d7e6e41024ae4f84();
result.InnerFromArray(array);
    return result;
}

public static RL_5c878fa9fbf73778d7e6e41024ae4f84 ToList<T>(T[] array, Func <T, RC_dfb836f467b00be2b3ce838401b340cc> converter) {
  RL_5c878fa9fbf73778d7e6e41024ae4f84 result = new RL_5c878fa9fbf73778d7e6e41024ae4f84();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5c878fa9fbf73778d7e6e41024ae4f84 FromRestList<T>(RestList<T> restList, Func <T, RC_dfb836f467b00be2b3ce838401b340cc> converter) {
  RL_5c878fa9fbf73778d7e6e41024ae4f84 result = new RL_5c878fa9fbf73778d7e6e41024ae4f84();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5c878fa9fbf73778d7e6e41024ae4f84() : base() {
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
protected override OSList<RC_dfb836f467b00be2b3ce838401b340cc> NewList() {
return new RL_5c878fa9fbf73778d7e6e41024ae4f84();
}


} // RL_5c878fa9fbf73778d7e6e41024ae4f84
}

