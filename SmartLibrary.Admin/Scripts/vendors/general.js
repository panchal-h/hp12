var dateCarouselLoadFlag = false;
$(document).ready(function () {
    //Prevent Page Reload on all # links
    $("body").on("click", "a[href='#']", function (e) {
        e.preventDefault();
    });
    //book quick view
    $("body").on("click", ".book-quick-view-backdrop a,.book-quick-view .close-btn", function (e) {
        if ($("html,body").hasClass('book-quick-view-open')) {
            /*$("body").css("padding-right", "");*/
            $("html,body").removeClass('book-quick-view-open');
            /*var padding = parseInt($(window).outerWidth()) - parseInt($("body").outerWidth());
            if ($("body").attr("id") == "arabic") $(".book-quick-view").css("margin-left", 0 - padding);
            else $(".book-quick-view").css("margin-right", 0 - padding);
            setTimeout(function() {
                if ($("body").attr("id") == "arabic") $(".book-quick-view").css("margin-left", "");
                else $(".book-quick-view").css("margin-right", "");
            }, 300);*/
            /*$(".book-quick-view-backdrop").remove();*/
        }
    });
    $("body").on("click", ".book-quick-view-btn", function (e) {
        e.preventDefault();
        if (!$("html,body").hasClass('book-quick-view-open')) {
            /*var padding = parseInt($(window).outerWidth()) - parseInt($("body").outerWidth());
            $("body").css("padding-right", padding);*/
            $("html,body").addClass('book-quick-view-open');
            /*$("body").append('<div class="book-quick-view-backdrop"><a href="#"></a></div>');*/
        }
    });
    //nav-toggle
    $("body").on("click", ".nav-toggle", function (e) {
        if ($("body.notification-open")[0]) $("html,body").removeClass('notification-open');
        $("html,body").toggleClass('nav-open');
    });
    $("body").on("click", ".blue-backdrop a", function (e) {
        $("html,body").removeClass('nav-open notification-open');
        $("html,body").removeClass('book-quick-view-open');
    });
    /*notification*/
    $("body").on("click", ".notification-btn", function (e) {
        if ($("body.nav-open")[0]) $("html,body").removeClass('nav-open');
        $("html,body").toggleClass('notification-open');
    });
    //history view
    $("body").on("click", ".history-view-btn", function (e) {
        $(".book-quick-view").toggleClass('history-view');
        $(".book-quick-view").removeClass('activeBorrorwer-view');
        $(this).parent().toggleClass('active');
        $('.active-borrower-btn').parent().removeClass('active');
        $(".custom-scroll").getNiceScroll().resize();
    });
    //Active Borrorwe
    $("body").on("click", ".active-borrower-btn", function (e) {
        $(".book-quick-view").toggleClass('activeBorrorwer-view');
        $(".book-quick-view").removeClass('history-view');
        $('.history-view-btn').parent().removeClass('active');
        $(this).parent().toggleClass('active');
        $(".custom-scroll").getNiceScroll().resize();
    });
    //nav dropdown
    $("body").on("click", ".sidebar .middle-nav>.dropdown>a,.sidebar .bottom-nav>.dropdown>a", function (e) {
        $(".dropdown.open").removeClass('open');
        e.stopPropagation();
        $(this).parent().addClass('open');
        var dropdown = $($(this).attr("data-target"));
        dropdown.parent().addClass('open');
        var dropdownHeight = dropdown.outerHeight();
        var dropdownWidth = dropdown.outerWidth();
        var top = $(this).offset().top;
        var left = $(this).offset().left;
        var width = $(this).outerWidth();
        var height = $(this).outerHeight();
        var scrollTop = $("html,body").scrollTop();
        var is_safari = /^((?!chrome|android).)*safari/i.test(navigator.userAgent);
        if (/Edge/.test(navigator.userAgent) || is_safari) {
            scrollTop = document.body.scrollTop;
        }
        var topBottomVar = "top";
        if ($("body").attr("id") == "arabic") left = left - (width * 2);
        else left = left + width;
        if ($(this).closest('.bottom-nav')[0] && $(window).outerWidth() < 768) {
            if ($("body").attr("id") == "arabic") left = left + dropdownWidth - width;
            else left = left - dropdownWidth;
            dropdown.css({
                "top": "60px",
                "left": left
            });
        } else {
            if (dropdownHeight + (top - scrollTop) < $(window).outerHeight()) {
                dropdown.css({
                    "top": top - scrollTop,
                    "left": left
                });
            } else {
                dropdown.css({
                    "top": ((top - scrollTop) - dropdownHeight) + height,
                    "left": left
                });
            }
        }
    });
    $("body").on("click", function () {
        $(".dropdown.open").removeClass('open');
    });
    $(".middle-nav-outer").on("scroll", function () {
        $(".sidebar .middle-nav>.dropdown.open,.sidebar .bottom-nav>.dropdown.open").removeClass('open');
    });
    //nicescroll
    $(window).resize(function (event) {
        if ($(window).outerWidth() > 767) {
            $(".custom-scroll").each(function () {
                var target = $(this);
                if (target.getNiceScroll().length > 0) {
                    setTimeout(function () {
                        target.getNiceScroll().resize();
                    }, 500);
                } else {
                    if ($("body").attr("id") == "arabic") {
                        target.niceScroll(target.children('.scroller-inner'), {
                            bouncescroll: false,
                            cursorcolor: "#999",
                            railalign: "left",
                            railpadding: {
                                top: 0,
                                right: 0,
                                left: 12,
                                bottom: 0
                            }
                        });
                    } else {
                        target.niceScroll(target.children('.scroller-inner'), {
                            bouncescroll: false,
                            cursorcolor: "#999",
                            railpadding: {
                                top: 0,
                                right: 6,
                                left: 0,
                                bottom: 0
                            }
                        });
                    }
                    $(this).css("overflow", "");
                }
            });
        } else {
            $(".custom-scroll").each(function () {
                var target = $(this);
                target.getNiceScroll().remove();
                $(this).attr("style", "overflow:auto!important");
            });
        }
    }).trigger("resize");
    //image uploader
    $("body").on("click", ".img-uploader a", function () {
        $(this).siblings('input[type="file"]').click();
    });
    /*floating form*/
    $("body").on("click", ".form-group.floating .control-label", function () {
        if (!$(this).siblings('.form-control')[0] && $(this).siblings('.input-group')[0]) $(this).siblings('.input-group').children('.form-control').trigger('focus');
        else $(this).siblings('.form-control').trigger('focus');
    });
    $("body").on("focus", ".form-group.floating .form-control", function () {
        if ($(this).parent().hasClass('input-group')) $(this).parent().parent().addClass('is-focused');
        else $(this).parent().addClass('is-focused');
    }).on("blur", ".form-group.floating .form-control", function () {
        var target = $(this).parent();
        if ($(this).parent().hasClass('input-group')) target = $(this).parent().parent();
        target.removeClass('is-focused');
        if ($(this).val() != "") target.addClass('has-value');
        else target.removeClass('has-value');
    });
    /*inner modal btn*/
    $("body").on("click", ".inner-modal-btn", function (e) {
        e.preventDefault();
        $(this).closest('.modal').modal("hide");
        var target = $(this);
        setTimeout(function () {
            $(target.attr("data-target")).modal("show");
        }, 400);
    });
    /*calendar*/
    $(".inline-calendar").each(function () {
        var target = $(this).find(".calendar-body");
        var dateHolder = $(this).find(".date-holder");
        pickmeup(target[0], {
            flat: true,
            mode: 'single',
            format: 'd b Y'
        });
        target.on("pickmeup-change", function () {
            var selectedValue = pickmeup(target[0]).get_date(true);
            dateHolder.val(selectedValue);
        });
        var selectedValue = pickmeup(target[0]).get_date(true);
        dateHolder.val(selectedValue);
    });
    $(".date-range-dropdown").each(function () {
        var target = $(this).find(".calendar-body");
        var dateHolder = $(this).find(".date-holder");
        pickmeup(target[0], {
            flat: true,
            mode: 'range',
            format: 'd b Y'
        });
        target.on("pickmeup-change", function () {
            var selectedValue = pickmeup(target[0]).get_date(true);
            dateHolder.val(selectedValue[0] + " - " + selectedValue[1]);
        });
    });
    $("body").on("click", ".date-range-dropdown .date-holder", function (e) {
        $(this).parent().addClass('open');
        $('.bootstrap-select.open').removeClass('open');
        e.stopPropagation();
    });
    $("body").on("click", ".date-range-dropdown .range-panel", function (e) {
        e.stopPropagation();
    });
    $("body").on("click", ".date-range-dropdown .close-btn", function (e) {
        $(this).closest('.date-range-dropdown').removeClass('open');
    });
    $("body").on("click", function () {
        $(".date-range-dropdown.open").removeClass('open');
    });
    //owl-carousel
    //$(".date-picker-carousel").on("initialized.owl.carousel", function () {
    //    dateCarouselLoadFlag = true;
    //    checkActiveDateCarousel();
    //}).owlCarousel({
    //    nav: true,
    //    navText: ['<img src="images/chevron-right-sm-blue.svg" alt="Next" class="next-arrow"><img src="images/chevron-left-sm-blue.svg" alt="Previous" class="prev-arrow">', '<img src="images/chevron-right-sm-blue.svg" alt="Next" class="next-arrow"><img src="images/chevron-left-sm-blue.svg" alt="Previous" class="prev-arrow">'],
    //    dots: false,
    //    loop: false,
    //    smartSpeed: 200,
    //    mouseDrag: false,
    //    rtl: $("body").attr("id") == "arabic",
    //    responsiveRefreshRate: 10,
    //    autoWidth: true,
    //    slideBy: 100
    //});
    /*toggle btn group*/
    $("body").on("click", ".btn-group.toggle .btn", function () {
        $(this).siblings('.active').removeClass('active');
        $(this).addClass('active');
    });
    /*message page searchbox*/
    $("body").on("click", ".messages .left-pane .searchbox >a", function () {
        $(this).closest('.header').addClass('open');
        var target = $(this);
        setTimeout(function () {
            target.siblings(".form-control").trigger("focus");
        }, 350);
    });
    $("body").on("click", ".messages .left-pane .header.open .searchbox>.search-close", function () {
        $(this).closest(".header.open").removeClass('open');
    });
    // chat page mobile back button
    $("body").on("click", ".messages .back-to-messages", function () {
        $(this).closest('.right-pane.open').removeClass('open');
    });
    $("body").on("click", ".messages .chat-list>li>a", function () {
        $(this).closest(".messages").find(".right-pane").addClass('open');
    });
    /*file upload btn trigger*/
    $("body").on("click", ".btn-file-upload-trigger", function (e) {
        $(this).siblings(".btn-file-upload").click();
    });
    //eqheight
    eqHeight(true);
    eqHeightAbs();
    //modal
    $(".modal").on("shown.bs.modal", function () {
        eqHeight();
    });
    $(window).resize(function () {
        eqHeight(true);
        eqHeightAbs();
        if ($(".modal.in")[0]) eqHeight();
    });
});

