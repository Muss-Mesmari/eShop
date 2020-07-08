// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


// Hover Card effect //
$(document).ready(function () {
    console.log("document is ready");

    $(".card").hover(
        function () {
            $(this).addClass('shadow-lg').css('cursor', 'pointer');
        }, function () {
            $(this).removeClass('shadow-lg');
        }
    );
});
/* -------------- */



/* goToTopButton */
var goToTopButton = document.getElementById("goToTopBtn");

// When the user scrolls down 20px from the top of the document, show the button
window.onscroll = function () { scrollFunction() };

function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        goToTopButton.style.display = "block";
    } else {
        goToTopButton.style.display = "none";
    }
}

// When the user clicks on the button, scroll to the top of the document
function topFunction() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}
/* -------------- */




// scroll spy the event detail page
$('body').scrollspy({ target: '#side-menu-list'})
/* -------------- */


// add new s_CreateSchedule line to te CreateStepTwo 

//$("#schedule-row").ready(function () {
//    $("#add-row").click(function () {
//        $("#customFields").append('<tr valign="top"><td><div class="container-fluid bg-transparent"><div class="form-row m-3 align-items-center justify-content-center"><div class="col-md-3 pt-3"><div class="form-group"><label asp-for="Day.DayOfWeek" class="control-label"></label><select asp-for="Day.DayOfWeek" class="form-control" asp-items="@(new SelectList(Enum.GetValues(typeof(DayOfWeek))))"><option>Choose days</option></select><span asp-validation-for="@Day.DayOfWeek" class="text-danger"></span></div></div><div class="col-md-3 pt-3"><div class="form-group"><label asp-for="@Times.TimeStart" class="control-label"></label><input asp-for="@Times.TimeStart" class="form-control" /><span asp-validation-for="@Times.TimeStart" class="text-danger"></span></div></div><div class="col-md-3 pt-3"><div class="form-group"><label asp-for="Times.TimeEnd" class="control-label"></label><input asp-for="Times.TimeEnd" class="form-control" /><span asp-validation-for="Times.TimeEnd" class="text-danger"></span></div></div><div class="col-md-3 pt-3"> <a href="javascript:void(0);" id="add-row" role="button" class="remove-row btn btn-outline-danger mt-3 text-nowrap"><i class="fa fa-minus"></i></a></div></div></div></td></tr>');
//        $(".remove-row").on('click', function () {
//            $(this).parent().parent().remove();
//        });
//    });
//});                                                                                                                                                                 