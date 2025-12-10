using System.Diagnostics;

using ssZXingLibDemo;


namespace ssZXingLibDemo.ScreenServices;

public class ZXingLibDemo_Common_UserProfile_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ZXingLibDemo_Common_UserProfile_ScreenModel).Namespace);

    public bool varLcIsButtonEnabled;
public bool varLcIsExternal;
public AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75> ScreenDataSetGetUserById;
public ZXingLibDemo_ClientVariables clientVariables;


    public ZXingLibDemo_Common_UserProfile_ScreenModel() {
}



    public ZXingLibDemo_Common_UserProfile_ScreenModel(bool varLcIsButtonEnabled, bool varLcIsExternal, AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75> ScreenDataSetGetUserById, ZXingLibDemo_ClientVariables clientVariables) {
Init(new string[] {"IsButtonEnabled", "IsExternal", "GetUserById", "ClientVars"}, new string[] {"varLcIsButtonEnabled", "varLcIsExternal", "ScreenDataSetGetUserById", "clientVariables"});
this.varLcIsButtonEnabled = varLcIsButtonEnabled;
this.varLcIsExternal = varLcIsExternal;
this.ScreenDataSetGetUserById = ScreenDataSetGetUserById;
this.clientVariables = clientVariables;
}



    
// Query Function "GetUserById" IivWtVN2ikiLCC6qjaBJcA of Action "UserProfile"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("UserProfile","Common.UserProfile.GetUserById");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
StringBuilder selectBuilder = new StringBuilder();
StringBuilder fromBuilder = new StringBuilder();
StringBuilder whereBuilder = new StringBuilder();
StringBuilder orderByBuilder = new StringBuilder();
StringBuilder groupByBuilder = new StringBuilder();
StringBuilder havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.B4kRGvrnOEmQonA8ir4Pyg/NodesShownInESpaceTree.BCj50fqknk2pzWrhIjEw5A/ScreenDataSets.IivWtVN2ikiLCC6qjaBJcA, 61918b7a-e496-4b63-992b-b83299b21e43 ZXingLibDemo */");
selectBuilder.Append("SELECT NULL o0, \"enuser1\".\"name\" o1, \"enuser1\".\"email\" o2, \"enuser1\".\"photourl\" o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser1\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser1\".\"id\" = @qpusId) AND (\"enuser1\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser1\".\"id\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_8430333e95ceffc00def96d8abb01f75 outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, false, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Common.UserProfile.GetUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8430333e95ceffc00def96d8abb01f75 _tmp = new RL_8430333e95ceffc00def96d8abb01f75();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Common.UserProfile.GetUserById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8430333e95ceffc00def96d8abb01f75)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}


    

    

}
