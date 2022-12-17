function isNumberKey(evt){
    var charCode = (evt.which) ? evt.which : evt.keyCode
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;
    return true;
}
function soloLetras(e) { 
    tecla = (document.all) ? e.keyCode : e.which;
    if (tecla==8) return true;
    patron =/[0123456789|*+-.<>$\/#!¡°&()_"=?¿%'{}[\]\\]/;
    te = String.fromCharCode(tecla);
    return !patron.test(te);
}

function openModal(){
    /*var myModal = new bootstrap.Modal(document.getElementById('modalFormServicio'));
    myModal.show()*/
}

