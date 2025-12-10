export default function ($parameters, $actions, $roles, $public) {
if($parameters.IsRTL) {
    $parameters.CarouselObj.previous();
} else {
    $parameters.CarouselObj.next();
}
};




