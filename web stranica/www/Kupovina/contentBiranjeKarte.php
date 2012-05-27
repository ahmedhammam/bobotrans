<?php
if (!isset($_REQUEST['Linija']))
{
include("contentBiranjeKarteLinija.php");
}
else if (!(isset($_REQUEST['Stanica1']) && isset($_REQUEST['Stanica2']) && isset($_REQUEST['Voznja'])))
{
include("contentBiranjeKarteVoznjaStanice.php");	
}
else
{
	$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
	$rezultat_provjera = $soapClient->ispravanRasporedStanica(array('sifraLinije'=>intval($_REQUEST['Linija']),'sifraPocetneStanice'=>intval($_REQUEST['Stanica1']),'sifraKrajnjeStanice'=>intval($_REQUEST['Stanica2'])));
	if($rezultat_provjera->ispravanRasporedStanicaResult==1)
	{
		include("contentBiranjeKarteSjedista.php");
	}
	else
	{
		echo "<p style='color:#ff0000'>Odaberite stanice ispravnim redosljedom!</p>";
		include("contentBiranjeKarteVoznjaStanice.php");
	}
}
?>