function createGraph() {
    var svg = d3.select('#d3-container')
        .append('svg')
        .attr('width', 700)
        .attr('height', 700);

    var hierarchyData = {
        id: 'root',
        children: [
            {
                id: 'child1',
                children: [
                    { id: 'grandchild1' },
                    { id: 'grandchild2' }
                ]
            },
            {
                id: 'child2',
                children: [
                    { id: 'grandchild3' },
                    { id: 'grandchild4' }
                ]
            },
            {
                id: 'child3',
                children: [
                    { id: 'grandchild5' },
                    { id: 'grandchild6' }
                ]
            }
        ]
    };

    //var treeLayout = d3.tree().size([400, 200]);
	
	var treeLayout = d3.tree()
    .size([600, 200])
    .separation(function(a, b) {
        return a.parent === b.parent ? 1.5 : 2;
    });



    var rootNode = d3.hierarchy(hierarchyData);
    var treeData = treeLayout(rootNode);

    var nodes = treeData.descendants();
    var links = treeData.links();

    var link = svg.append('g')
        .selectAll('line')
        .data(links)
        .enter()
        .append('line')
        .style('stroke', '#ccc')
        .style('stroke-width', 1)
        .attr('x1', d => d.source.x + 100)
        .attr('y1', d => d.source.y + 150)
        .attr('x2', d => d.target.x + 100)
        .attr('y2', d => d.target.y + 150);

    var node = svg.append('g')
        .selectAll('circle')
        .data(nodes)
        .enter()
        .append('circle')
        .attr('r', 20)
        .style('fill', '#69b3a2')
        .attr('cx', d => d.x + 100)
        .attr('cy', d => d.y + 150)
        .on('click', function(event, d) {
            showNodeEditor(event, d);
        });

    var labels = svg.append('g')
        .selectAll('text')
        .data(nodes)
        .enter()
        .append('text')
        .text(d => d.data.id)
        .attr('x', d => d.x + 100)
        .attr('y', d => d.y + 175) // Переместите подписи под узлами
        .style('font-size', '12px')
        .style('text-anchor', 'middle'); // Центрируйте подписи под узлами

    function showNodeEditor(event, nodeData) {
        document.querySelector("#node-id-input").value = nodeData.data.id;
        document.querySelector("#save-node").onclick = function() {
            nodeData.data.id = document.querySelector("#node-id-input").value;
            labels.text(d => d.data.id);
            closeNodeEditor();
        };
        document.querySelector("#close-editor").onclick = closeNodeEditor;
        var nodeEditor = document.querySelector("#node-editor");
        nodeEditor.style.left = event.pageX + "px";
        nodeEditor.style.top = event.pageY + "px";
        nodeEditor.style.display = "block";
    }

    function closeNodeEditor() {
        document.querySelector("#node-editor").style.display = "none";
    }
}

