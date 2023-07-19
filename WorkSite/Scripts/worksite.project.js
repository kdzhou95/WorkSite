var project = (function ($) {

    function init() {

        //Adds a Project
        $(".add-project-container").on("click", ".add-project-btn", function () {
            var $form = $(".add-project-form");
            $form.attr("action", $(this).data("action"));
            var pageUrl = $(this).data("redirect");
            utilities.submitAjaxForm($form, createProjectsCallbacks(setPageUrl(pageUrl)));
            $(this).prop("disabled", true);
        });
    }

    function setPageUrl(url) {
        return function () {
            history.pushState(null, null, url)
        };
    }

    function createProjectsCallbacks(actions) {
        return {
            doneCallback: function () {
                window.alert("Success");
                window.location.href = "/Projects";
            },
            failCallback: function () {
                window.alert("Failed");
                window.location.href = "/Projects";
            }
        };
    }

    return {
        init: init
    };

})(jQuery);