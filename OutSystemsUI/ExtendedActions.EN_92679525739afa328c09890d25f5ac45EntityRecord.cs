using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetStackedCardsPosition
/// </summary>

public static async Task<RC_967cb65710fd1a346ebf0b0d8dbea56b> GetStackedCardsPosition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_967cb65710fd1a346ebf0b0d8dbea56b outParamRecord = default;
outParamRecord = new RC_967cb65710fd1a346ebf0b0d8dbea56b();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetStackedCardsPosition", "71865eb4-55fe-40a5-bc7f-45b005a3a0b5.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENStackedCardsPositionEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("StackedCardsPosition", "inParamId");
}
return outParamRecord;
}

}
}
