// Select Elements
const openPopup = document.getElementById("openPopup");
const closePopup = document.getElementById("closePopup");
const closePopupBtn = document.getElementById("closePopupBtn");
const popupContainer = document.getElementById("popup");

// Open Popup
openPopup.addEventListener("click", () => {
    popupContainer.classList.add("active");
});

// Close Popup (X Button & Close Button)
closePopup.addEventListener("click", () => {
    popupContainer.classList.remove("active");
});

closePopupBtn.addEventListener("click", () => {
    popupContainer.classList.remove("active");
});

// Close Popup on Click Outside
popupContainer.addEventListener("click", (e) => {
    if (e.target === popupContainer) {
        popupContainer.classList.remove("active");
    }
});
