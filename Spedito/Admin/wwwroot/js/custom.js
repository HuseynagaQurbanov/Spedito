$(document).ready(function () {
    $(".deleteitem").click(function (e) {
        e.preventDefault();
        let href = $(this).attr("href");
        $.confirm({
            title: 'Delete information',
            content: 'Are you sure?',
            buttons: {
                'Yes': {
                    btnClass: "btn-danger",
                    action: function () {
                        location.href = href;
                    }
                },
                'No': function () {

                }
            }
        });
    });
});