 function MouseTrack() {

    var trackableElement;
    var startX = 0, startY = 0;
    var currentX = 0, currentY = 0;
    var touchingElement = false;
    var callbackStart, callbackMove, callbackEnd;
    var startTime;
    var doPreventDefault = false;
    var translateX;
    var translateY;
    var timeTaken;


    var init = function(element, start, move, end) {

        trackableElement = element;
        
        callbackStart = start;
        callbackMove = move;
        callbackEnd = end;

        startTime = new Date().getTime();

        addEventListeners();

    };
    
    var destroy = function() {
        removeEventListeners();
    };

    var addEventListeners = function () {

        trackableElement.addEventListener('mousedown', onMouseDown, false);
        trackableElement.addEventListener('mousemove', onMouseMove, false);
        trackableElement.addEventListener('mouseup', onMouseEnd, false);
        trackableElement.addEventListener('mouseleave', onMouseEnd, false);
    };
    
    var removeEventListeners = function () {

        trackableElement.removeEventListener('mousedown', onMouseDown);
        trackableElement.removeEventListener('mousemove', onMouseMove);
        trackableElement.removeEventListener('mouseup', onMouseEnd);
        trackableElement.removeEventListener('mouseleave', onMouseEnd);
    };

    
    var onMouseDown = function (evt) {
        
        startTime = new Date().getTime();
        startX = evt.clientX;
        currentX = startX;
        
        startY = evt.clientY;
        currentY = startY;

        touchingElement = true;

        callbackStart(startX, startY);

    };

    var onMouseMove = function (evt) {
        
       if(doPreventDefault){
            evt.preventDefault();
       }
       
       if (!touchingElement)
          return;

      currentX = evt.clientX;
      currentY = evt.clientY;
      translateX = currentX - startX;
      translateY = currentY - startY; 
    
      callbackMove(evt, currentX, currentY, translateX, translateY);
  };

  var onMouseEnd = function (evt) {
      
    if(doPreventDefault){
        evt.preventDefault();
    }
   
    if(!touchingElement)
      return;

      touchingElement = false;
      translateX = currentX - startX;
      translateY = currentY - startY; 

      timeTaken = (new Date().getTime() - startTime);
  
      callbackEnd(currentX, currentY, translateX, translateY, timeTaken);

    };

    return {

        init : function(element, start, move, end) {
            init(element, start, move, end);        
        },
        setPreventDefault : function(toPreventDefault) {
            doPreventDefault = toPreventDefault;
        },
        destroy : function() {
            destroy();
        }
    };
} 