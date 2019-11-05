function runPrograme()
{
    var container=d3.select ("#container");
    var data=[100,200,300,400,500,600,700,800,900,1000];
    var yscale=d3.scaleLinear()
                 .domain([0,d3.max(data)])
                 .range([1,200]).clamp(true);
         var xscale=d3.scaleBand()
         .domain(data)
         .range([0,300])
         .padding(.1).round(true);
         for(var i=0;i<=data.length;i++)
         {
             var bar=container.append("div");
             bar.classed("bar",true)
             .style("width",xscale.bandwidth()+"px")
             .style("height",yscale(data[i])+"px")
             .style("margin-left",xscale(data[i])+"px")
         }
}