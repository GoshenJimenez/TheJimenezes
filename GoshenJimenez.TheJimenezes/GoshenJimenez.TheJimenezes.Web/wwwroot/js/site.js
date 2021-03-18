"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/signalHub").build();

connection.on("ReceiveNotification", function (userId, message) {
    if (currentUser == userId) {
        new Noty({ theme: 'metroui', type: 'Notification', layout: 'bottomLeft', text: message }).show();
    }
});

connection.start().then(function () {
    console.log("connection started");
});

function getColumns(type) {
    $.get("api/columns-per-type/" + type, function (data, status) {
        var template = `
                          <div class='post col-md-4'>
                            <div class='post-thumbnail'><a href='post.html'>#ICON#</a></div>
                            <div class='post-details'>
                                <div class='post-meta d-flex justify-content-between'>  
                                    <div class='date'>#DATE#</div>
                                </div>
                                <a href='/columns/#ID#'>
                                    <h3 class='h4'>#TITLE#</h3>
                                </a>
                                <p class='text-muted'>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore.</p>
                            </div>
                        </div>
                        `;
        var markup = "";

        $.each(data, function (index, column) {
            markup = markup + template.replace("#ID#", column.id).replace("#ICON#", column.iconUrl).replace("#DATE#", column.createdAt).replace("#TITLE#", column.title);
        });

        $("#column-list").html(markup);
        $(".col-icon").addClass("fa-10x");
    });
}

function showNoty(type, message) {
    new Noty({ theme: 'metroui', type: type, layout: 'bottomLeft', text: message }).show();
}