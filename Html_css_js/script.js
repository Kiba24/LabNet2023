

//ASIGNACION DE VARIABLES
var msg = document.getElementById("resultado");
var maxNumber = document.getElementById("max-number")
var msgError = document.getElementById("txtError");
var btnMas = document.getElementById("btn-mas");
var btnMenos = document.getElementById("btn-menos");
var btnReintentar = document.getElementById("btn-reintentar") ;
var btnProbar = document.getElementById("btn-probar");
var msgVidas = document.getElementById("vidas");
var btnInput  = document.getElementById("numInput");
var highscore = document.getElementById("highscore");
var score = document.getElementById("score");

// SETUP    
var numToGuess = null;
msgError.style.visibility = "hidden";
var notPlaying = true;
var vidas = 10;
msgVidas.textContent = "💖 " + vidas;


// EVENTOS

btnMas.addEventListener("click", function () {
    if (notPlaying){
        if (maxNumber.textContent >= 99) {
            alert("No puede ser mayor a 99!");
        }
        else maxNumber.textContent++;
    }
    else alert ("No podes cambiar el numero cuando estas jugando, trampos@!");
});

btnMenos.addEventListener("click", function () {
    if (notPlaying){
        if (maxNumber.textContent <= 1) {
            alert("No podes algo menor que 1!");
        }
        else {
            maxNumber.textContent--;
        }
    }
    else alert ("No podes cambiar el numero cuando estas jugando, trampos@!");
});


btnProbar.addEventListener("click", function () {
    if (notPlaying) {
        numToGuess = Math.floor(Math.random() * maxNumber.textContent) + 1;
        console.log(numToGuess);
        notPlaying = false;
    }

    msgError.style.visibility = "hidden";
    console.log("input= ",btnInput.value);

    if (btnInput.value == ""){
        msgError.style.visibility = "visible";
    }

    else if (btnInput.value == numToGuess) {
        ganaste();
    }
    else if (btnInput.value > numToGuess) {
        msg.textContent = "Muy alto! Intenta de nuevo 😢";
        CheckVidas();
    }


    else if (btnInput.value < numToGuess) {
        msg.textContent = "Muy bajo! Intenta de nuevo 😢";
        CheckVidas();
    }


});


btnReintentar.addEventListener("click", function () {
    Reset();
});

 // FUNCIONES 


function CheckVidas() {
    vidas--;
    msgVidas.textContent = "💖 " + vidas
    score.textContent = "Score: " + vidas*126
    if (vidas < 1 ) {
        Perdiste();
    }
}

function Perdiste(){
    notPlaying = false;
    alert("Perdiste!");
    msgVidas.textContent = "💔 " + vidas;
    btnProbar.disabled = true;
    msg.textContent = "Perdiste! Reintentalo! 😭";

}

function Reset(){
    notPlaying = true;
    btnInput.value = 1;
    vidas = 11;
    maxNumber.textContent = 1;
    msgError.style.visibility = "hidden";
    CheckVidas();
    score.textContent = "Score: 0";
    msg.textContent = "Proba suerte, ingresa un numero! 🍀"
}

function ganaste(){
    alert("Ganaste!");
    highscore.textContent = "Highscore: " + vidas*126;
    notPlaying = false;
    msg.textContent = "Ganaste! Una partida mas! 🎉";
}