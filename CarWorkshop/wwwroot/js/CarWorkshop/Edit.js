$(document).ready(function () {
    $("#carWorkshopServiceModal form").submit(function (event) {
        event.preventDefault();

        $.ajax({
            url: $(this).attr('action'),
            type: $(this).attr('method'),
            data: $(this).serialize(),
            success: function (data) {
                toastr["success"]("Create carworkshop service")
            },
            error: function () {
                toastr["error"]("Something went wrong")
            }
        })
    })
});