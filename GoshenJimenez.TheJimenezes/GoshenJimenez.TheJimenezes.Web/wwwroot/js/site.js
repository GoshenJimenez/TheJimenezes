function getColumns(type) {
    $.get("/columns/" + type, function (data, status) {
        var template = `
                          <div class='post col-md-4'>
                            <div class='post-thumbnail'><a href='post.html'>#ICON#</a></div>
                            <div class='post-details'>
                                <div class='post-meta d-flex justify-content-between'>  
                                    <div class='date'>#DATE#</div>
                                </div>
                                <a href='post.html'>
                                    <h3 class='h4'>#TITLE#</h3>
                                </a>
                                <p class='text-muted'>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore.</p>
                            </div>
                        </div>
                        `;
        var markup = "";

        $.each(data, function (index, column) {
            markup = markup + template.replace("#ICON#", column.iconUrl).replace("#DATE#", column.createdAt).replace("#TITLE#", column.title);
        });

        $("#column-list").html(markup);
        $(".col-icon").addClass("fa-10x");
    });
}