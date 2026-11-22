// ============================================
// CSE 111 — Task 1: Profile Page
// Student: Ahmed Yasser | ID: 226103967
// ============================================

// ---------- Dark Mode Toggle ----------
const darkToggle = document.getElementById("darkToggle");

darkToggle.addEventListener("click", function () {
    document.body.classList.toggle("dark");

    // Update button text
    if (document.body.classList.contains("dark")) {
        darkToggle.textContent = "☀️ Toggle Light Mode";
    } else {
        darkToggle.textContent = "🌙 Toggle Dark Mode";
    }
});
