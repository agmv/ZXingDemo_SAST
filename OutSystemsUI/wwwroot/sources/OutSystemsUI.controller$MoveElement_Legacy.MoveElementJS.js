export default function ($parameters, $actions, $roles, $public) {
if($parameters.Target && $parameters.Element) 
{
    var screenEl = document.getElementById($parameters.Element);
    var element = document.querySelector($parameters.Target);
    
    if(screenEl && element) 
    {
        setTimeout(function (){
            element.appendChild(screenEl);
        }, 200);
    }
}
};




