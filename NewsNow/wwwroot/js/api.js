﻿var get_comments = function (article) {
    return new Promise(resolve => {
        $.getJSON("/Articles/Comments/" + article, function (comments) {
            resolve(comments)
        })
    })
}

var new_comment = function (author, content, article_id) {
    console.log(author)
    console.log(content)
    console.log(article_id)
    return new Promise(resolve => {

        var data = JSON.stringify({ "Author": author, "Content": content, "ArticleId": article_id })

        console.log(data)

        $.ajax({
            url: "/api/Comments",
            type: "POST",
            data: data,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function () {
                resolve()
            }
        })
    })
}