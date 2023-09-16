
export function renderWordCloud(canvasElement, words) {
    var canvas = canvasElement.getContext("2d");

    var sizeScale = d3.scaleLinear()
        .domain([0, d3.max(words, function (d) { return d.Size; })])
        .range([10, 70]);

    var layout = new WordCloud.layout()
        .size([canvasElement.width, canvasElement.height])
        .words(words.map(function (d) {
            return { text: d.Text, size: sizeScale(d.Size) };
        }))
        .padding(5)
        .fontSize(function (d) { return d.size; })
        .on("end", drawWordCloud);

    layout.start();

    function drawWordCloud(words) {
        canvas.clearRect(0, 0, canvasElement.width, canvasElement.height);

        for (var i = 0; i < words.length; i++) {
            var word = words[i];
            canvas.font = word.size + "px Arial";
            canvas.fillStyle = getRandomColor();
            canvas.fillText(word.text, word.x, word.y);
        }
    }

    function getRandomColor() {
        var letters = '0123456789ABCDEF';
        var color = '#';
        for (var i = 0; i < 6; i++) {
            color += letters[Math.floor(Math.random() * 16)];
        }
        return color;
    }
}