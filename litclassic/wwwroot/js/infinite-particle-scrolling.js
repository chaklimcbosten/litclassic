//FROM https://metanit.com/sharp/articles/mvc/15.php

$(function () {

    // переменная, показывающая началась лишь сейчас загрузка "частиц"
    // переменная, которая содержит высоту страницы на предыдущей фазе загрузке "частиц"
    // загружать "частицы", если уже не загружаются новые, а также тогда, когда ползунок
    // прошёл высоту страницы предыдущей фазы

    $("#mainPanel").height($("#mainPanel").height);

    var loading;

    function loadMoreParticles() {
        // обозначает начало процесса подгрузки "частиц"
        loading = true;
        // показ блока загрузки
        $("#particleLoadingNotificationBlock").css("display", "inline-block");
        $("#noNotificationBlock").hide();
        $.ajax(
            {
                type: 'GET',
                url: '/Particle/InfiniteScrolling',
                contentType: 'html',
                success: function (data, textstatus) {
                    $("#particleScrollList").append(data);
                    // скрытие блока загрузки
                    $("#particleLoadingNotificationBlock").hide();
                    $("#noNotificationBlock").show();
                    // обозначает завершения процесса подгрузки "частиц"
                    loading = false;
                }
            });
    };

    // обработка события скроллинга
    $("#mainPanel").scroll(function () {
        // FROM https://stackoverflow.com/questions/38796726/if-window-scrolltop-document-height-window-height-300-wh/38796911
        if (($("#mainPanel").scrollTop() > (document.getElementById("mainPanel").scrollHeight - 2000)) && !loading) {
            loadMoreParticles();
        }
    });
});