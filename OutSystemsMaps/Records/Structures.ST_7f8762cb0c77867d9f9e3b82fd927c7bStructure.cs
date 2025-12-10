namespace ssOutSystemsMaps {
/// <summary>
/// [Structure] Fill (_VyEpKZyS0ytU1racZPWwg) <code>ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure</code>
///  that represents <code>Fill</code> <p>Description: Set additional parameters to customize th
/// e shape’s fill.</p>
/// </summary>
// Name: Fill
public partial struct ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure : ITypedRecord<ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure> {
internal static readonly GlobalObjectKey IdColor = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*jROeVZ+LjEyOsgNg2oHPww");
internal static readonly GlobalObjectKey IdOpacity = GlobalObjectKey.Parse("0TG7lXnw1k+rLlyDJoVaqg*mAxq4ERKNUqqZJKQB8LkeQ");

public static void EnsureInitialized(){}
[System.Xml.Serialization.XmlElement("Color")]
public string ssColor;

[System.Xml.Serialization.XmlElement("Opacity")]
public decimal ssOpacity;


public BitArray OptimizedAttributes;

public ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure() {
OptimizedAttributes = null;
ssColor = "#000000";
ssOpacity = (((decimal)1));
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
ssColor = r.ReadText(index++, "Fill.Color", "");
ssOpacity = r.ReadDecimal(index++, "Fill.Opacity", 0.0M);
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
public void ReadIM(ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure r) {
this = r;
}


public static bool operator == (ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure a, ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure b) {
if (a.ssColor != b.ssColor) return false;
if (a.ssOpacity != b.ssOpacity) return false;
return true;
}

public static bool operator != (ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure a, ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure)) return false;
return (this == (ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssColor.GetHashCode()
 ^ ssOpacity.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure Duplicate() {
ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure t;
t.ssColor = this.ssColor;
t.ssOpacity = this.ssOpacity;
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
if (head == "color") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Color")) variable.Value = ssColor; else variable.Optimized = true;
} else if (head == "opacity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Opacity")) variable.Value = ssOpacity; else variable.Optimized = true;
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
if (key == IdColor) {
return ssColor;
}
if (key == IdOpacity) {
return ssOpacity;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdColor.Key.AsGuid) {
return ssColor;
}
if (attributeKey == IdOpacity.Key.AsGuid) {
return ssOpacity;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssColor = (string) other.AttributeGet(IdColor);
ssOpacity = (decimal) other.AttributeGet(IdOpacity);
}
} // ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure
/// <summary>
/// RecordList type <code>FillList</code> that represents a record list of <code>Fill</code>
/// </summary>
public partial class RL_fc144e04b60a1ff1da29c01dfb2812e3 : GenericRecordList<ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure GetElementDefaultValue() {
return new ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure();
}

public T[] ToArray<T>(Func<ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fc144e04b60a1ff1da29c01dfb2812e3 recordList, Func<ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fc144e04b60a1ff1da29c01dfb2812e3(ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure[] array) {
  RL_fc144e04b60a1ff1da29c01dfb2812e3 result = new RL_fc144e04b60a1ff1da29c01dfb2812e3();
result.InnerFromArray(array);
    return result;
}

public static RL_fc144e04b60a1ff1da29c01dfb2812e3 ToList<T>(T[] array, Func <T, ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure> converter) {
  RL_fc144e04b60a1ff1da29c01dfb2812e3 result = new RL_fc144e04b60a1ff1da29c01dfb2812e3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fc144e04b60a1ff1da29c01dfb2812e3 FromRestList<T>(RestList<T> restList, Func <T, ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure> converter) {
  RL_fc144e04b60a1ff1da29c01dfb2812e3 result = new RL_fc144e04b60a1ff1da29c01dfb2812e3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fc144e04b60a1ff1da29c01dfb2812e3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure> NewList() {
return new RL_fc144e04b60a1ff1da29c01dfb2812e3();
}


} // RL_fc144e04b60a1ff1da29c01dfb2812e3
}

