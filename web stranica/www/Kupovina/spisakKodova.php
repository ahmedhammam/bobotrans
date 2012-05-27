<?php

function dajImeLinije($x)
{
	$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
	$rezultat2 = $soapClient->dajImeLinije(array('sifraLinije' => $x));
	return $rezultat2->dajImeLinijeResult;
}

function dajImeVoznje($x)
{
	$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
	$rezultat2 = $soapClient->dajPodatkeVoznje(array('sifraVoznje' => $x));
	return $rezultat2->dajPodatkeVoznjeResult;
}

function dajSpisakSjedista($x)
{
	$sada="";
	if (!empty($x))
	{
		$sada=$sada.sprintf("%d",$x[0]);
		for ($t=1;$t<count($x);$t++)
		{
			$sada=$sada.sprintf(", %d",$x[$t]);
		}
	}
	return $sada;
}

function dajImeStanice($x)
{
	$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
	$rezultat2 = $soapClient->dajImeStanice(array('sifraStanice' => $x));
	return $rezultat2->dajImeStaniceResult;
}

$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
if (isset($_SESSION['kodovi']))
{
for ($i=0;$i<count($_SESSION['kodovi']);$i++)
	{
		echo sprintf("%s, %s, od %s do %s<br/>sjedišta: %s<br/>",
		dajImeLinije($_SESSION['kodovi'][$i]["sifraLinije"]),
		dajImeVoznje($_SESSION['kodovi'][$i]["sifraVoznje"]),
		dajImeStanice($_SESSION['kodovi'][$i]["sifraPocetneStanice"]),
		dajImeStanice($_SESSION['kodovi'][$i]["sifraKrajnjeStanice"]),
		dajSpisakSjedista($_SESSION['kodovi'][$i]["sjedista"]));
		echo sprintf("Šifra: %s<br/>",$_SESSION['kodovi'][$i]["kod"]);
		echo sprintf('<img src="http://qrcode.kaywa.com/img.php?s=8&d=%s" alt="qrcode"  /><br />',$_SESSION['kodovi'][$i]["kod"]);
	}
}
session_destroy();
?>