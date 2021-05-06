function validar(){
	var nombre = document.getElementById("lnombre").value;
	var apellido = document.getElementById("lapellido").value;
	if(nombre == "" || apellido == ""){
		alert("Por favor complete el nombre y apellido.");
		return false;
	}
}

function limpiar(){
	document.getElementById("formulario").reset();
}