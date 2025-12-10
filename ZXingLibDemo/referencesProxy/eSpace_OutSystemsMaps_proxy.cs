// Proxy for reference eSpace with name OutSystemsMaps and key rVZv9Ak0cEqsTljBlnzdwg
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssZXingLibDemo;
using ssZXingLibDemo.ReferencesProxy;
namespace ssZXingLibDemo.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssZXingLibDemo {
/// <summary>
/// Class: RsseSpaceOutSystemsMaps
/// </summary>
public partial class RsseSpaceOutSystemsMaps {
private static readonly ActivitySource source = new("ssZXingLibDemo.RsseSpaceOutSystemsMaps");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
       }
   }
public sealed partial class ENMapErrorsEntity {
public static string ViewName(long? tenant, string locale) {
return "\"runtime\".";
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
} // ENMapErrorsEntity
    partial class ENMapErrorsEntity {
        

        public static IRecord GetRecordById(string id) {
IRecord rec = Factory.FactoryEN_4d0e07d9538530f68924ab612d15f82bEntityRecordSingleton.CreateRsseSpaceOutSystemsMapsEN_4d0e07d9538530f68924ab612d15f82bEntityRecord();
rec.FillFromOther(ssOutSystemsMaps.ENMapErrorsEntity.GetRecordById(id));
return rec;
}


        public static IRecord GetRecordByKey(ObjectKey key) {
IRecord rec = Factory.FactoryEN_4d0e07d9538530f68924ab612d15f82bEntityRecordSingleton.CreateRsseSpaceOutSystemsMapsEN_4d0e07d9538530f68924ab612d15f82bEntityRecord();
rec.FillFromOther(ssOutSystemsMaps.ENMapErrorsEntity.GetRecordByKey(key));
return rec;
}

    } // ENMapErrorsEntity;

public sealed partial class ENTypeEntity {
public static string ViewName(long? tenant, string locale) {
return "\"runtime\".";
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
} // ENTypeEntity
    partial class ENTypeEntity {
        

        public static IRecord GetRecordById(string id) {
IRecord rec = Factory.FactoryEN_da8d5af471adea3d9064074b1a40d8c2EntityRecordSingleton.CreateRsseSpaceOutSystemsMapsEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord();
rec.FillFromOther(ssOutSystemsMaps.ENTypeEntity.GetRecordById(id));
return rec;
}


        public static IRecord GetRecordByKey(ObjectKey key) {
IRecord rec = Factory.FactoryEN_da8d5af471adea3d9064074b1a40d8c2EntityRecordSingleton.CreateRsseSpaceOutSystemsMapsEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord();
rec.FillFromOther(ssOutSystemsMaps.ENTypeEntity.GetRecordByKey(key));
return rec;
}

    } // ENTypeEntity;

public sealed partial class ENMapEventTriggeredEntity {
public static string ViewName(long? tenant, string locale) {
return "\"runtime\".";
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
} // ENMapEventTriggeredEntity
    partial class ENMapEventTriggeredEntity {
        

        public static IRecord GetRecordById(string id) {
IRecord rec = Factory.FactoryEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecordSingleton.CreateRsseSpaceOutSystemsMapsEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord();
rec.FillFromOther(ssOutSystemsMaps.ENMapEventTriggeredEntity.GetRecordById(id));
return rec;
}


        public static IRecord GetRecordByKey(ObjectKey key) {
IRecord rec = Factory.FactoryEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecordSingleton.CreateRsseSpaceOutSystemsMapsEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord();
rec.FillFromOther(ssOutSystemsMaps.ENMapEventTriggeredEntity.GetRecordByKey(key));
return rec;
}

    } // ENMapEventTriggeredEntity;

public sealed partial class ENStyleEntity {
public static string ViewName(long? tenant, string locale) {
return "\"runtime\".";
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
} // ENStyleEntity
    partial class ENStyleEntity {
        

        public static IRecord GetRecordById(int id) {
IRecord rec = Factory.FactoryEN_e7686de199fbd20281899419f0b6ff11EntityRecordSingleton.CreateRsseSpaceOutSystemsMapsEN_e7686de199fbd20281899419f0b6ff11EntityRecord();
rec.FillFromOther(ssOutSystemsMaps.ENStyleEntity.GetRecordById(id));
return rec;
}


