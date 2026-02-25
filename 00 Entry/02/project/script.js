document.addEventListener('DOMContentLoaded', function() {
    const userForm = document.getElementById('userForm');
    const successMessage = document.getElementById('successMessage');

    userForm.addEventListener('submit', function(event) {
        event.preventDefault();

        const name = document.getElementById('name').value.trim();
        const email = document.getElementById('email').value.trim();

        const userData = {
            name: name,
            email: email,
            timestamp: new Date().toISOString()
        };

        console.log('Form Submitted!');
        console.log('User Data:', userData);
        console.log('Name:', name);
        console.log('Email:', email);

        successMessage.style.display = 'block';

        setTimeout(function() {
            userForm.reset();
            successMessage.style.display = 'none';
        }, 2000);
    });
});
