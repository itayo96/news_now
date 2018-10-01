var showdown_converters = function (converter) {
    return [
        {
            type: 'html',
            regex: '<img src=(.*)>',
            replace: '<img class="img-fluid img-thumbnail" src=$1>'
        },
        {
            type: 'lang',
            regex: /\!\[VIDEO\]\(.*\)/,
            replace: function (match, converter, options) {
                var url = match.slice(9, -1)

                return '<div class="embed-responsive embed-responsive-16by9"><video controls><source src="' + url + '"></video></div>'

            }
        }

        //<video width="320" height="240" controls><source src="movie.mp4" type="video/mp4"></video>
    ]
}

var make_markdown_editor = function (e, initial_content) {
    var simplemde = new SimpleMDE({ element: e, insertTexts: { video: ["![VIDEO](", ")"] } });
    var str = decodeHtml(initial_content)
    simplemde.value(str);
}

var markdown_to_html = function (markdown_string) {
    var converter = new showdown.Converter({ extensions: [showdown_converters] }),
        text = decodeHtml(markdown_string),
        html = converter.makeHtml(text);

    return html;
}

function decodeHtml(html) {
    var txt = document.createElement("textarea");
    txt.innerHTML = html;
    return txt.value;
}
