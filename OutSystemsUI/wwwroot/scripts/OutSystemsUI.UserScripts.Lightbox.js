function Lightbox() {
    var gallery;
    
    var parseThumbnailElements = function(el) {
        var linkEl = el,
            figureEl,
            size,
            group,
            groupElements,
            item,
            items = [];
            
        linkEl = el.querySelector("a");
        group = linkEl.getAttribute('data-group');

        if(group !== "") {

            groupElements = document.querySelectorAll("[data-group='" + group + "']");

            for(var i = 0; i < groupElements.length; i++) {
                linkEl = groupElements[i];
                figureEl = linkEl.parentNode;
                captionEl = figureEl.querySelector("figcaption");

                size = linkEl.getAttribute('data-size').split('x');
    
                // create slide object
                item = {
                    src: linkEl.getAttribute('href'),
                    w: parseInt(size[0], 10),
                    h: parseInt(size[1], 10)
                };

                if(captionEl.children.length >= 1) {                    
                    item.title = captionEl.innerHTML;
                }

                if(linkEl.children.length > 0) {
                    item.msrc = linkEl.children[0].children[0].getAttribute('src');
                }

                item.el = figureEl;
                items.push(item);
          }
        } else {       
            figureEl = linkEl.parentNode;
            captionEl = figureEl.querySelector("figcaption");

            size = linkEl.getAttribute('data-size').split('x');

            // create slide object
            item = {
                src: linkEl.getAttribute('href'),
                w: parseInt(size[0], 10),
                h: parseInt(size[1], 10)
            };

            if(captionEl.children.length >= 1) {                    
                item.title = captionEl.innerHTML;
            }

            if(linkEl.children.length > 0) {
                item.msrc = linkEl.children[0].children[0].getAttribute('src');
            }

            item.el = figureEl;
            items.push(item);
        }      

        return items;
    };

    var closest = function closest(el, fn) {
        return el && ( fn(el) ? el : closest(el.parentNode, fn) );
    };

    var onThumbnailsClick = function(e) {  
        var lightboxitems = document.querySelectorAll(".lightbox-item");
        
        for(var i = 0; i< lightboxitems.length; i++) {
            
            // read thumbnail data
            var thumbnail = lightboxitems[i].querySelector(".lightbox-content-thumbnail img");
            
            if(thumbnail !== null) {
                var width = thumbnail.naturalWidth;
                var height = thumbnail.naturalHeight;
                var link = lightboxitems[i].querySelector("a");
                var zoom = link.getAttribute("data-zoom");
                var hasImage = link.getAttribute("href") !== "";
                var currentImage;
                
                // write image data
                link.setAttribute("data-size", width*zoom + "x" + height*zoom);
                currentImage = thumbnail.src;
                
                if(!hasImage && currentImage !== link.href) {
                    link.href = currentImage;
                }
            }
            
        }
        
        e = e || window.event;
        e.preventDefault ? e.preventDefault() : e.returnValue = false;

        var eTarget = e.target || e.srcElement;

        var clickedListItem = closest(eTarget, function(el) {
            return (el.tagName && el.tagName.toUpperCase() === 'FIGURE');
        });

        if(!clickedListItem) {
            return;
        }

        var clickedGallery = clickedListItem.parentNode,
            linkEl = clickedGallery.querySelector("a"),
            groupName = linkEl.getAttribute('data-group'),
            groupElements,
            nodeIndex = 0,
            index = 0;

        if(groupName !== "") {
          groupElements = document.querySelectorAll("[data-group='" + groupName + "']");
          for (i = 0; i < groupElements.length; i++) {
            if(groupElements[i] === linkEl) {
                index = nodeIndex;
                break;
            }
            nodeIndex++;
          }
        }      

        if(index >= 0) {          
            openPhotoSwipe( index, clickedGallery );
        }
        return false;
    };   

    var openPhotoSwipe = function(index, galleryElement, disableAnimation, fromURL) {
        var pswpElement = document.querySelectorAll('.pswp')[0],
            history = galleryElement.classList.contains('disable-url') ? false : true,
            options,
            items;

        items = parseThumbnailElements(galleryElement);
        

        options = {

            galleryUID: galleryElement.getAttribute('data-pswp-uid'),            
            shareEl: false,
            fullscreenEl: false,
            index: index,
            history: history,

            getThumbBoundsFn: function(index) {               
                var thumbnail = items[index].el.getElementsByTagName('img')[0],
                    pageYScroll = window.pageYOffset || document.documentElement.scrollTop,
                    rect = thumbnail.getBoundingClientRect();
                return {x:rect.left, y:rect.top + pageYScroll, w:rect.width};
            }

        };        

        gallery = new PhotoSwipe( pswpElement, PhotoSwipeUI_Default, items, options);
        gallery.init();
    };
    
    return { 

        openPhoto: function(itemId) {
            
            item = document.getElementById(itemId);
            
            onThumbnailsClick();
        }
    };
}