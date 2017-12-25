$(document).ready(function () {

    $(window).scroll(function (event) {
        /* Act on the event */
        var n = $(this).scrollTop();

        if (n == 0) {
            $(".navbar-inverse").removeClass("hiendam").removeClass("hienmo");
            $(".lentop").removeClass("GT");
        }
        else if (n >= ($(window).height() / 4)) {
            $(".col-md-4.figure-filter").each(function (i) {
                setTimeout(function () {
                    $(".col-md-4.figure-filter").eq(i).addClass("show");
                }, 200 * (i + 1));
            });
        }
        else if (n >= 100 && 400 >= n) {
            $(".navbar-inverse").addClass("hienmo").removeClass("hiendam");
        }
        if (n > 400) {
            $(".navbar-inverse").addClass("hiendam").removeClass("hienmo");
        }
        if (n >= ($(window).height() - 50)) {
            $(".col-md-4.figure-index").each(function (i) {
                setTimeout(function () {
                    $(".col-md-4.figure-index").eq(i).addClass("show");
                }, 250 * (i + 1));
            });
        }
        if (n >= ($(document).height() / 3)) {
            $(".lentop").addClass("GT");
        }
        if (n >= ($(document).height() / 2.5)) {
            $(".col-md-4.md4-img").each(function (i) {
                setTimeout(function () {
                    $(".col-md-4.md4-img").eq(i).addClass("show");
                }, 300 * (i + 1));

            });
        }
    });


    $('a.support-cus').click(function () {
        window.onload = codeAddress;
    });

    function codeAddress() {
        var x = $(window).height() / 7;
        var y = $("#sec2").offset().top - x;
        //var link = $("#sec2").attr('data-ajax');
        //var adr = location.replace("/Contact/Contact");
        //var page = link.replace(link, adr);
        $('html, body').animate({ scrollTop: y }, 1500);
    }

    var myRed = setInterval(function () {
        note()
    }, 1000);

    function note() {
        $(".lentop i.fa").each(function (i) {
            setTimeout(function () {
                $(".lentop i.fa").eq(i).css('color', 'red');
            }, 300 * (i + 1));
            $(".lentop i.fa").eq(i).css('color', 'black');
        });
    }

    $(".lentop").click(function () {
        $('html, body').animate({ scrollTop: 0 }, 2300);
    });
});