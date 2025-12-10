export default function ($parameters, $actions, $roles, $public) {
// Find the right button to focus on
let currentButton;

if($parameters.IsFirstButton)
{
    currentButton = document.getElementById($parameters.FirstButtonElemId);
}
else if($parameters.IsLastButton)
{
    const lastButton = document.getElementById($parameters.LastButtonElemId);
    if (lastButton) {
        currentButton = lastButton;
    } else {
        //if last button was not found it means the pagination has less than 4
        //knowing this we need to find the last button on the last item from pagination list
        const pageButtonsList = document.querySelectorAll('#' + $parameters.PaginationListId + " .pagination-button");
        if(pageButtonsList.length > 0){
            currentButton = pageButtonsList[pageButtonsList.length-1];
        }
    }
}
else if($parameters.EdgeFocusableElemId && !$parameters.IsFirstButton && !$parameters.IsLastButton)
{
    currentButton = document.getElementById($parameters.EdgeFocusableElemId);
} 
else
{
    //will get the current element from the list of page buttons
    currentButton = document.querySelector('#' + $parameters.PaginationListId + 
    ' > .pagination-button[aria-current=true]');
}

// Check if such a button exists and focus on it
if (currentButton) {
    currentButton.focus();
}
};




