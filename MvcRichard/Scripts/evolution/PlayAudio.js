
    var audioElements = document.querySelectorAll('audio');
    var currentAudioIndex = 0;

    function playNextAudio() {
        // Pause the current audio
        audioElements[currentAudioIndex].pause();

    // Move to the next audio element
    currentAudioIndex = (currentAudioIndex + 1) % audioElements.length;

    // Play the next audio
    audioElements[currentAudioIndex].play();
    }

    // Set up the 'ended' event for each audio element
    audioElements.forEach(function (audioElement) {
        audioElement.addEventListener('ended', playNextAudio);
    });

    // Function to handle the play event
    function playClickAudio1(current) {

        currentAudioIndex = current;

    }

    var currentlyPlaying = null;

    audioElements.forEach(function (audioElement) {
        audioElement.addEventListener('play', function (event) {
            if (currentlyPlaying && currentlyPlaying !== event.target) {
                // Pause the currently playing track if it's different from the clicked one
                currentlyPlaying.pause();
            }
            currentlyPlaying = event.target;
        });
    });

    try {
        // Code that may throw an exception
        audioElements[currentAudioIndex].play();

    } catch (error) {
        // Code to handle the exception
        console.error("An error occurred:", error.message);
    } finally {
        // Code that will always be executed, regardless of whether an exception occurred
        console.log("Finally block executed");
    }


