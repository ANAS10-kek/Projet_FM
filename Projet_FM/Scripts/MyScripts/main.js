$(document).ready(function () {

    if ($(window).width() >= 500) {
        $(".eat-div").hover(function () {

            $(".caption2").fadeIn(1000);
            $('.caption').animate({ marginTop: '10%'}, 1000);
            // $(".caption").css('margin-top', '10%');

        }, function () {

            $(".caption2").fadeOut(1000);
            $('.caption').animate({ marginTop: '60%'}, 1000);
        }
        );
        $(".offer-div").hover(function () {
            $(".caption3").fadeIn(1000);
            $('.caption4').animate({ marginTop: '10%'}, 1000);
        }, function () {
            $(".caption3").fadeOut(1000);
            $('.caption4').animate({ marginTop: '60%'}, 1000);
        });
    }
    else {
        $(".caption").css('margin-top', '10%');
        $(".caption4").css('margin-top', '10%');
        $(".caption2").show("slow");
        $(".caption3").css({ 'display': 'block' });
    }
    var a = false;
    function showcont() {
        if (a == false) {
            $("#fleche i").removeClass("fa-arrow-up text-primary");
            $("#fleche i").addClass("fa-arrow-down text-danger");
            $(".btn_display").css('background-color','#25728b');
            a = true;
        }
        else
            if (a == true) {
                $("#fleche i").removeClass("fa-arrow-down text-danger");
                $("#fleche i").addClass("fa-arrow-up text-primary");
                $(".btn_display").css('background-color','#000000');
                a = false;
            }
        $("#div_cacher").slideToggle("slow");;
    }
    $(".btn_display").click(function () {
        showcont();
    });
    $("#linkcontact_footer").click(function () {
        showcont();
    });
    ///button scroll top
    var btn = $('#button');

    $(window).scroll(function () {
        if ($(window).scrollTop() > 300) {
            btn.addClass('show');
        } else {
            btn.removeClass('show');
        }
    });

    btn.on('click', function () {
        $('html, body').animate({ scrollTop: 0 }, '300');
    });
    $(".cont_btn_diner,.btn_diner").hover(function () {
        $(".ligne").animate({width:"200px"},500);
        }, function () {
            $(".ligne").animate({width:"40px"},500);
        }
    );
    $(".cont_btn_diner_1,.btn_diner_1").hover(function () {
        $(".ligne_1").animate({width:"200px"},500);
        }, function () {
            $(".ligne_1").animate({width:"60px"},500);
        }
    );
});




