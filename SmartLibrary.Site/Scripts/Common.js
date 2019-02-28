var isEnglish;
function ShowMessage(type, msg, title, position, showclosebutton) {
    if (position == null || position == '') {
        toastr.options.positionClass = (isEnglish || 'true') == 'true' ? 'toast-top-right' : 'toast-top-left';
    }
    else {
        toastr.options.positionClass = position;
    }
    if (showclosebutton == null || showclosebutton == '' || showclosebutton == 'true') {
        toastr.options.closeButton = 'true';
    }
    //toastr.options.timeOut = '50000';
    //toastr.options.progressBar = true;
    switch (type) {
        case 'success': toastr.success(msg, title);
            break;
        case 'info': toastr.info(msg, title);
            break;
        case 'warning': toastr.warning(msg, title);
            break;
        case 'error': toastr.error(msg, title);
            break;
    }
}

function AddRequestHeader(xhr, $formId) {
    xhr.setRequestHeader('__RequestVerificationToken', $('input[name="__RequestVerificationToken"]', $formId).val());
}


var statusConstant = {
    success: 'success',
    error: 'error',
    warning: 'warning',
    info: 'info'
};

var requestTypeTodayActivityConstant = {
    BookDetails: 'BD',    
    RoomBookings: 'RB',
};

var confirmMessage, confirmTitle, confirmYes, confirmNo;

function InitDeleteConfirmation() {
    $('a.delete').each(function () {
        var $elem = $(this);

        $elem.click(function (e) {
            //var confirmMessage = $elem.attr('data-message');
            //if (confirmMessage == "" || confirmMessage == undefined) {
            //    confirmMessage = @SmartLibrary.Resources.General.ConfirmDeleteMessage;
            //}

            bootbox.confirm({
                title: confirmTitle,
                message: confirmMessage,
                buttons: {
                    confirm: {
                        label: confirmYes
                    },
                    cancel: {
                        label: confirmNo
                    }
                },
                callback: function (result) {
                    if (result) {
                        if (typeof DeleteCallback !== 'undefined') {
                            if (DeleteCallback && typeof (DeleteCallback) == typeof (Function)) {
                                DeleteCallback(e);
                            }
                        }
                    }
                }
            });
        });
    });
}
function EnableClientSideValidation($form) {
    $form.removeData("validator");
    $form.removeData("unobtrusiveValidation");
    $.validator.unobtrusive.parse("#" + $form.attr("id"));
}
//Restart Pace js for Ajax calls
$(document).ajaxStart(function () { Pace.restart(); });

function RemoveGridBottom(formName) {
    var tblUR = $('#' + formName).DataTable();
    if (!tblUR.data().count()) {
        $(".grid-bottom").hide();
    }
    else {
        $(".grid-bottom").show();
    }
}

$(document).ready(function () {
    $("body").on("focusout", ".form-group.floating .form-control", function () {
        if ($(this).find('.selectpicker').length == 1) {
            $(this).parent().removeClass('is-focused');
            if ($(this).closest(".form-group.floating").find('.selectpicker').val() != "" || $(this).closest(".form-group.floating").find('.selectpicker').hasClass('hasvalue')) $(this).parent().addClass('has-value');
            else $(this).parent().removeClass('has-value');
        }
    });
    if ($('form')[0] != undefined) {
        setFocusFirstControl('form');
    }
    $('body').on('shown.bs.modal', ".cus-modal", function () {
        setFocusFirstControl('form');
    })

    $(document).click(function (e) {
        if (!$(e.target).parents(".card-container").length == 1) {
            return;
        }
        else {
            if ($("body.nav-open")[0]) $("html,body").removeClass('nav-open');
            $("html,body").removeClass('notification-open');
        }       
    });
});

function ActiveMenu(liIDs) {
    $(".SideBarMenu").find("li.active").removeClass("active");
    if (liIDs instanceof Array) {
        $.each(liIDs, function (index, value) {
            $(".SideBarMenu").find(value).addClass("active");
        });
    }
    else {
        $(".SideBarMenu").find(liIDs).addClass("active");
    }
}

function DataTableCustomDateTimeFormat(data, format) {    
    format = (format == undefined || format == null) ? "YYYY-MM-DD h:mm A" : format;
    var dateString = '';
    if (data != undefined
        && data != null) {
        dateString = data.replace('/Date(', '');
        dateString = dateString.replace(')/', '');
        dateString = moment(parseInt(dateString)).format(format);
    }
    return dateString;
}

function DataTableFormatTime(data, type, row) {
    var dateString = '';
    if (data != undefined
        && data != null) {
        dateString = data.replace('/Date(', '');
        dateString = dateString.replace(')/', '');
        dateString = moment(parseInt(dateString)).format('HH:mm');
    }
    return dateString;
}

function GetScrollReset() {
    $(".custom-scroll").each(function () {
        var target = $(this);
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
                    right: 10,
                    left: 0,
                    bottom: 0
                }
            });
        }
        $(this).css("overflow", "");
    });
}

function isValidSearchCriteria(controlid) { 
    $("#" + controlid).removeClass('input-validation-error');
    $("#" + controlid).popover("destroy");
    var isValid = true;
    if ($("#" + controlid).val().match(/[<>()\{\}\[\]\\\/]/)) {
        $("#" + controlid).addClass('input-validation-error').addClass('has-error');
        $("#" + controlid).popover({
            container: 'body',
            content: IllegalCharMsg,
            toggle: "popover",
            placement: "top",
            trigger: "hover"
        });
        isValid = false;
    }
    else {
        $("#" + controlid).removeClass('input-validation-error');
        $("#" + controlid).popover("destroy");
    }

    return isValid;
}

$('#SearchBtnForList').click(function () {
    if (!isValidSearchCriteria('searchText')) { return false; }
    BindTable();
});

$('body').on('changed.bs.select', ".selectpicker", function (e, clickedIndex, newValue, oldValue) {
    var form = e.currentTarget.closest("form");
    if (form != undefined) {
        $(form).valid();
    }
});

function setFocusFirstControl(finder) {
    if ($(finder).find('input:visible,textarea:visible').not('.focusDisable').not('input:button').length > 0) {
        $(finder).find('input:visible,textarea:visible').not('.focusDisable').not('input:button').first().focus();
    }
}
$("body").on("click", ".book-quick-view-backdrop a,.book-quick-view .close-btn,.blue-backdrop a", function (e) {
    if ($("html,body").hasClass('book-quick-view-open')) {
        $('#bookDetailSideBar').html("");
    }
});