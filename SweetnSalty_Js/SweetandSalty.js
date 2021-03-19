function SweetandSalty() {

    let Sweet = 0;
    let Salty = 0;
    let SweetandSalty = 0;

    let arr = "";
    for (var i = 1; i < 1001; i++) {
        if (i % 15 == 0)

        {
            arr += "SweetandSalty ";

            SweetandSalty++;

        } else if (i % 3 == 0) {
            arr += "Sweet  ";

            Sweet++;
        } else if (i % 5 == 0) {
            arr += "Salty ";
            Salty++;
        } else arr += i + " ";
        if ((i - 1) % 10 == 0) {
            console.log(arr);
            arr = "";


        }

    }
    console.log("Sweetandsalty" + SweetandSalty);
    console.log("Salty" + Salty);
    console.log("Sweet" + Sweet);

}

SweetandSalty()