// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const loginSection = document.querySelector('.login-section');
const loginLink = document.querySelector('.login-link');
const registerLink = document.querySelector('.register-link');
const registerForm = document.querySelector('.formbox.register');
const loginForm = document.querySelector('.formbox.login');

registerLink.addEventListener('click', () => {
    loginSection.classList.add('active');
    registerForm.style.display = 'block';
    loginForm.style.display = 'none';
});

loginLink.addEventListener('click', () => {
    loginSection.classList.remove('active');
    registerForm.style.display = 'none';
    loginForm.style.display = 'block';
});
