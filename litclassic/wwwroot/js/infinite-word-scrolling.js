$(function () {
    $("#mainPanel").height($("#mainPanel").height);

    var loading;

    function loadMoreWords() {
        // обозначает начало процесса подгрузки слов
        loading = true;
        // показ блока загрузки
        $("#wordLoadingNotificationBlock").css("display", "inline-block");
        $("#noNotificationBlock").hide();
        $.ajax(
            {
                type: 'GET',
                url: '/Word/InfiniteScrolling',
                contentType: 'html',
                success: function (data, textstatus) {
                    $("#wordScrollList").append(data);
                    // скрытие блока загрузки
                    $("#wordLoadingNotificationBlock").hide();
                    $("#noNotificationBlock").show();
                    // обозначает завершения процесса подгрузки слов
                    loading = false;
                }
            });
    };


    // обработка события скроллинга
    $("#mainPanel").scroll(function () {
        $("#temp").text(document.getElementById("mainPanel").scrollHeight);
        if (($("#mainPanel").scrollTop() > (document.getElementById("mainPanel").scrollHeight - 2000)) && !loading) {
            loadMoreWords();
        }
    });
});