        public static IRecord GetRecordByKey(ObjectKey key) {
IRecord rec = Factory.FactoryEN_e7686de199fbd20281899419f0b6ff11EntityRecordSingleton.CreateRsseSpaceOutSystemsMapsEN_e7686de199fbd20281899419f0b6ff11EntityRecord();
rec.FillFromOther(ssOutSystemsMaps.ENStyleEntity.GetRecordByKey(key));
return rec;
}

    } // ENStyleEntity;

public sealed partial class ENZoomEntity {
public static string ViewName(long? tenant, string locale) {
return "\"runtime\".";
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
} // ENZoomEntity
    partial class ENZoomEntity {
        

        public static IRecord GetRecordById(int id) {
IRecord rec = Factory.FactoryEN_480235a969b3f42eac91ad5813fe9bf9EntityRecordSingleton.CreateRsseSpaceOutSystemsMapsEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord();
rec.FillFromOther(ssOutSystemsMaps.ENZoomEntity.GetRecordById(id));
return rec;
}


        public static IRecord GetRecordByKey(ObjectKey key) {
IRecord rec = Factory.FactoryEN_480235a969b3f42eac91ad5813fe9bf9EntityRecordSingleton.CreateRsseSpaceOutSystemsMapsEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord();
rec.FillFromOther(ssOutSystemsMaps.ENZoomEntity.GetRecordByKey(key));
return rec;
}

    } // ENZoomEntity;

public interface IRC_9b61cb371b118ff2b906c01399dcb602TypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsRC_9b61cb371b118ff2b906c01399dcb602();
}
public interface IST_59c2aa6a35b14343cc78f655810f9ce8StructureTypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsST_59c2aa6a35b14343cc78f655810f9ce8Structure();
}
public interface IRC_d761bc5f1b0fe2debf1c3edffd0efd3cTypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsRC_d761bc5f1b0fe2debf1c3edffd0efd3c();
}
public interface IST_d609eacb476c603df8b92eb374da99faStructureTypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsST_d609eacb476c603df8b92eb374da99faStructure();
}
public interface IRC_d687bfbe104d17346737149645109738TypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsRC_d687bfbe104d17346737149645109738();
}
public interface IST_30625b4ad0f3e10abf82b61ea58e8644StructureTypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsST_30625b4ad0f3e10abf82b61ea58e8644Structure();
}
public interface IRC_a3e0d02178b078a960ae427dd1751cbcTypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsRC_a3e0d02178b078a960ae427dd1751cbc();
}
public interface IST_be62cc31fbe4705834275960beeb55e2StructureTypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsST_be62cc31fbe4705834275960beeb55e2Structure();
}
public interface IRC_e3355f6b7ba3051c4a4a9a00634d68d0TypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsRC_e3355f6b7ba3051c4a4a9a00634d68d0();
}
public interface IST_0e474756a4be14d378c73cd05f602bcdStructureTypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsST_0e474756a4be14d378c73cd05f602bcdStructure();
}
public interface IRC_3d151c63adf137bd3c85eaa462bbbe0cTypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsRC_3d151c63adf137bd3c85eaa462bbbe0c();
}
public interface IEN_4d0e07d9538530f68924ab612d15f82bEntityRecordTypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsEN_4d0e07d9538530f68924ab612d15f82bEntityRecord();
}
public interface IRC_b32e755d03dd085a4b975b8c0c7d4454TypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsRC_b32e755d03dd085a4b975b8c0c7d4454();
}
public interface IEN_da8d5af471adea3d9064074b1a40d8c2EntityRecordTypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsEN_da8d5af471adea3d9064074b1a40d8c2EntityRecord();
}
public interface IRC_bf75694d8016688134fa555a2fd4f5d7TypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsRC_bf75694d8016688134fa555a2fd4f5d7();
}
public interface IEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecordTypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecord();
}
public interface IRC_97843bcb52146db1681dfc816cff70a0TypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsRC_97843bcb52146db1681dfc816cff70a0();
}
public interface IEN_e7686de199fbd20281899419f0b6ff11EntityRecordTypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsEN_e7686de199fbd20281899419f0b6ff11EntityRecord();
}
public interface IRC_80e81fddca0089d3f29f81106c0bee34TypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsRC_80e81fddca0089d3f29f81106c0bee34();
}
public interface IEN_480235a969b3f42eac91ad5813fe9bf9EntityRecordTypeFactory {
IRecord CreateRsseSpaceOutSystemsMapsEN_480235a969b3f42eac91ad5813fe9bf9EntityRecord();
}

