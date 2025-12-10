namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Localization (yihIBQrI706bmMXHr3P3DQ)
///  <code>ST_59c2aa6a35b14343cc78f655810f9ce8Structure</code> that represents <code>Localization</code
/// > <p>Description: Customize your map for a specific country or region.</p>
/// </summary>
// Name: Localization
public partial struct ST_59c2aa6a35b14343cc78f655810f9ce8Structure : ITypedRecord<ST_59c2aa6a35b14343cc78f655810f9ce8Structure> {
internal static readonly GlobalObjectKey IdLanguage = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*MVm7QJdWxU2dnrjeYYmW_Q");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*qYmyMR88OUGNvuAOifq27A");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Language")]
public string ssLanguage;

[System.Xml.Serialization.XmlElement("Region")]
public string ssRegion;


public BitArray OptimizedAttributes;

public ST_59c2aa6a35b14343cc78f655810f9ce8Structure() {
OptimizedAttributes = null;
ssLanguage = "";
ssRegion = "";
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
ssLanguage = r.ReadText(index++, "Localization.Language", "");
ssRegion = r.ReadText(index++, "Localization.Region", "");
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
public void ReadIM(ST_59c2aa6a35b14343cc78f655810f9ce8Structure r) {
this = r;
}


public static bool operator == (ST_59c2aa6a35b14343cc78f655810f9ce8Structure a, ST_59c2aa6a35b14343cc78f655810f9ce8Structure b) {
if (a.ssLanguage != b.ssLanguage) return false;
if (a.ssRegion != b.ssRegion) return false;
return true;
}

public static bool operator != (ST_59c2aa6a35b14343cc78f655810f9ce8Structure a, ST_59c2aa6a35b14343cc78f655810f9ce8Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_59c2aa6a35b14343cc78f655810f9ce8Structure)) return false;
return (this == (ST_59c2aa6a35b14343cc78f655810f9ce8Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLanguage.GetHashCode()
 ^ ssRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_59c2aa6a35b14343cc78f655810f9ce8Structure Duplicate() {
ST_59c2aa6a35b14343cc78f655810f9ce8Structure t;
t.ssLanguage = this.ssLanguage;
t.ssRegion = this.ssRegion;
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
if (head == "language") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Language")) variable.Value = ssLanguage; else variable.Optimized = true;
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssRegion; else variable.Optimized = true;
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
if (key == IdLanguage) {
return ssLanguage;
}
if (key == IdRegion) {
return ssRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLanguage.Key.AsGuid) {
return ssLanguage;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssLanguage = (string) other.AttributeGet(IdLanguage);
ssRegion = (string) other.AttributeGet(IdRegion);
}
} // ST_59c2aa6a35b14343cc78f655810f9ce8Structure
/// <summary>
/// RecordList type <code>LocalizationList</code> that represents a record list of
///  <code>Localization</code>
/// </summary>
public partial class RL_a62cf1f8f663cbf1aed96b2f3b5b0f2e : GenericRecordList<ST_59c2aa6a35b14343cc78f655810f9ce8Structure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_59c2aa6a35b14343cc78f655810f9ce8Structure GetElementDefaultValue() {
return new ST_59c2aa6a35b14343cc78f655810f9ce8Structure();
}

public T[] ToArray<T>(Func<ST_59c2aa6a35b14343cc78f655810f9ce8Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a62cf1f8f663cbf1aed96b2f3b5b0f2e recordList, Func<ST_59c2aa6a35b14343cc78f655810f9ce8Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a62cf1f8f663cbf1aed96b2f3b5b0f2e(ST_59c2aa6a35b14343cc78f655810f9ce8Structure[] array) {
  RL_a62cf1f8f663cbf1aed96b2f3b5b0f2e result = new RL_a62cf1f8f663cbf1aed96b2f3b5b0f2e();
result.InnerFromArray(array);
    return result;
}

public static RL_a62cf1f8f663cbf1aed96b2f3b5b0f2e ToList<T>(T[] array, Func <T, ST_59c2aa6a35b14343cc78f655810f9ce8Structure> converter) {
  RL_a62cf1f8f663cbf1aed96b2f3b5b0f2e result = new RL_a62cf1f8f663cbf1aed96b2f3b5b0f2e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a62cf1f8f663cbf1aed96b2f3b5b0f2e FromRestList<T>(RestList<T> restList, Func <T, ST_59c2aa6a35b14343cc78f655810f9ce8Structure> converter) {
  RL_a62cf1f8f663cbf1aed96b2f3b5b0f2e result = new RL_a62cf1f8f663cbf1aed96b2f3b5b0f2e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a62cf1f8f663cbf1aed96b2f3b5b0f2e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_59c2aa6a35b14343cc78f655810f9ce8Structure> NewList() {
return new RL_a62cf1f8f663cbf1aed96b2f3b5b0f2e();
}


} // RL_a62cf1f8f663cbf1aed96b2f3b5b0f2e
}

