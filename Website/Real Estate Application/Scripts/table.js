var rows = document.getElementsByTagName("tr");

for (i = 1; i < rows.length; i++) {
    rows[i].onclick = rowClick;
}

function rowClick() {
    this.style.backgroundColor = "#4a4a4a";

    for (var i = 1; i < rows.length; i++) {
        if (rows[i].rowIndex != this.rowIndex) {
            rows[i].style.backgroundColor = "#888a86";
        }
    }
}