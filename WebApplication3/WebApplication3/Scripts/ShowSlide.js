
    //showSlides();
    // Gets all the carousel containers
    const slideshowContainers = document.querySelectorAll('.slideshow-container');

    // Iterate through each carousel container and add carousel functionality to it.
    slideshowContainers.forEach(container => {
        const slides = container.querySelectorAll('.slide');
    let currentSlide = 0;

    // The first cast diagram is initially displayed.
    slides[currentSlide].style.display = 'block';

    // Define the carousel function.
    function nextSlide() {
        slides[currentSlide].style.display = 'none';
    currentSlide = (currentSlide + 1) % slides.length;
    slides[currentSlide].style.display = 'block';
        }

    setInterval(nextSlide, 2000); 
    });

