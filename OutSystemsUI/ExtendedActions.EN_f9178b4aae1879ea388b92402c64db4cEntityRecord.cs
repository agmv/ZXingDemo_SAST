using System.Diagnostics;
namespace ssOutSystemsUI {
public partial class ExtendedActions {
/// <summary>
/// Action: GetIdentityProvider
/// </summary>

public static async Task<RC_3bbfc6c91fcd8a2dd97847564be30682> GetIdentityProvider(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_3bbfc6c91fcd8a2dd97847564be30682 outParamRecord = default;
outParamRecord = new RC_3bbfc6c91fcd8a2dd97847564be30682();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetIdentityProvider", "8ad07004-49d8-42d6-93d1-73727c698b14.#GetEntity", "OutSystemsUI", "8be17f2a-431c-4958-b894-c77b988a7271");
try {
outParamRecord = ENIdentityProviderEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("IdentityProvider", "inParamId");
}
return outParamRecord;
}

}
}
