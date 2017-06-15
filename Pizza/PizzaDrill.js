
function getReceipt() {
    var totalCost = 0;
    var sizeCost = 0;
	var sizeArray = document.getElementsByClassName("size");
    var siztxt = "";
    var i;
		
    for (i = 0; i < sizeArray.length; i++) {
        if (sizeArray[i].checked) {
			var selectedSize = sizeArray[i].value;
            siztxt = siztxt + sizeArray[i].value;
        }
    }
	if (selectedSize === "Personal Pizza") {
		sizeCost = 6;
	} else if (selectedSize === "Medium Pizza") {
		sizeCost = 10;
	} else if (selectedSize === "Large Pizza") {
		sizeCost = 14;
	} else if (selectedSize === "Extra Large Pizza") {
		sizeCost = 16;
	}
	totalCost = sizeCost;
	
    document.getElementById("receipt").style.visibility = "visible";
	document.getElementById("orderConf").innerHTML = "<strong>Order Details:</strong>";
	document.getElementById("pieSize").innerHTML = siztxt + " " + "$" + sizeCost + ".00";
	
	getCrust(totalCost);
}

function getCrust(totalCost) {
	var totalCost = totalCost;
	var crustCost = 0;
	var crustArray = document.getElementsByClassName("crust");
	var crstxt = "";
	var ii;
	
	for (ii = 0; ii < crustArray.length; ii++) {
		if (crustArray[ii].checked) {
			var selectedCrust = crustArray[ii].value;
			crstxt = crstxt + crustArray[ii].value;
		}
	}
	if (selectedCrust === "Cheese Stuffed Crust") {
		crustCost = 3;
	} else {
		crustCost = 0;
	}
	totalCost = totalCost + crustCost;	
	
	document.getElementById("crustType").innerHTML = crstxt + " " + "$" + crustCost + ".00";
		
	getSauce(totalCost);
}

function getSauce(totalCost) {
	var totalCost = totalCost;
	var sauceArray = document.getElementsByClassName("sauce");
	var sauctxt = "";
	var iii;
	
	for (iii = 0; iii < sauceArray.length; iii++) {
		if (sauceArray[iii].checked) {
			sauctxt = sauctxt + sauceArray[iii].value;
		}
	}
		
	document.getElementById("sauceType").innerHTML = sauctxt + " " + "$0.00";
	document.getElementById("grandTotal").innerHTML = "TOTAL:" + " " + "$" + totalCost + ".00";
	
	getCheese(totalCost);
}

function getCheese(totalCost) {
	var totalCost = totalCost;
	var cheeseCost = 0;
	var cheeseArray = document.getElementsByClassName("cheese");
	var chztxt = "";
	var iv;
	
	for (iv = 0; iv < cheeseArray.length; iv++) {
		if (cheeseArray[iv].checked) {
			var selectedCheese = cheeseArray[iv].value;
			chztxt = chztxt + cheeseArray[iv].value;
		}
	}
	if (selectedCheese === "Extra Cheese") {
		cheeseCost = 3;
	} else {
		cheeseCost = 0;
	}
	totalCost = totalCost + cheeseCost;
	
	document.getElementById("chzType").innerHTML = chztxt + " " + "$" + cheeseCost + ".00";
	document.getElementById("grandTotal").innerHTML = "TOTAL:" + " " + "$" + totalCost + ".00";
	
	getMeat(totalCost);
}

function getMeat(totalCost) {
	var totalCost = totalCost;
	var meatCost = 0;
	var meatArray = document.getElementsByClassName("meat");
	var selectedMeat = [];
	var meatxt = "";
	var m;
	
	for (m = 0; m < meatArray.length; m++) {
		if (meatArray[m].checked) {
			selectedMeat.push(meatArray[m].value);
			meatxt = meatxt + meatArray[m].value + "&nbsp;&nbsp;&nbsp;";
		}
	}
	var meatCount = selectedMeat.length;
		if (meatCount > 1) {
			meatCost = (meatCount - 1);
		} else {
			meatCost = 0;
		}
	totalCost = totalCost + meatCost;
	
	if (selectedMeat.length >= 1) {
		document.getElementById("meatTop").innerHTML = meatxt + " " + "$" + meatCost + ".00";
	}
	document.getElementById("grandTotal").innerHTML = "TOTAL:" + " " + "$" + totalCost + ".00";
	
	getVeggie(totalCost);
}

function getVeggie(totalCost) {
	var totalCost = totalCost;
	var vegCost = 0;
	var vegArray = document.getElementsByClassName("veg");
	var selectedVeg = [];
	var vegtxt = "";
	var v;
	
	for (v = 0; v < vegArray.length; v++) {
		if (vegArray[v].checked) {
			selectedVeg.push(vegArray[v].value);
			vegtxt = vegtxt + vegArray[v].value + "&nbsp;&nbsp;&nbsp;";
		}
	}
	var vegCount = selectedVeg.length;
		if (vegCount > 1) {
			vegCost = (vegCount - 1);
		} else {
			vegCost = 0;
		}
	totalCost = totalCost + vegCost;
	
	if (selectedVeg.length >= 1) {
		document.getElementById("vegTop").innerHTML = vegtxt + " " + "$" + vegCost + ".00";
	}
	document.getElementById("grandTotal").innerHTML = "TOTAL:" + " " + "$" + totalCost + ".00";
}

function clrForm() {
	document.getElementById("menu").reset();
	document.getElementById("receipt").style.visibility = "hidden";
}