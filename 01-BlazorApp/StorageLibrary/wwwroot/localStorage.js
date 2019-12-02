// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

window.blazorLocalStorage = {
    get: function (key) {
        if (key in localStorage) {
            return JSON.parse(localStorage[key]);
        }
        else {
            return 0;
        }
    },

    set: function (key, value) {
        localStorage[key] = JSON.stringify(value);
    }
};