window.generateWordCloud = function() {
    var words = [
        { text: "Lorem", weight: 13 },
        { text: "Ipsum", weight: 10 },
        { text: "Dolor", weight: 8 },
        { text: "Sit", weight: 6 },
        { text: "Amet", weight: 9 }
    ];

    d3.layout.cloud().size([800, 400])
        .words(words)
        .padding(5)
        .rotate(function() { return ~~(Math.random() * 2) * 90; })
        .fontSize(function(d) { return d.weight * 10; })
        .on("end", draw)
        .start();

    function draw(words) {
        d3.select("#wordcloud")
            .append("svg")
            .attr("width", 800)
            .attr("height", 400)
            .append("g")
            .attr("transform", "translate(400, 200)")
            .selectAll("text")
            .data(words)
            .enter()
            .append("text")
            .style("font-size", function(d) { return d.size + "px"; })
            .style("fill", "steelblue")
            .attr("text-anchor", "middle")
            .attr("transform", function(d) {
                return "translate(" + [d.x, d.y] + ")rotate(" + d.rotate + ")";
            })
            .text(function(d) { return d.text; });
    }
};