using System.Diagnostics;
namespace ssOutSystemsMaps {
public partial class ExtendedActions {
/// <summary>
/// Action: GetVerbosity
/// </summary>

public static async Task<RC_a9d171af5978fe3e4b7ef9f38c0c5a39> GetVerbosity(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_a9d171af5978fe3e4b7ef9f38c0c5a39 outParamRecord = default;
outParamRecord = new RC_a9d171af5978fe3e4b7ef9f38c0c5a39();

using var entityActionActivity = activitySource.CreateEntityActionActivity("GetVerbosity", "e622b827-468a-483f-9c56-4d5bc2d8635b.#GetEntity", "OutSystemsMaps", "95bb31d1-f079-4fd6-ab2e-5c8326855aaa");
try {
outParamRecord = ENVerbosityEntity.GetRecordById(inParamId);
} catch {
throw DatabaseErrorsHelper.StaticEntityRecordNotFound("Verbosity", "inParamId");
}
return outParamRecord;
}

}
}
