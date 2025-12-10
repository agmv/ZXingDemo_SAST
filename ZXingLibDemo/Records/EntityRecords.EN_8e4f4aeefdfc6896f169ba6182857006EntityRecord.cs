using System.Diagnostics;
namespace ssZXingLibDemo {

/// <summary>
/// [Entity] CodeDefaults (ursvX+HIfUu3d0Rk1kB3Kw)
///  <code>EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord</code> that represent
/// s <code>CodeDefaults</code> <p>Description: Defaults for encoding</p>
/// </summary>
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("CodeDefaults","ursvX+HIfUu3d0Rk1kB3Kw","eouRYZbkY0uZK7gymbIeQw", 0,"code_ic3hxschksdpz5mz9rqs7_i4", null, false)]
// Name: CodeDefaults
public partial struct EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord : ITypedRecord<EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord> {
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("eouRYZbkY0uZK7gymbIeQw*2XVbj5TVVEOUtANJVlCrsA");
internal static readonly GlobalObjectKey IdSample = GlobalObjectKey.Parse("eouRYZbkY0uZK7gymbIeQw*SGPT3KL9FkSsTKzWJFNA1g");
internal static readonly GlobalObjectKey IdMargin = GlobalObjectKey.Parse("eouRYZbkY0uZK7gymbIeQw*Wzz8uJkEuE6tW7ZtkSAtpQ");
internal static readonly GlobalObjectKey IdWidth = GlobalObjectKey.Parse("eouRYZbkY0uZK7gymbIeQw*2bPz0jicQUGUkAWPUz3KDQ");
internal static readonly GlobalObjectKey IdHeight = GlobalObjectKey.Parse("eouRYZbkY0uZK7gymbIeQw*D+gWFQ_LC0mQbJ63rHYyYw");

public static void EnsureInitialized(){}
[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("LABEL",50,false,true,false,true)]
[System.Xml.Serialization.XmlElement("Label")]
private string _ssLabel;
public string ssLabel{
  get{
      return _ssLabel;
  }
  set{
      if((_ssLabel!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(5,true);
          _ssLabel = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("SAMPLE",50,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Sample")]
private string _ssSample;
public string ssSample{
  get{
      return _ssSample;
  }
  set{
      if((_ssSample!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssSample = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MARGIN",0,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Margin")]
private int _ssMargin;
public int ssMargin{
  get{
      return _ssMargin;
  }
  set{
      if((_ssMargin!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssMargin = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("WIDTH",0,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Width")]
private int _ssWidth;
public int ssWidth{
  get{
      return _ssWidth;
  }
  set{
      if((_ssWidth!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssWidth = value;
      }
  }
}

[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("HEIGHT",0,false,false,false,false)]
[System.Xml.Serialization.XmlElement("Height")]
private int _ssHeight;
public int ssHeight{
  get{
      return _ssHeight;
  }
  set{
      if((_ssHeight!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssHeight = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssLabel = "";
_ssSample = "";
_ssMargin = 0;
_ssWidth = 0;
_ssHeight = 0;
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
ssLabel = r.ReadText(index++, "CodeDefaults.Label", "");
ssSample = r.ReadText(index++, "CodeDefaults.Sample", "");
ssMargin = r.ReadInteger(index++, "CodeDefaults.Margin", 0);
ssWidth = r.ReadInteger(index++, "CodeDefaults.Width", 0);
ssHeight = r.ReadInteger(index++, "CodeDefaults.Height", 0);
ChangedAttributes = new BitArray(5,false);
OptimizedAttributes = new BitArray(5,false);
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
public void ReadIM(EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord r) {
this = r;
}


public static bool operator == (EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord a, EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord b) {
if (a.ssLabel != b.ssLabel) return false;
if (a.ssSample != b.ssSample) return false;
if (a.ssMargin != b.ssMargin) return false;
if (a.ssWidth != b.ssWidth) return false;
if (a.ssHeight != b.ssHeight) return false;
return true;
}

public static bool operator != (EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord a, EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord)) return false;
return (this == (EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssSample.GetHashCode()
 ^ ssMargin.GetHashCode()
 ^ ssWidth.GetHashCode()
 ^ ssHeight.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord Duplicate() {
EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord t;
t._ssLabel = this._ssLabel;
t._ssSample = this._ssSample;
t._ssMargin = this._ssMargin;
t._ssWidth = this._ssWidth;
t._ssHeight = this._ssHeight;
t.ChangedAttributes = new BitArray(5);
t.OptimizedAttributes = new BitArray(5);
for(int i = 0; i < 5; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
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
if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "sample") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Sample")) variable.Value = ssSample; else variable.Optimized = true;
} else if (head == "margin") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Margin")) variable.Value = ssMargin; else variable.Optimized = true;
} else if (head == "width") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Width")) variable.Value = ssWidth; else variable.Optimized = true;
} else if (head == "height") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Height")) variable.Value = ssHeight; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdLabel)) {
return ChangedAttributes[0];
}
if (key.Equals(IdSample)) {
return ChangedAttributes[1];
}
if (key.Equals(IdMargin)) {
return ChangedAttributes[2];
}
if (key.Equals(IdWidth)) {
return ChangedAttributes[3];
}
if (key.Equals(IdHeight)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdLabel)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdSample)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdMargin)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdWidth)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdHeight)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdLabel) {
return ssLabel;
}
if (key == IdSample) {
return ssSample;
}
if (key == IdMargin) {
return ssMargin;
}
if (key == IdWidth) {
return ssWidth;
}
if (key == IdHeight) {
return ssHeight;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
if (attributeKey == IdSample.Key.AsGuid) {
return ssSample;
}
if (attributeKey == IdMargin.Key.AsGuid) {
return ssMargin;
}
if (attributeKey == IdWidth.Key.AsGuid) {
return ssWidth;
}
if (attributeKey == IdHeight.Key.AsGuid) {
return ssHeight;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[0] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdLabel);
ssSample = (string) other.AttributeGet(IdSample);
ChangedAttributes[1] = other.ChangedAttributeGet(IdSample);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdSample);
ssMargin = (int) other.AttributeGet(IdMargin);
ChangedAttributes[2] = other.ChangedAttributeGet(IdMargin);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdMargin);
ssWidth = (int) other.AttributeGet(IdWidth);
ChangedAttributes[3] = other.ChangedAttributeGet(IdWidth);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdWidth);
ssHeight = (int) other.AttributeGet(IdHeight);
ChangedAttributes[4] = other.ChangedAttributeGet(IdHeight);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdHeight);
}
} // EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord

/// <summary>
/// RecordList type <code>CodeDefaultsList</code> that represents a record list of
///  <code>CodeDefaults</code>
/// </summary>
public partial class RL_4b9674f1299848c32f009f23a882a9ba : GenericRecordList<EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord>, IEnumerable, IEnumerator {
public static void EnsureInitialized(){}

protected override EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord GetElementDefaultValue() {
return new EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord();
}

public T[] ToArray<T>(Func<EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4b9674f1299848c32f009f23a882a9ba recordList, Func<EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4b9674f1299848c32f009f23a882a9ba(EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord[] array) {
  RL_4b9674f1299848c32f009f23a882a9ba result = new RL_4b9674f1299848c32f009f23a882a9ba();
result.InnerFromArray(array);
    return result;
}

public static RL_4b9674f1299848c32f009f23a882a9ba ToList<T>(T[] array, Func <T, EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord> converter) {
  RL_4b9674f1299848c32f009f23a882a9ba result = new RL_4b9674f1299848c32f009f23a882a9ba();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4b9674f1299848c32f009f23a882a9ba FromRestList<T>(RestList<T> restList, Func <T, EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord> converter) {
  RL_4b9674f1299848c32f009f23a882a9ba result = new RL_4b9674f1299848c32f009f23a882a9ba();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4b9674f1299848c32f009f23a882a9ba() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_8e4f4aeefdfc6896f169ba6182857006EntityRecord> NewList() {
return new RL_4b9674f1299848c32f009f23a882a9ba();
}


} // RL_4b9674f1299848c32f009f23a882a9ba
}
