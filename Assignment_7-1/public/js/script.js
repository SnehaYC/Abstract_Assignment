let productItem = [];
let favourites = [];

const getProducts = () => {
    return fetch("http://localhost:3000/products")
        .then((result) => {
            if (result.status == 200) {
                return Promise.resolve(result.json())
            }
            else {
                return Promise.reject("error")
            }
        }).then(Response => {
            console.log(Response);
            productItem = Response;
            createProductList();
        }
        ).catch(error => {
            alert(error);
        }
        )
}

const createProductList = () => {
    let products = "";
    productItem.forEach(product => {
        products += `<div class="card" >
  <img class="card-img-top" src="${product.thumbnail}" alt="Card image">
  <div class="card-body">
    <h4 class="card-title"> ${product.title} </h4>
    <p class="card-text"> ${product.description} </p>
    <p class="card-text"> Price: $${product.price} </p>
    <p class="card-text"> Discount Percentage:${product.discountPercentage} </p>
    <p class="card-text">Rating: ${product.rating} </p>
    <p class="card-text">Brand: ${product.brand} </p>
  
    <button type="button" onClick="addsaveforlater(${product.id})" class="btn btn-primary">Add Product </button> 
  </div>
</div>`
    });

    document.getElementById("products").innerHTML = products;
}

const getSaveForLater = () => {
    return fetch("http://localhost:3000/saveForLater")
        .then((result) => {
            if (result.status == 200) {
                return Promise.resolve(result.json())
            }
            else {
                return Promise.reject("error")
            }
        }).then(Response => {
            console.log(Response);
            favourites = Response;
            createSaveforlaterList();
        }
        ).catch(error => {
            alert(error);
        })
}

const createSaveforlaterList = () => {
    let saveforlater = "";
    favourites.forEach(product => {
        saveforlater += `<div class="card" style="width:400px">
  <img class="card-img-top" src="${product.thumbnail}" alt="Card image">
  <div class="card-body">
    <h4 class="card-title"> ${product.title} </h4>
    <p class="card-text"> ${product.description} </p>
    <p class="card-text"> Price: $${product.price} </p>
    <p class="card-text"> Discount Percentage:${product.discountPercentage} </p>
    <p class="card-text">Rating: ${product.rating} </p>
    <p class="card-text">Brand: ${product.brand} </p>
   
    <button type="button" onClick="deletefromsaveforlater(${product.id})" class="btn btn-danger">Delete Product </button> 
  </div>
</div>`
    });
    document.getElementById("saveforlater").innerHTML = saveforlater;

}

const addsaveforlater = (id) => {
    if (!isProductAlreadyInSaveforlaterlist(id)) {

        let productObject = getProductById(id)
        {
            console.log(productObject);
            favourites.push(productObject);
            return fetch("http://localhost:3000/saveForLater",
                {
                    method: 'POST',
                    body: JSON.stringify(productObject),
                    headers: {
                        'Content-Type': 'application/json',
                        'Accept': 'application/json'
                    }
                }).then((result) => {
                    if (result.status == 200 || result.status == 201) {
                        return Promise.resolve(favourites);

                    }
                    else {
                        return Promise.reject("Movie is already there in favourite section")
                    }

                }).then((Result) => {
                    createSaveforlaterList();
                    return Result;
                }).catch(error => {
                    throw new Error(error);
                })
        }
    }
    else {
        alert("Movie is already there in favourite section");
    }


}

const isProductAlreadyInSaveforlaterlist = (id) => {

    for (let fav in favourites) {
        if (id == favourites[fav].id) {

            return true;
        }
        alert("false");
    }
    return false;
}

const getProductById = (id) => {
    for (let product in productItem) {
        if (id == productItem[product].id) {
            return productItem[product];
        }
    }
}
const deletefromsaveforlater = (id) => {
    return fetch("http://localhost:3000/saveForLater/" + id,
        {
            method: 'delete'
        }
    )
        .then((result) => {
            if (result.status == 200) {
                return Promise.resolve(result.json());
            }
            else {
                return Promise.reject("Error");
            }
        }).then(response => {
            alert("Record delete from favourite")
            favourites = response;
            createSaveforlaterList();
        }
        ).catch(error => {
            alert(error);
        })
}