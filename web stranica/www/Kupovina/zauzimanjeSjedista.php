<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

<?php

include("postavljanjeSesije.php");

?>

<?php
if (isset($_POST['Sjediste']))
{
$sjedista=$_POST['Sjediste'];
if (!empty($sjedista))
{
	$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
	$cijenaJedneKarte = $soapClient->dajCijenuJedneKarte(array('sifraLinije' => $_POST['Linija'], 'sifraPocetneStanice' => $_POST['Stanica1'], 'sifraKrajnjeStanice' => $_POST['Stanica2']))->dajCijenuJedneKarteResult;
	
	//postavljanje rezervacije
	/*
	    $_SESSION['narudzbe'] je array od narudzbi, pri cemu je forma jedne narudzbe array:
		"Linija" =>
		"Voznja" =>
		"Sjedista" => array sjedista
		"Cijena" =>
	*/
	array_push($_SESSION['narudzbe'],array('Linija'=>$_POST['Linija'],'Voznja'=>$_POST['Voznja'], 'sifraPocetneStanice' => $_POST['Stanica1'], 'sifraKrajnjeStanice' => $_POST['Stanica2'],'Sjedista'=>$_POST['Sjediste'],'Cijena'=>($cijenaJedneKarte*count($_POST['Sjediste']))));
	$_SESSION['brojNarudzbi']++;
	header("location: preuzimanjeOdabranog.php");
}
else
{
	header("location: index.php");
}
}
else
{
	header("location: index.php");
}
?>

</head>

<body>
</body>
</html>