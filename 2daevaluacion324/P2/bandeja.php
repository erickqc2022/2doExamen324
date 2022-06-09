<?php
session_start();
include "conexion.inc.php";
$sql="select * from seguimiento where usuario='".$_SESSION["usuario"]."' ";
$sql.="and fechafin is null";
$resultado=mysqli_query($conn, $sql);
?>
<table>
<tr>
	<td>Tramite</td>
	<td>Flujo</td>
	<td>Proceso</td>
	<td>Fecha Inicio</td>
	<td>Accion</td>
</tr>
<?php
while($fila=mysqli_fetch_array($resultado))
{
	echo "<tr>";
	echo "<td>".$fila["notramite"]."</td>";
	echo "<td>".$fila["flujo"]."</td>";
	echo "<td>".$fila["proceso"]."</td>";
	echo "<td>".$fila["fechainicio"]."</td>";
	echo "<td><a ";
	echo "href='desflujo.php?flujo=$fila[flujo]&proceso=$fila[proceso]'";
	echo ">Mostrar<a/></td>";
	echo "</tr>";
}
?>
</table>