export default function ($parameters, $actions, $roles, $public) {
if($parameters.IsRTL) {
    $parameters.CarouselObj.next();
} else {
    $parameters.CarouselObj.previous();
}
};




