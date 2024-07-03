/* Write a Program to convert an array of objects to an object
	based on a given key */


    const convert = (arr,key) => {
        if(!Array.isArray(arr)){
			return null;
		}
		const res=(arr,key)=>
		arr.reduce((obj,item)=>{
			obj[item[key]]=item
			return obj
		},{});
		return res(arr,key)
     
    };
    let con_arr = convert([{id: 1, value: 'abc'}, {id: 2, value: 'xyz'}], 'id');
    console.log(con_arr);
    /* For example,
    INPUT - convert([{id: 1, value: 'abc'}, {id: 2, value: 'xyz'}], 'id')
    OUTPUT - {
                '1': {id: 1, value: 'abc'},
                '2': {id: 2, value: 'xyz'}
             }
    
    
    */
    
    module.exports = convert;
    