Stanice kroz koje prolazi odabrana linija:
<br />
<br />
<ul>
<?php
$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
$indeksLinije = intval($_GET["indeksLinije"]);
$rezultat2 = $soapClient->dajImeLinije(array('sifraLinije' => $indeksLinije))->dajImeLinijeResult;
if ($rezultat2 == "__GRESHKA__")
{
	echo "GREŠKA!<br />Odabrana linija ne postoji.";
}
else
{
	//ako je ispravna stanica
	
	$rezultat = $soapClient->dajStaniceULiniji(array('sifraLinije'=>$indeksLinije))->dajStaniceULinijiResult->long;
	for ($i=0;$i<count($rezultat);$i++)
	{
		$rezultat2 = $soapClient->dajImeStanice(array('sifraStanice' => $rezultat[$i]));
		echo "<li>";
		echo $rezultat2->dajImeStaniceResult;
		echo "</li>";
	}
}
?>
</ul>