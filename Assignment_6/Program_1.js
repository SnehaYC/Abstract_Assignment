/* Write a program to build a `Pyramid of stars` of given height */

const buildPyramid = (num) => {
        // Write your code here
        var iSize = num;
        var pyramid = '';
        for (var i=1; i<=iSize; i++){
            for(var k=1; (k<=iSize-i); k++){
                pyramid += ' ';
            }
            for(var j=1; j<=i; j++ ){
                pyramid += ' *';
            }
            pyramid += "  \n";
        }
        console.log(pyramid);
        //return pyramid;
};
buildPyramid(6)

/* For example,
INPUT - buildPyramid(6)
OUTPUT -
     *
    * *
   * * *
  * * * *
 * * * * *
* * * * * *

*/

//module.exports = buildPyramid;
