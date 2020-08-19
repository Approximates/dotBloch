mergeInto(LibraryManager.library, {

    copyValueToClipboard: function(value) {

        var tempTextarea = document.createElement("textarea");
        document.body.appendChild(tempTextarea);
        tempTextarea.value = Pointer_stringify(value);
        tempTextarea.select();
        document.execCommand("copy");
        document.body.removeChild(tempTextarea);
    }

});
