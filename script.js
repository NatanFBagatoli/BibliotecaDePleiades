const links = document.querySelectorAll('.nav-menu a');
const pages = document.querySelectorAll('.page');

links.forEach(link => {
    link.addEventListener('click', (e) => {
        e.preventDefault();

        const targetId = link.getAttribute('href').substring(1);

                pages.forEach(page => page.classList.remove('active'));

                const targetPage = document.getElementById(targetId);
                if (targetPage) targetPage.classList.add('active');

                links.forEach(l => l.classList.remove('active-link'));
                link.classList.add('active-link');
    })
})