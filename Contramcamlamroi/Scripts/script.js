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

window.onscroll = function () { scrollFunction() };

function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        document.getElementById(".navbar-inverse").style.top = "0";
    } else {
        document.getElementById(".navbar-inverse").style.top = "-100%";
    }
}
<script type="text/javascript">
    $(document).ready(function()
    {
        $("#slideshow > div:gt(0)").hide();
    setInterval(function()
    {
        $('#SlideshowImages > div:first').fadeOut(1000).next().fadeIn(1000).end().appendTo('#SlideshowImages');  
        }, 3000);  
    });
</script>