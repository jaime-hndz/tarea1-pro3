function calcula(){
    var credits = document.getElementById('creditos').value;
    var precio = 520;
    var total = credits * precio;
    document.getElementById('monto').innerHTML = total;
}