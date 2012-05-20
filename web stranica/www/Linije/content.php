Linije po kojima saobraćaju naši autobusi:
<br />
<br />
<ul>
<?php
$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
$rezultat = $soapClient->dajLinije()->dajLinijeResult->long;
for ($i=0;$i<count($rezultat);$i++)
{
	$rezultat2 = $soapClient->dajImeLinije(array('sifraLinije' => $rezultat[$i]));
	echo "<li>";
	echo $rezultat2->dajImeLinijeResult;
	echo "</li>";
}

?>
</ul>

<a href="staniceNaLiniji.php">Pregled stanica kroz koje linija prolazi</a><br />
<a href="voznjeNaLiniji.php">Pregled vožnji koji idu po liniji</a>