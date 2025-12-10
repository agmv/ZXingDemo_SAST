export default function ($parameters, $actions, $roles, $public) {
let value = $parameters.Value;

if(value >= 1 && value <= $parameters.TotalPages) 
{
    // Go to Selected Page
    value = ($parameters.StartIndex + $parameters.MaxRecords) / $parameters.MaxRecords;
} 
else if(value > $parameters.TotalPages && $parameters.StartIndex > 0) {
    // Go to Last Page
    value = $parameters.TotalPages + 1;
} 
else {
    // Go to First page
    value = 1;
}

$parameters.GotoValue = value;
};




