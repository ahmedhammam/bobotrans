Stanice kroz koje prolaze naši autobusi:
<br />
<br />
<ul>
<?php
$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
$rezultat = $soapClient->dajStanice()->dajStaniceResult->long;
for ($i=0;$i<count($rezultat);$i++)
{
	$rezultat2 = $soapClient->dajImeStanice(array('sifraStanice' => $rezultat[$i]));
	echo "<li>";
	echo $rezultat2->dajImeStaniceResult;
	echo "</li>";
}

?>
</ul>

<a href="linijeKrozStanicu.php">Pregled linija koje prolaze kroz stanicu</a><br />
<a href="voznjeKrozStanicu.php">Pregled vožnji koje prolaze kroz stanicu</a>