var suscess = false;
$(function () {
    var PlaceHolderElement = $('#PlaceHolderHere');
    $('button[data-toggle="ajax-modal"]').click(function (event) {
        var url = $(this).data('url');
        var decodeURL = decodeURIComponent(url);
        $.get(decodeURL).done(function (data) {
            PlaceHolderElement.html(data);
            PlaceHolderElement.find('.modal').modal('show');
        })
    })
    PlaceHolderElement.on('click', '[data-save="modal"]', function (event) {
        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var form_data = new FormData($(this).parents('.modal').find('form')[0]);
        $.ajax({
            method: 'POST',
            url: actionUrl,
            data: form_data,
            processData: false,
            contentType: false,
            success: function (data) {
                // handle response here...
                PlaceHolderElement.html(data);
                PlaceHolderElement.find('.modal').modal('show');
                suscess = true;
            }
        });

       

     //   var sendData = form.serialize();
     //   PlaceHolderElement.find('.modal').modal('hide');
        //$('body').removeClass('modal-open');
     //   $('.modal-backdrop').remove();
    //    $.post(actionUrl, sendData).done(function (data) {
     //       PlaceHolderElement.html(data);
    //        PlaceHolderElement.find('.modal').modal('show');
     //       suscess = true;
     //   })
        /*$.ajax({
            type: "POST",
            data: sendData,
            url: actionUrl,
            dataType: 'json',
            contentType: false,
            processData: false,
            success: function (response) {
                if (response.success) {
                    alert(response.responseText);
                    PlaceHolderElement.find('.modal').modal('hide');

                } else {
                    // DoSomethingElse()
                    alert(response.responseText);
                }
            },
            error: function (response) {
                alert("error!");  // 
            }

        });*/
    })
});
$("#PlaceHolderHere").on("hidden.bs.modal", function () {
    // put your default event here
    if (suscess == true) {
        location.reload(true);
    }

});

   