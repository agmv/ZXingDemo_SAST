export default function ($parameters, $actions, $roles, $public) {
// The message info comes from TS to pass the coordinate values
var messageOutput = JSON.parse($parameters.Message);

// Set the output values to assign
$parameters.SuccessMessage = messageOutput.message;
$parameters.CenterLatitude = parseFloat(messageOutput.lat);
$parameters.CenterLongitude = parseFloat(messageOutput.lng);
};




