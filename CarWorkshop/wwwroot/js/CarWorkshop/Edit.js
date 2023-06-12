$(document).ready(function () {
    const RenderCarWorkshopServices = (services, container) => {
        container.empty();

        for (const service of services) {
            container.append(
            `<div class="car border-secondary mb-3" style="max-width: 18rem;">
                 <div class="card-header">${service.cost}</div>
                 <div class="card-body">
                    <h5 class="card-title">${service.description}</h5>
                 </div>
             </div>`)           
        }
    }

    const LoadCarWorkshopService = () => {
        const container = $("#services")
        const carWorkshopEncodedName = container.data("encodedName");

        $.ajax({
            url: `/CarWorkshop/${carWorkshopEncodedName}/CarWorkshopService`,
            type: 'get',
            success: function (data) {
                if (!data.lenght) {
                    container.html("There are no services for this car workshop")
                } else {
                    RenderCarWorkshopServices(data, container)
                }
            },
            error: function () {
                toastr["error"]("Something went wrong")
            }
        })
    }

    LoadCarWorkshopService()

    
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
    });
});