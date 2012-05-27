<?php
if ($_REQUEST['status']==1)
{
	echo "<p>Vaša kartica je neispravna/odbijena</p>";
}
if ($_REQUEST['status']==2)
{
	echo "<p>Nemate dovoljno sredstava na kartici</p>";
}
if ($_REQUEST['status']==0)
{
	echo "<p>Vaša kupovina je prošla uspješno. Spisak kodova za preuzimanje karata:<br/>";
	include("spisakKodova.php");
	echo "</p>";
}
?>