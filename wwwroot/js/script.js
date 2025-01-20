document.addEventListener("DOMContentLoaded", () => {
    const startBtn = document.getElementById("startBtn");
    const contactBtn = document.getElementById("contactBtn");

    // Кнопка "Начать обучение"
    startBtn.addEventListener("click", () => {
        window.location.href = "/Lesson/Start"; // Замени на реальный маршрут, который ведет к обучению
    });

    // Кнопка "Связаться с нами"
    contactBtn.addEventListener("click", () => {
        window.location.href = "mailto:w70625@student.wsiz.edu.pl"; // Открывает почтовый клиент
    });
});
document.addEventListener("DOMContentLoaded", () => {
    const contactBtn = document.getElementById("contactBtn");

    // Кнопка "Связаться с нами"
    contactBtn.addEventListener("click", () => {
        window.location.href = "mailto:w70625@student.wsiz.edu.pl"; // Открывает почтовый клиент
    });
});
