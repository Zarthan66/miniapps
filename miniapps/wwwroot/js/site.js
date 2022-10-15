$(function () {
    console.log("ready"); 

    $(document).on("click", ".game-button", function (event) {
        event.preventDefault();
        var buttonNumber = $(this).val();
        console.log("button " + buttonNumber + " was clicked");

        doButtonUpdate(buttonNumber);
        
    })

    

    function doButtonUpdate(buttonNumber) {
        $.ajax({
            datatype: "JSON",
            method: "POST",
            url: "/ButtonGrid/ShowOneButton",
            data: {
                "buttonNumber": buttonNumber
            },
            success: function (data) {
                console.log(data);
                $("#" + buttonNumber).html(data);
            }
        })
    }
})
/*
if (Model.ElementAt(0).State != Model.ElementAt(i).State) {
    allMatch = false;
}

@{
    string[] imgNames = { "btn_blue.png", "btn_green.png", "btn_orange.png", "btn_purple.png" };
    bool allMatch = true;
}
*/