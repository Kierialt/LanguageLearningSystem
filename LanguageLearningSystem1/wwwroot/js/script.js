document.addEventListener("DOMContentLoaded", () => {
    const startBtn = document.getElementById("startBtn");
    const contactBtn = document.getElementById("contactBtn");

    // Przycisk „Rozpocznij trening”
    startBtn.addEventListener("click", () => {
        window.location.href = "/Lesson/Start";
    });

    // Przycisk „Skontaktuj się z nami”.
    contactBtn.addEventListener("click", () => {
        window.location.href = "mailto:w70625@student.wsiz.edu.pl"; 
    });
});

