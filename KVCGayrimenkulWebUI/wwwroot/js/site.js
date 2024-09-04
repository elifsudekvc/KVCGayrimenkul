

document.addEventListener('DOMContentLoaded', () => {
    const navbar = document.querySelector('.navbar');
    const kvc = document.querySelector('.kvcTitle');
    const navLinks = document.querySelectorAll('.nav-link');

    const handleScroll = () => {
        if (window.scrollY > 290) {
            navbar.classList.add('navbar-scrolled');
            kvc.classList.add('navlink-scrolled');
            navLinks.forEach(link => link.classList.add('navlink-scrolled'));
        } else {
            navbar.classList.remove('navbar-scrolled');
            kvc.classList.remove('navlink-scrolled');
            navLinks.forEach(link => link.classList.remove('navlink-scrolled'));
        }
    };

    window.addEventListener('scroll', handleScroll);

    window.addEventListener('beforeunload', () => {
        window.removeEventListener('scroll', handleScroll);
});
