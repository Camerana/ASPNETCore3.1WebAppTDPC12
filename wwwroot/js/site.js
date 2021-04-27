function ajaxCall() {
    var body = {};
    body.ID = "a3b5d487-0000-0000-0000-14d5c7813c8a";
    body.Nome = "Dante";
    body.Cognome = "Alighieri";
    $.ajax({
        method: "POST",
        url: "/api/Person",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(body),
        dataType: "json",
        success: function (data, status) {
            console.log(body);
            console.log(data);
            console.log(status);
            this.always();
        },
        error: function (error, status) {
            console.log(body);
            console.log(error);
            console.log(status);
            this.always();
        },
        always: function () { }
    });
};
/*
function ajaxCall(url, data) {
    $.ajax({
        type: "POST",
        url: url,
        //contentType: "application/json; charset=utf-8",
        data: data,
        dataType: "json",
        success: function (data, status) {

            this.always();
        },
        error: function (error, status) { this.always(); },
        always: function () { }
    });
}
*/