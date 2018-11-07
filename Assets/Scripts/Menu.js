var NombreEscena: String;

	function Empezar () {
		Application.LoadLevel(NombreEscena);	
	}
	
	function Salir(){
		Application.quit();
		
		Debug.log("Salir");
}
