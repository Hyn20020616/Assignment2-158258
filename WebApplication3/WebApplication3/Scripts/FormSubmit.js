
    // Add an event listener to listen for form submission events.
    document.addEventListener('DOMContentLoaded', function () {
        var form = document.getElementById('contact');
    form.addEventListener('submit', function (event) {
        event.preventDefault();

    // A dialog box is displayed indicating that the submission is successful.
        alert('You have successfully submitted your wish to join, please wait for me to contact you, thank you ~');
        });
    });
