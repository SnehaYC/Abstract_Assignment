/* Write a Program to Flatten a given n-dimensional array */

const flatten = (ar) => {
	// Write your code here
	try{

	var arr=ar;
     var arr1=[].concat.apply([],arr);
     var arr2=[].concat.apply([],arr1);
	 var arr3=[].concat.apply([],arr2);
	 return arr3;
	}
	catch
	{
		return null;
	}
};
flatten([1, [2, 3], [[4], [5]]]);
/* For example,
INPUT - flatten([1, [2, 3], [[4], [5]])
OUTPUT - [ 1, 2, 3, 4, 5 ]

*/

module.exports = flatten;
