var utilities = (function ($) {

    function submitAjaxForm($form) {

        var data = $form.serialize();

        $.ajax({
            type: $form.attr("method"),
            url: $form.attr("action"),
            data: data,
            cache: true,
            contentType: "application/x-www-form-urlencoded; charset=UTF-8",
            processData: true,
        })
    }

    return {
        submitAjaxForm: submitAjaxForm
    };

})(jQuery);
