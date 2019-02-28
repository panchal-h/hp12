//var chat = null;
//$(document).ready(() => {
////GetNewNotificationCount();
//chat = $.connection.notificationHub;
//chat.client.alert = function (id) {
//    console.log(id + " ----- " + new Date());
//};
//$.connection.transports.longPolling.supportsKeepAlive = function () {
//    return false;
//}
//$.connection.hub.qs = qs;
////$.connection.hub.start({ transport: ['longPolling', 'webSockets'], waitForPageLoad: false }).done(function () {
//$.connection.hub.start().done(function () {
//    //refreshUserNotificationCounts($('#hdfLoggedInUserID').val());
//    //refreshOnlineUsers();
//    //refreshRecentChats();
//});
//$.connection.hub.disconnected(function () {
//    setTimeout(function () {
//        $.connection.hub.start();
//    }, 5000); // Restart connection after 5 seconds.
//});
//});

$(function () {
    GetNewNotificationCount();
    GetNewMessageCount();

    setInterval(function () {
        GetNewNotificationCount();
        GetNewMessageCount();
    }, 60000);
});

function GetNewNotificationCount() {
    var getNotificationCountURL = $('.notificationbtn').attr('data-notificationcount-url');
    if (getNotificationCountURL) {
        $.ajax({
            type: "GET",
            url: getNotificationCountURL,
            traditional: true,
            success: function (response) {
                if (response && !isNaN(response.resultData)) {
                    $('.notificationbtn>.count').remove();
                    if (parseInt(response.resultData) > 0)
                        $('.notificationbtn').prepend('<span class="count">' + response.resultData + '</span>');
                }
            }
        });
    }
    return false;
}

var notificationReceived = false;
$("body").on("click", ".notificationbtn", function (e) {
    if ($("body.nav-open")[0]) $("html,body").removeClass('nav-open');
    $("html,body").toggleClass('notification-open');
    var url = $(this).attr('data-url');
    if (!notificationReceived && url && $("html,body").hasClass('notification-open')) {
        $.ajax({
            type: "GET",
            url: url,
            traditional: true,
            success: function (response) {
                notificationReceived = true;
                $('#notification-sidebar').removeClass('custom-loading').html(response);
                $('.notificationbtn>.count').remove();
                $("a[href='#event-requests']").click();
                $(window).trigger("resize");
            }
        });
    }
    return true;
});

var isEventRequestReceived = false;
$("body").on("click", "a[href='#event-requests']", function (e) {
    var url = $(this).attr('data-url');
    if (!isEventRequestReceived && url) {
        $.ajax({
            type: "GET",
            url: url,
            traditional: true,
            success: function (response) {
                isEventRequestReceived = true;
                $('#event-requests').removeClass('custom-loading').html(response);
                $(window).trigger("resize");
            }
        });
    }
    return true;
});

// To reset scroll for notification tab change.
$("body").on("click", "#notification-sidebar ul.nav.nav-tabs li", function (e) {
    $(window).trigger("resize");
});

function GetNewMessageCount() {
    var getMessageCountURL = $('.messagebtn').attr('data-messagecount-url');
    if (getMessageCountURL) {
        $.ajax({
            type: "GET",
            url: getMessageCountURL,
            traditional: true,
            success: function (response) {
                if (response && !isNaN(response.resultData)) {
                    $('.messagebtn>.count').remove();
                    if (parseInt(response.resultData) > 0)
                        $('.messagebtn').prepend('<span class="count">' + response.resultData + '</span>');
                }
            }
        });
    }
    return false;
}