public class Factory {
public static IST_0e474756a4be14d378c73cd05f602bcdStructureTypeFactory FactoryST_0e474756a4be14d378c73cd05f602bcdStructureSingleton;
public static IRC_e3355f6b7ba3051c4a4a9a00634d68d0TypeFactory FactoryRC_e3355f6b7ba3051c4a4a9a00634d68d0Singleton;
public static IST_59c2aa6a35b14343cc78f655810f9ce8StructureTypeFactory FactoryST_59c2aa6a35b14343cc78f655810f9ce8StructureSingleton;
public static IRC_9b61cb371b118ff2b906c01399dcb602TypeFactory FactoryRC_9b61cb371b118ff2b906c01399dcb602Singleton;
public static IEN_4d0e07d9538530f68924ab612d15f82bEntityRecordTypeFactory FactoryEN_4d0e07d9538530f68924ab612d15f82bEntityRecordSingleton;
public static IRC_3d151c63adf137bd3c85eaa462bbbe0cTypeFactory FactoryRC_3d151c63adf137bd3c85eaa462bbbe0cSingleton;
public static IEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecordTypeFactory FactoryEN_2b877a58494bdf7ca89c3ea2061b88c8EntityRecordSingleton;
public static IRC_bf75694d8016688134fa555a2fd4f5d7TypeFactory FactoryRC_bf75694d8016688134fa555a2fd4f5d7Singleton;
public static IST_30625b4ad0f3e10abf82b61ea58e8644StructureTypeFactory FactoryST_30625b4ad0f3e10abf82b61ea58e8644StructureSingleton;
public static IRC_d687bfbe104d17346737149645109738TypeFactory FactoryRC_d687bfbe104d17346737149645109738Singleton;
public static IST_be62cc31fbe4705834275960beeb55e2StructureTypeFactory FactoryST_be62cc31fbe4705834275960beeb55e2StructureSingleton;
public static IRC_a3e0d02178b078a960ae427dd1751cbcTypeFactory FactoryRC_a3e0d02178b078a960ae427dd1751cbcSingleton;
public static IST_d609eacb476c603df8b92eb374da99faStructureTypeFactory FactoryST_d609eacb476c603df8b92eb374da99faStructureSingleton;
public static IRC_d761bc5f1b0fe2debf1c3edffd0efd3cTypeFactory FactoryRC_d761bc5f1b0fe2debf1c3edffd0efd3cSingleton;
public static IEN_e7686de199fbd20281899419f0b6ff11EntityRecordTypeFactory FactoryEN_e7686de199fbd20281899419f0b6ff11EntityRecordSingleton;
public static IRC_97843bcb52146db1681dfc816cff70a0TypeFactory FactoryRC_97843bcb52146db1681dfc816cff70a0Singleton;
public static IEN_da8d5af471adea3d9064074b1a40d8c2EntityRecordTypeFactory FactoryEN_da8d5af471adea3d9064074b1a40d8c2EntityRecordSingleton;
public static IRC_b32e755d03dd085a4b975b8c0c7d4454TypeFactory FactoryRC_b32e755d03dd085a4b975b8c0c7d4454Singleton;
public static IEN_480235a969b3f42eac91ad5813fe9bf9EntityRecordTypeFactory FactoryEN_480235a969b3f42eac91ad5813fe9bf9EntityRecordSingleton;
public static IRC_80e81fddca0089d3f29f81106c0bee34TypeFactory FactoryRC_80e81fddca0089d3f29f81106c0bee34Singleton;
}
public class DefaultValues {
public static string ReferenceStructure_OptionalMapConfigs_ReferenceStructureAttribute_Type {
get { return ssOutSystemsMaps.DefaultValues.ReferenceStructure_OptionalMapConfigs_ReferenceStructureAttribute_Type; }
}
public static int ReferenceStructure_OptionalMapConfigs_ReferenceStructureAttribute_Zoom {
get { return ssOutSystemsMaps.DefaultValues.ReferenceStructure_OptionalMapConfigs_ReferenceStructureAttribute_Zoom; }
}
public static int ReferenceStructure_OptionalMapConfigs_ReferenceStructureAttribute_DEPRECATED_Style {
get { return ssOutSystemsMaps.DefaultValues.ReferenceStructure_OptionalMapConfigs_ReferenceStructureAttribute_DEPRECATED_Style; }
}
public static int ReferenceStructure_MarkerClusterer_ReferenceStructureAttribute_MaxZoom {
get { return 0; }
}
}
}
}
