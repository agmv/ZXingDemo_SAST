export default function ($parameters, $actions, $roles, $public) {
var events = JSON.parse($parameters.EventList);

$parameters.DisabledDates = [];

for(var i=0; i< events.length; i++) {
    var day = new Date(events[i]).toDateString();
    $parameters.DisabledDates.push(day);
}

$parameters.DisabledDates = $parameters.DisabledDates.toString();
};




