$(function () {
    $("form").submit(function (evt) {
        evt.preventDefault();

        const payload = $(this).serialize();

        console.log(payload);

        $.ajax({
            url: "/api/tickets",
            type: "POST",
            data: payload,
            success: function (resp) {
                console.log(resp);
            }
        });
    });
});