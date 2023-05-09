var project = (function ($) {

    function init() {

        //Adds a Project
        $("add-project-container").on("click", ".add-project-btn"), function () {
            var $form = $(".add-project-form");
            $form.attr("action", $(this).data("action"));
            utilities.submitAjaxForm($form);
            $(this).prop("disabled", true);
        }
    }

    return {
        init: init
    };

})(jQuery);