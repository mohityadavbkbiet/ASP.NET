document.addEventListener("DOMContentLoaded", function() {
    const textArea = document.querySelector("textarea");
    textArea.addEventListener("input", function() {
        // Basic text enhancement actions, like trimming whitespace as user types
        textArea.value = textArea.value.replace(/\s+/g, ' ').trim();
    });
});
