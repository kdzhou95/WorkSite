var utilities = (function ($) {

    function submitAjaxForm($form, callbacks) {

        var data = $form.serialize();
        window.alert("starting");
        $.ajax({
            type: $form.attr("method"),
            url: $form.attr("action"),
            data: data,
            cache: true,
            contentType: "application/x-www-form-urlencoded; charset=UTF-8",
            processData: true,
        })
            .done(callbacks.doneCallback)
            .fail(callbacks.failCallback)
    }

    return {
        submitAjaxForm: submitAjaxForm
    };

})(jQuery);
