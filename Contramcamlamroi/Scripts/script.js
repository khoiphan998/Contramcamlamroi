function ChangeImage(UploadIamge, previewImg) {
    if (UploadIamge.files && UploadIamge.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $(previewImg).attr('src', e.target.result);

        }
        reader.readAsDataURL(UploadIamge.files[0]);
    }
}
$('.navTrigger').click(function () {
    $(this).toggleClass('active');
    console.log("Clicked menu");
    $("#mainListDiv").toggleClass("show_list");
    $("#mainListDiv").fadeIn();

});

  