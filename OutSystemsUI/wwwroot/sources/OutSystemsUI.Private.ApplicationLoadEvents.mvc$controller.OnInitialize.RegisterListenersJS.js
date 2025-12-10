export default function ($parameters, $actions, $roles, $public) {
    var start = new Date();
    // Check if the app is currently being upgraded
    var isUpgrading = $public.ApplicationLifecycle.isUpgradingVersion();
    
    var progressCallback = function(loaded, total) { 
        $actions.TriggerOnUpgradeProgress(loaded, total); 
    };
    
    var finishCallback = function() {
        var elapsedMs = new Date() - start;
        var timeout = Math.max($parameters.MinDisplayTimeMs - elapsedMs, 0);
        $parameters.TimeoutId = setTimeout(function() {
            $actions.TriggerOnLoadComplete(window.location.href);    
        }, timeout);
    };
    
    // When there is no upgrade, we need to mimic the progress using the MinDisplayTimeMs
    if (!isUpgrading) {
        var loaded = 0;
        var interval = Math.ceil($parameters.MinDisplayTimeMs / 10);
        var timerId = setInterval(function() {
            progressCallback(++loaded, 10);
            if (loaded === 10) {
                clearInterval(timerId);
            }
        }, interval);
        
        $parameters.IntervalId = timerId;
    }
    $public.ApplicationLifecycle.listen({
        // When there is no upgrade, we'll provide the feedback
        onUpgradeProgress: isUpgrading ? progressCallback : null,
        onLoadComplete: finishCallback
    });
};




