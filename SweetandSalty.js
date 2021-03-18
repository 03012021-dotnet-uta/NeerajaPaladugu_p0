function SweetandSalty() {

    for (var i = 1; i < 1001; i++) {
        if (i % 15 == 0) console.log("SweetandSalty");
        else if (i % 3 == 0) console.log("Sweet");
        else if (i % 5 == 0) console.log("Salty");
        else console.log(i);
    }

}