function checkActiveDateCarousel() {
    if (dateCarouselLoadFlag) {
        $(".date-picker-carousel-wrapper").each(function () {
            var target = $(this);
            setTimeout(function () {
                if (!target.find(".item a.active").parent().parent().hasClass('active'))
                    target.children('.owl-carousel').trigger("to.owl.carousel", target.find(".item a.active").parent().parent().index());
            }, 500);
        });
    }
}

function eqHeight(nomodal) {
    $(".eqHeight").each(function () {
        $(this).children().css("height", "");
        var target = $(this);
        setTimeout(function () {
            var ph = target.outerHeight();
            var inModal = false;
            if (nomodal) {
                if (target.closest('.modal')[0]) inModal = true;
                if (!inModal) target.children().height(ph);
            } else target.children().height(ph);
        }, 50);
    });

}
function eqHeightAbs() {
    $(".eqHeight-abs").each(function () {
        var targetSrc = $(this).children(".abs-target");
        var targetDest = new Array();
        $(this).children().each(function () {
            if (!$(this).hasClass('abs-target') && $(this).is(":visible")) {
                targetDest.push($(this));
                $(this).css("height", "");
            }
        });
        var srcHeight = targetSrc.outerHeight();
        for (var i = 0; i < targetDest.length; i++) {
            if (targetDest[i].outerHeight(true) >= srcHeight) return;
        }
        for (var i = 0; i < targetDest.length; i++) {
            targetDest[i].css("height", srcHeight);
        }
    });
}