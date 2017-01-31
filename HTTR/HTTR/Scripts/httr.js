$(function () {

    var richmondHub = $.connection.richmondHub;

    $.connection.hub.start().done(function () {
        $(".thumbsUp").click(function () {
            richmondHub.server.rate(this.id, true);
        });
        $(".thumbsDown").click(function () {
            richmondHub.server.rate(this.id, false);
        });
    });

    richmondHub.client.updateRating = function (id, rating) {
        $("span[id='" + id + "']")[0].textContent = rating;
    }

    richmondHub.client.incrementCounter = function (counter) {
        $("#hitCounter").html(counter);
    }

    richmondHub.client.hailToTheRedskins = function (players) {
        for (i = 0; i <= players.length - 1; i++) {
            $("span[id='" + players[i].Id + "']")[0].textContent = players[i].Rating;
        }
    }

});

