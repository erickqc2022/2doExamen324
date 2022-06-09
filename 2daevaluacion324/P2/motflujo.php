	<?php
	include "conexion.inc.php";
	$flujo=$_GET["flujo"];
	$proceso=$_GET["proceso"];
	$formulario=$_GET["formulario"];
	include $formulario.".mot.inc.php";
	if (isset($_GET["Siguiente"]))
	{
		$sql="select * from flujoproceso where flujo='".$flujo."' and proceso='".$proceso."'";
		$resultado=mysqli_query($conn, $sql);
		$fila=mysqli_fetch_array($resultado);
		$procesosiguiente=$fila["procesosiguiente"];
		header("Location: desflujo.php?flujo=".$flujo."&proceso=".$procesosiguiente);
	}
	else
	{
		$sql="select * from flujoproceso where flujo='".$flujo."' and procesosiguiente='".$proceso."'";
		$resultado=mysqli_query($conn, $sql);
		$fila=mysqli_fetch_array($resultado);
		$proceso=$fila["proceso"];
		header("Location: desflujo.php?flujo=".$flujo."&proceso=".$proceso);
	}
	
	?>
