var DomController = DomController || {};
DomController.clearText = function (element) {
    if (element) {
        element.innerText = "";
    }
}

/**
 * 
 * @param {HTMLElement} element
 * @param {string} text
 */
DomController.setText = function (element, text) {
    if (element) {
        element.innerText = text;
    }
}

DomController.getValue = function (element) {
    return element.value;
}

DomController.getSelectedValue = function (dropDownElement) {
    console.log(dropDownElement.value);
}