// Create a list of fruits with their properties (name, color, pricePerKg)
// and convert it into a format so that for a given fruit name
// retrieval of its color and pricePerKg value is fast


// Write your code here
var fruitlist=[
    {"name":"banana","color":'yello',pricePerKg:50},
    {"name":"apple","color":'red',pricePerKg:100},
    {"name":"orange","color":'orange',pricePerKg:120}
];
function getdetails(fname)
{    
    try
    {
         var fruit= fruitlist.find(fruit => fruit.name === fname );
         return ("Fruit color ="+ fruit.color + "\n Fruit price =" + fruit.pricePerKg);
    }
    catch
    {
         return null;
    }
}
getdetails("applee");
