export default function ($parameters, $actions, $roles, $public) {
if($parameters.TimeoutId_CheckLightbox > 0) 
{
    clearTimeout($parameters.TimeoutId_CheckLightbox);
}

if($parameters.TimeoutId_AppendElement > 0) 
{
    clearTimeout($parameters.TimeoutId_AppendElement);
}
};




